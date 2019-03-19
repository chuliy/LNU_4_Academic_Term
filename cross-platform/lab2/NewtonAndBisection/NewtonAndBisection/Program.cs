using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static double func(double x)
        {
            return Math.Pow(Math.E, -x) - Math.Log10(1 - Math.Pow(x, 2)) - 2;
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
            return ((func(x + d) + func(x - d) - 2 * func(x)) / (d * d));
        }
        static void newtonRaphson(double a, double b, double EPSILON, int kmax)
        {
            double x = b;
            if (func(x) * f2p(x, EPSILON) < 0.0)
            {
                x = a;
            }
            else if (Math.Abs(func(x) * f2p(x, EPSILON)) <= EPSILON)
            {
                Console.WriteLine("error");
                return;
            }
            int cnt = 0;
            double h = func(x) / deriveredFunc(x, EPSILON);
            for (int i = 1; i <= kmax; i++)
            {
                h = func(x) / deriveredFunc(x, EPSILON);

                x = x - h;
                if (Math.Abs(h) <= EPSILON)
                {
                    Console.WriteLine("The value of the"
                + " root is : "
                + Math.Round(x * 100.0) / 100.0);
                    Console.WriteLine("Number of iteration = " + cnt);
                }
                return;
            }
            Console.WriteLine("For entered max number of iterations, the root is not found");
        }

        public static void bisection(double a, double b, double EPSILON)
        {
            int cnt = 0;
            if (func(a) * func(b) >= 0)
            {
                Console.WriteLine("You have not assumed right a and b");
                return;
            }
            else if (Math.Abs(func(a)) <= EPSILON)
            {
                Console.WriteLine("x = " + a + " ; cnt = " + cnt);
                return;
            }
            else if (Math.Abs(func(b)) <= EPSILON)
            {
                Console.WriteLine("x = " + b + " ; cnt = " + cnt);
                return;
            }
            double c = a;

            while ((b - a) >= EPSILON)
            {
                cnt++;

                c = (a + b) / 2;

                if (Math.Abs(func(c)) <= EPSILON)
                    break;

                else if (func(c) * func(a) < 0)
                    b = c;
                else
                    a = c;
            }

            Console.WriteLine("The value of " +
                              "root is : " + c + " ;");
            Console.WriteLine("cnt = " + cnt + " ;");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input 1 for newton and 0 for bisection");
            bool result = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Input a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input epsilon");
            double EPSILON = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Program.Swap(ref a, ref b);
            }
            if (result)
            {
                Console.WriteLine("Input kmax");
                int k = Convert.ToInt32(Console.ReadLine());
                newtonRaphson(a, b, EPSILON, k);
            }
            else
            {
                bisection(a, b, EPSILON);
            }

        }
    }
}