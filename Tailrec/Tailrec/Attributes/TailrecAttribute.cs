using System;

namespace Tailrec.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TailrecAttribute: Attribute
    {
    }
}
