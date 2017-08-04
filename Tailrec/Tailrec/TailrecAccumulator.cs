using System;
using System.Collections.Generic;
using System.Linq;

namespace Tailrec
{
    public class TailrecAccumulator<T1, T2, TResult>
    {
        private struct ParametersInput
        {
            public T1 T1 { get; set; }
            public T2 T2 { get; set; }
        }

        private readonly List<ParametersInput> _accumulated = new List<ParametersInput>(5);
        private readonly Func<T1, T2, TResult> _output;

        public Action<T1, T2> Head => Feed;

        public Func<T1, T2, bool> Reccurent { get; set; }

        public TailrecAccumulator(Func<T1, T2, TResult> output)
        {
            _output = output;
        }

        public TResult Accumulator(T1 t1, T2 t2)
        {
            while (Reccurent(t1, t2))
            {
                ParametersInput last = _accumulated.Last();

                t1 = last.T1;
                t2 = last.T2;
            }

            return _output(t1, t2);
        }

        private void Feed(T1 t1, T2 t2)
        {
            _accumulated.Add(new ParametersInput { T1 = t1, T2 = t2 });
        }
    }
}
