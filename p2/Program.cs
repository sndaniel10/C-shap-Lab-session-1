using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            for(int i = 0; i < 10; i++)
            {
                Console.Write("\n enter number :");
                num= int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.Write("its even");
                }
                else
                {
                    Console.Write("its odd");
                }
            }

            Console.ReadLine();
        }
    }
}
