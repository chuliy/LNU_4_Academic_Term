using System;

namespace Bisection
{
    class Bisection
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }


        static double func(double x)
        {
            return (Math.Pow(Math.E, -x) - Math.Log10(1 - Math.Pow(x, 2)) - 2);
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

                if (func(c) == 0.0)
                    break;

                else if (func(c) * func(a) < 0)
                    b = c;
                else
                    a = c;
            }

            Console.WriteLine("The value of " +
                              "root is : " + c + " ;");
            Console.WriteLine("cnt = " + cnt +" ;");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input epsilon");
            double epsilon = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Bisection.Swap(ref a, ref b);
            }
            Bisection.bisection(a, b, epsilon);
        }
    }
}