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
       
        static void newtonRaphson(double a,double b, double EPSILON)
        {
            double x = b;
            if (func(x) * f2p(x,EPSILON) < 0.0)
            {
                x = a;
            }
            else if(Math.Abs(func(x)* f2p(x,EPSILON)) <= EPSILON)
            {
                Console.WriteLine("error");
                return;
            }
            int cnt = 0;
                double h = func(x) / deriveredFunc(x,EPSILON);
                while (Math.Abs(h) >= EPSILON)
                {
                cnt++;
                    h = func(x) / deriveredFunc(x,EPSILON);

                    x = x - h;
                }

                Console.WriteLine("The value of the"
                            + " root is : "
                            + Math.Round(x * 100.0) / 100.0);
            Console.WriteLine("cnt = " + cnt);

            
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

            newtonRaphson(a,b,EPSILON);
            Console.ReadLine();
        }
    }
}
/*
Console.WriteLine("{0}", d); // 3,1415926
Console.WriteLine("{0:F2}", d); // 3,14
Console.WriteLine(string.Format("{0}", d)); // 3,1415926
Console.WriteLine(string.Format("{0:F3}", d)); // 3,142
Console.WriteLine(d.ToString("F2")); // 3,14
Console.WriteLine(d.ToString("E")); // 3,141593E+000
Console.WriteLine(d.ToString("C")); // 3,14 грн.
Console.WriteLine(d.ToString("G")); // 3,1415926
Console.WriteLine(d.ToString("R")); // 3,1415926
*/