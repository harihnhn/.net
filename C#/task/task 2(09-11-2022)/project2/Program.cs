using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mark
{
    internal class mark_calculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your all subject marks (out of 100)");
            Console.WriteLine("Enter Your Mark 1: ");
            int mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Mark 2: ");
            int mark2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Mark 3: ");
            int mark3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Mark 4: ");
            int mark4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Mark 5: ");
            int mark5 = int.Parse(Console.ReadLine());
            
            //total mark
            int tot = mark1+ mark2+mark3+mark4+mark5;
            
            //average
            int avg = tot/5;

            //percentage
            int per = tot / (500 / 100);

            //print result
            Console.WriteLine("\nTotal mark: " + tot);
            Console.WriteLine("\nAverage mark: " + avg);
            Console.WriteLine("\nPercentage: " + per);
            Console.ReadLine();
        }
    }
}
