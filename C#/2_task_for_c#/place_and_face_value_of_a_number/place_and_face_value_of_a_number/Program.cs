using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace place_and_face_value_of_a_number
{
    //show place and face value of all digits of a given number
    class Program
    {
        static void Main(string[] args)
        {
            long n, n1, rev = 0, fov, pov;
            int cnt = -1;
            n = long.Parse(Console.ReadLine());
            n1 = n;
            //reverse number
            while (n1 > 0)
            {
                rev = (rev * 10) + (n1 % 10);
                n1 /= 10;
                cnt++;
            }

            while (rev > 0)
            {
                fov = rev % 10;
                pov = PlaceValue(fov, cnt--);
                Console.WriteLine("\nFace of Value : " + fov + "\nPlace of Value : " + pov);
                rev /= 10;
            }        
        }

        //function to find place of a value
        public static long PlaceValue(long num, int pos)
        {
            //(num > 0) ? return num * (power(10, pos)) : return num + (power(10, pos));  
            if (num > 0)
                return num * (power(10, pos));
            else
                return num + (power(10, pos));

        }

        //power function
        public static long power(int b, int p)
        {
            long n = 1;
            while (p-- > 0)
                n *= b;
            return n;
        }
    }
}
