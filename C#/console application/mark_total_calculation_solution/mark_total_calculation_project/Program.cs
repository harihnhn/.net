using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mark_total_calculation_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i,tot=0,avg;
            string result = "PASS", name;
            long reg_no;
            int[] arr = new int[100];

            Console.WriteLine("Enter Your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Reg.No: ");
            reg_no = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter the No. of Subject:");
            n = Convert.ToInt32(Console.ReadLine());
            label1:
            Console.WriteLine("\nEnter Your marks out of 100");
            for (i=1;i<=n;i++)
            {
                Console.WriteLine("Subject" + i + " mark : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                //mark input validation
                if(arr[i]>100)
                {
                    Console.WriteLine("****Invalid Input!!!****\n");
                    goto label1;
                }

                //total and result calculation on input loop
                tot = tot + arr[i];
                if(arr[i]<35)
                    result = "FAIL";
            }
            Console.WriteLine("\n\nNAME : " + name + "\nREGISTER NUMBER: " + reg_no + "\nTOTAL : " + tot + "\nRESULT : " + result);
            //average and grade calculation
            avg = tot/n;

            if(avg>=90)
                Console.WriteLine("GRADE = \"O\" ");
            else if(avg>=80)
                Console.WriteLine("GRADE = \"A+\" ");
            else if(avg>=70)
                Console.WriteLine("GRADE = \"A\" ");
            else if(avg>=60)
                Console.WriteLine("GRADE = \"B+\" ");
            else if(avg>=50)
                Console.WriteLine("GRADE = \"B\" ");    
            else
                Console.WriteLine("GRADE = \"U\" ");
            
            Console.ReadLine();
        }
    }
}
