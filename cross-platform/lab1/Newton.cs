using System;

namespace Newton
{   
    class Program
    {
        static double func(double x)
        {
            return x - 10;
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        static double deriveredFunc(double x, double EPSILON)
        {
            double d = EPSILON / 100;
            return (func(x + d) - func(x)) / d;
        }
        static double f2p(double x, double EPSILON)
        {
            double d = EPSILON / 100.0;
            return ((func(x + d) + func(x - d) - 2 * func(x)) / (d*d));
        }

        private static void Newton(double a, double b, double eps, int kmax)
        {
            double dx, x0;
            int i;
            if (a > b)
            {
                Console.WriteLine("A is bigger than B, check the [A,B] interval");
                return;
            }
            if (f(a) * f2p(a) > 0)
                x0 = a;
            else
                x0 = b;
            for (i = 1; i < kmax; i++)
            {
                dx = f(x0) / deriveredFunc(x0);
                x0 -= dx;
                if (Math.Abs(dx) < eps)
                {
                    Console.WriteLine("Result:");
                    Console.WriteLine("\tX = " + x0);
                    Console.WriteLine("\tf(x) = " + f(x0));
                    Console.WriteLine("\tNumber of iteration = " + i);
                    return;
                }
            }
            Console.WriteLine("For entered max number of iterations, the root is not found");
            return;
        }

        // Driver code 
        public static void Main()
        {

            // Initial values assumed 
            Console.WriteLine("Input a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input epsilon");
            double EPSILON = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input kmax");
            int kmax = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Program.Swap(ref a, ref b);
            }

            newtonRaphson(a,b,EPSILON,kmax);
        }
    }
}
