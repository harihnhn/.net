using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2147483647;
            long N = 1234567891234567890L;
            float f = 123456.47f;
            double d = 123456789;
            char c = 'a';
            string str = "true";
            bool flag = bool.Parse(str);

            Console.WriteLine(flag);
        }
    }
}