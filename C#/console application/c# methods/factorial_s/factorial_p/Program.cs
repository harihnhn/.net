using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //factorial using method
            int n;
            Console.Write("\nEnter the number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("factotial of "+n+"! = "+Fact(n));
            Console.Read();
        }
    
        public static int Fact(int n)
        {
            int f = 1;
            for(int i = 1; i <= n; i++)             
                f *= i;
            return f;
        }
    }
}
