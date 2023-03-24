using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_class_p
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Console.WriteLine(Math.Max(x, y)+"\n");
            Console.WriteLine(Math.Min(x, y)+"\n");
            Console.WriteLine(Math.Sqrt(x)+"\n");
            float num = 11.9f;
            Console.WriteLine(Math.Abs(num)+"\n"); //to change the value into positive value
            Console.WriteLine(Math.Round(num)+"\n");
        }
    }
}
