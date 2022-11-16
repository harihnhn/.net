using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_statement_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; int j = 0;
            if (i == 0)
            {
                Console.WriteLine("\nfirst if condition section");
                if (i == 0)
                {
                    Console.WriteLine("Second if condition section");
                    j = Convert.ToInt32(Console.ReadLine());
                    if (j != 0)
                    {
                        Console.WriteLine("1. j not equal to zero");
                        break;
                        Console.WriteLine("1.1 j not equal to zero");
                    }
                    Console.WriteLine("outside of break");
                    j = Convert.ToInt32(Console.ReadLine());
                    if (j != 0)
                    {
                        Console.WriteLine("2. j not equal to zero");
                        break;
                    }
                }
                Console.WriteLine("2. outside of break");
                j = Convert.ToInt32(Console.ReadLine());
                if (j != 0)
                {
                    Console.WriteLine("2. j not equal to zero");
                    break;
                }
            }
            Console.WriteLine("\nEnd of the Case2");
            break;
        }
    }
}
