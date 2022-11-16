using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i,sum = 0,avg;
            bool flag = true;
            string option1;
            label2:
            Console.WriteLine("\n-----------------------------------------------------------------------------------------");
            Console.WriteLine("Enter the size of array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            //get input
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                Console.WriteLine("Enter the value of array[" + i + "] = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            //First menu
            label1:
            Console.WriteLine("\n-----------------------------------------------------------------------------------------");
            Console.WriteLine("ENTER tHE NUMBER YOU WANT TO CONTINUE \n(1) Display without '0' \n(2) Sum of all odd number \n(3) Sum of all even number \n(4) Average of given array \n(5) Display \"5\" divisible number \n(6) Arrange Assending order \n(7) Arrange Descending order\n");
            option1 = Console.ReadLine();

            switch (option1)
            {
                case "1":
                    {
                        Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                        Console.WriteLine("Number in given array without '0':");
                        for (i =0; i<array.Length; i++)
                        {
                            if (array[i] != 0)
                                Console.WriteLine("\n" + array[i]);
                        }
                        break;
                    }
                case "2":
                    Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                    Console.WriteLine("Sum of all odd numbers in the given array:");
                    for (i = 0; i < array.Length; i++)
                        if ((array[i] % 2) != 0)
                                sum = sum + array[i];
                        Console.WriteLine(sum);
                        break;
                
                case "3":
                    {
                        Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                        Console.WriteLine("Sum of all even numbers in the given array:");
                        for (i = 0; i < array.Length; i++)
                            if ((array[i] % 2) == 0)
                                sum = sum + array[i];
                        Console.WriteLine(sum);
                        break;
                    }
                
                case "4":
                    {
                        Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                        Console.WriteLine("Average of given array:");
                        for (i = 0; i < array.Length; i++)
                            sum = sum + array[i];                        
                        avg = sum / array.Length;
                        Console.WriteLine(avg);
                        break;
                    }
                
                case "5":
                    {
                        Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                        Console.WriteLine("All 5 divisible number:");
                        for (i = 0; i < array.Length; i++)
                            if (array[i] % 5 == 0)
                            {
                                Console.WriteLine(array[i]);
                                flag = false;
                            }
                        if (flag)
                        {
                            Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                            Console.WriteLine("\nThere is no 5 five divisible number");
                        }
                                
                        break;
                    }
                case "6":
                    {
                        do
                        {
                            flag = true;
                            for (i = 0; i < array.Length - 1; i++)
                            {
                                if (array[i] > array[i + 1])
                                {
                                    //swap
                                    array[i] = array[i] + array[i + 1];
                                    array[i + 1] = array[i] - array[i + 1];
                                    array[i] = array[i] - array[i + 1];
                                    flag = false;
                                }
                            }
                        }
                        while (!flag);

                        Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                        Console.Write("Assending order: \nArray = {");                        
                        for(i=0; i<array.Length-1; i++)
                        {
                            Console.Write(array[i]+", ");
                        }
                        Console.Write(array[i] + "}\n");
                        break;
                    }

                case "7":
                    {
                        do
                        {
                            flag = true;
                            for (i = 0; i < array.Length - 1; i++)
                            {
                                if (array[i] < array[i + 1])
                                {
                                    //swap
                                    array[i] = array[i] + array[i + 1];
                                    array[i + 1] = array[i] - array[i + 1];
                                    array[i] = array[i] - array[i + 1];
                                    flag = false;
                                }
                            }
                        }
                        while (!flag);

                        Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                        Console.Write("descending order: \nArray = {");
                        for (i = 0; i < array.Length - 1; i++)
                        {
                            Console.Write(array[i] + ", ");
                        }
                        Console.Write(array[i] + "}\n");
                        break;
                    }

                default:
                    Console.WriteLine("\n***Invalid input***");
                    goto label1;
            }
            
            //second menu
            Console.WriteLine("\n-----------------------------------------------------------------------------------------");
            Console.WriteLine("ENTER THE NUMBER DO YOU WANT TO CONTINUE: \n(1) goto main menu \n(2) Re-enter the input \n(3) Exit\n");
            option1 = Console.ReadLine();
            switch (option1)
            {
                case "1":
                    goto label1;
                case "2":
                    goto label2;
                case "3":
                    break;
                default:
                    break;
            }
        }
    }
}
