using System;

namespace Tailrec.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var program = new Program();

            int result = program.Method(0, 10);

            Console.WriteLine(result);
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
    }
}