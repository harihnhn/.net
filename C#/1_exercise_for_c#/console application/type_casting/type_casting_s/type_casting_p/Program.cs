using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_casting_p
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            long b = a;
            int c = (int) b;
            //int d = Convert.ToInt32(b);
            int d = int.Parse(b);
            int e = int.Parse(b);
            Console.Write(c);
        }
    }
}
