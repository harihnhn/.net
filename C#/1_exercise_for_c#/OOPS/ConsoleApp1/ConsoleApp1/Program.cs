using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //fibonacci series
            int n = int.Parse(Console.ReadLine());
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1 + " " + n2);
            n = n - 2;
            while (n-- > 0)
            {
                Console.Write(" " + (n1 + n2));
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
