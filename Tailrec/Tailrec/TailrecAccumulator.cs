using System;

namespace Tailrec
{
    public class TailrecAccumulator<T1, T2, TResult>
    {
        private struct ParametersInput
        {
            public T1 T1 { get; set; }
            public T2 T2 { get; set; }
        }

        private ParametersInput _accumulated;
        private readonly Func<T1, T2, Action<T1, T2>, bool> _input;
        private readonly Func<T1, T2, TResult> _output;

        public TailrecAccumulator(Func<T1, T2, Action<T1, T2>, bool> input, Func<T1, T2, TResult> output)
        {
            _input = input;
            _output = output;
        }

        public TResult Accumulator(T1 t1, T2 t2)
        {
            while (_input(t1, t2, Feed))
            {
                t1 = _accumulated.T1;
                t2 = _accumulated.T2;
            }

            return _output(t1, t2);
        }

        private void Feed(T1 t1, T2 t2)
        {
            _accumulated.T1 = t1;
            _accumulated.T2 = t2;
        }
    }
}
