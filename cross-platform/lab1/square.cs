using System;
namespace SquareEquation
{
	class Application
	{
	static void Main(string[] args)
	{

	double a,b,c,d,x1,x2;
	Console.WriteLine("input a");
	a = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("input b");
	b = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("input c");
	c = Convert.ToDouble(Console.ReadLine());
	d = b*b - 4*a*c;

bool isNull = false;
    double diff = Math.Abs(a - b);
    if (diff <= 0.000001)
        isNull=true;
    isNull = (diff <= ( (Math.Abs(a) < Math.Abs(b) ? Math.Abs(b) : Math.Abs(a)) * 0.000001));

	if(isNull)
	{
		x1 = -b / (2*a);
		x2 = x1;
	Console.WriteLine("x1 = {0} ",x1); 
	Console.WriteLine("x2 = {0} ",x2);
	}
	else if(d > 0.0)
	{
		x1 = (-b + Math.Sqrt(d)) / (2*a);
		x2 = (-b - Math.Sqrt(d)) / (2*a);
	Console.WriteLine("x1 = {0} ",x1); 
	Console.WriteLine("x2 = {0} ",x2);
	}
	else
	{
	double realPathX1, realPathX2, imaginaryPath;
	realPathX1 = -b / (-2 * a);
	realPathX2 = -b / (2 * a);
	imaginaryPath = Math.Sqrt(Math.Abs(d))/(2*a);
	Console.WriteLine("\n x1 = {0} + j{1}",realPathX1,imaginaryPath);
	Console.WriteLine("\n x2 = {0} - j{1}",realPathX2,imaginaryPath);
}
}
}
}		