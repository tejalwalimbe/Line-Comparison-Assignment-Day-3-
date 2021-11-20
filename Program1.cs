using System;
//using System.Math;
using static System.Math;

namespace LineComparison
{
    class Program3

    {
        public static void Main(string[] args)
        {
            //user Input
            Console.Write("Enter any  value x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());


            double distance = Convert.ToDouble(Console.Read());
            //using distance formula to find out distance
            distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine(distance);
            Console.ReadKey();
        }
    }


}
