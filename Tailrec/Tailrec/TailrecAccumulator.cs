using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

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

        public TailrecAccumulator(MethodInfo methodInfo, object target)
        {
        }

        public TResult Accumulator(T1 t1, T2 t2)
        {
            
        }
    }
}
