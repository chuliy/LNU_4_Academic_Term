using System;

namespace Newton
{   
    class Program
    {
        static double EPSILON = 0.00001;

        static double func(double x)
        {
            return x - 2;
        }


        static double deriveredFunc(double x)
        {
            double d = EPSILON / 100;
            return (func(x + d) - func(x)) / d;
        }

       
        static void newtonRaphson(double x)
        {
            double h = func(x) / deriveredFunc(x);
            int cnt = 0;
            while (Math.Abs(h) >= EPSILON)
            {
		cnt++;
                h = func(x) / deriveredFunc(x);

                x = x - h;
            }

            Console.WriteLine("The value of the"
                        + " root is : "
                        + (x * 100.0 / 100.0));
	    Console.WriteLine("Iteration : " + cnt);
        }

        public static void Main()
        {
            Console.WriteLine("Input x0");
            double x0 = Convert.ToDouble(Console.ReadLine());
            newtonRaphson(x0);
            Console.ReadLine();
        }
    }

}
