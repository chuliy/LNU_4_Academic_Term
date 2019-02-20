using System;

namespace SinInTaylorSeries
{
    class Program
    { 
        static double cal_sin(double n, ref int iteration)
        {
            double accuracy = 1e-6, denominator, sinx, sinval;

            n = n * (float)(3.1415 / 180.0);

            double x1 = n;

            sinx = n;

            sinval = (float)Math.Sin(n);
            int i = 1;
            do
            {
                denominator = 2 * i * (2 * i + 1);
                x1 = -x1 * n * n / denominator;
                sinx = sinx + x1;
                i = i + 1;
            } while (accuracy <= Math.Abs(sinval - sinx));
            iteration = i;
            return sinx;
        }
        static public void Main()
        {
            Console.WriteLine("Press 0 to enter values in radians, 1 in degrees");
            int userInput = Convert.ToInt32(Console.ReadLine());
            double angle = 0.0;
            if(userInput == 0)
            {
                Console.WriteLine("Input angle in radians");
                angle = Convert.ToDouble(Console.ReadLine());
                angle = angle * (double)(3.1415 / 180.0);
            }
            else
            {
                Console.WriteLine("Input angle in degrees");
                angle = Convert.ToDouble(Console.ReadLine());
            }
            int iteration = 0;
            Console.WriteLine("sin({0}) = {1} ", angle,cal_sin(angle,ref iteration));
            Console.WriteLine("number of terms of the taylor series = {0}", iteration);
        }
    }
}
