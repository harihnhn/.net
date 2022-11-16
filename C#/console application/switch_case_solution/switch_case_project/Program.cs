using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            string c1,c2;
            label2:
            Console.WriteLine("\nEnter the number 1:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2:");
            n2 = Convert.ToInt32(Console.ReadLine());
            label1:
            Console.WriteLine("\nChoose the Arithmetic operation: \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division \n5. Modulus");
            c1 = Console.ReadLine();

            switch(c1)
            {
                case "1":
                    Console.WriteLine("\n"+ n1 + " + " + n2 + "= \"" + (n1+n2) +"\"");
                    break;

                case "2":
                    Console.WriteLine("\n"+ n1 + " - " + n2 + "= \"" + (n1-n2) + "\"");
                    break;

                case "3":
                    Console.WriteLine("\n"+ n1 + " * " + n2 + "= \"" + (n1*n2) + "\"");
                    break;

                case "4":
                    Console.WriteLine("\n"+ n1 + " / " + n2 + "= \"" + (n1/n2) + "\"");
                    break;

                case "5":
                    Console.WriteLine("\n"+ n1 + " % " + n2 + "= \"" + (n1%n2) + "\"");
                    break;

                default:
                    Console.WriteLine("\nInvalid option\nEnter the option no. 1 to 5 only\n");
                    goto label1;
            }
            Console.WriteLine("\nchoice:\n1. Go to main menu \n2. change input numbers \n3. Exit");
            c2 = Console.ReadLine();
            switch(c2)
            {
                case "1":
                    goto label1;

                case "2":
                    Console.WriteLine("in a case we can run multiple statements");
                    Console.WriteLine("it does not need a curly braces");
                    Console.WriteLine("it really works");
                    goto label2;
                    
                case "3":
                    break;

                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
