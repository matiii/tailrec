using System;

namespace Tailrec.Demo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            var program = new Program();

            int result2 = program.MethodWithAccumulator(0, 0);

            Console.WriteLine(result2);
            Console.ReadKey();
        }

        public int Method(int x, int y)
        {
            if (y > 0)
            {
                return Method(x + 1, y - 1);
            }

            return x;
        }

        public int MethodWithAccumulator(int x, int y)
        {
            var tailrec = new TailrecAccumulator<int, int, int>((a, b, c) =>
            {
                if (b > 0)
                {
                    c(a + 1, b - 1);

                    return true;
                }

                return false;
            },
            (a, b) => a);

            return tailrec.Accumulator(x, y);
        }
    }
}