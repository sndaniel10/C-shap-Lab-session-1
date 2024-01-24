using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num , sum = 0;
            Console.WriteLine("enter pos number");
            num = int.Parse(Console.ReadLine());
            
            if (num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    sum = sum + i;
                }
            }
            else 
            {
                Console.WriteLine("error");
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
