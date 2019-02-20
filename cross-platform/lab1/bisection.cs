using System;

namespace Bisection
{
    class Bisection
    {
        static double EPSILON = 0.0001;

        static double func(double x)
        {
            return x - 2;
        }

        public static void bisection(double a, double b)
        {
            if (func(a) * func(b) >= 0)
            {
                Console.WriteLine("You have not assumed right a and b");
                return;
            }

            double c = a;
            while ((b - a) >= EPSILON)
            {

                c = (a + b) / 2;

                if (func(c) == 0.0)
                    break;

                else if (func(c) * func(a) < 0)
                    b = c;
                else
                    a = c;
            }

            Console.WriteLine("The value of " +
                              "root is : " + c);

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
            
            Bisection.bisection(a, b);
            
        }
    }
}
