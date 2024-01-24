using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter lenght");
            double lenght= double.Parse(Console.ReadLine());

            Console.WriteLine("enter width");
            double width= double.Parse(Console.ReadLine());

            double area = Area(lenght, width);

            Console.WriteLine("the area is" + area);
            Console.ReadLine();


        }

        static double Area(double lenght , double width)
        {
            return width * lenght;
        }
    }
}
