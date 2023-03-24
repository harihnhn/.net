using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine(), str2 = "";

            for (int i = str1.Length-1; i >= 0; i--)
            {
                str2 += str1[i];
            }
            Console.WriteLine(str2);
        }
    }
}