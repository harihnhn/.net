using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerical_logic_programs_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PRIME NUMBER
            //a number that can be divided exactly only by itself and 1, for example 7, 17 and 41.
            richTextBox1.Clear();
            int n, i;
            bool flag = true;
                        
            n = int.Parse(textBox1.Text);


            if (n == 0)
                richTextBox1.AppendText("Zero is neither a prime nor a composite number");
               //Console.WriteLine("\nZero is neither a prime nor a composite number");


            else if (n < 0)
                richTextBox1.AppendText("\"" + n + "\" is not a prime number");

            else if (n == 1)
                richTextBox1.AppendText("\"" + n + "\" is a prime number");

            else
            {
                for (i = 2; i <= (n / 2); i++)
                {
                    if (n % i == 0)
                    {
                        richTextBox1.AppendText("\"" + n + "\" is not a prime number");
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    richTextBox1.AppendText("\"" + n + "\" is a prime number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PERFECT NUMBER
            //A perfect number is a positive integer that is equal to the sum of its positive divisors, excluding the number itself.
            richTextBox1.Clear();

            int n, i, sum = 0;
            
            n = int.Parse(textBox1.Text);

            if (n <= 0)
                richTextBox1.AppendText("\"" + n + "\" is not a perfect number");
            else
            {
                for (i = 1; i <= (n / 2); i++)
                {
                    if (n % i == 0)
                        sum += i;
                }

                if (sum == n)
                    richTextBox1.AppendText("\"" + n + "\" is a perfect number");
                else
                    richTextBox1.AppendText("\"" + n + "\" is not a perfect number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ARMSTRONG NUMBER
            /*Armstrong number definition is the number in any given number base, which forms the total of the same number, when each of its digits is raised to the power of the number of digits in the number.*/
            richTextBox1.Clear();

            string n;
            n = textBox1.Text;
            int pow = n.Length, n1 = Convert.ToInt32(n), n2;
            double sum = 0; //Math.Pow() function returns decimal value

            while (n1 > 0)
            {
                n2 = n1 % 10;
                sum += Math.Pow(n2, pow);
                n1 /= 10;
            }

            if (sum == float.Parse(n))
                richTextBox1.AppendText("\"" + n + "\" is a Armstrong number");
            else
                richTextBox1.AppendText("\"" + n + "\" is not a Armstrong number");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            //Sum of all digits of a given number

            int n, n1 = 0, sum = 0;
            n = int.Parse(textBox1.Text);

            while (n > 0)
            {
                n1 = n % 10;
                sum += n1;
                n = n / 10;
                if (n > 0)
                    richTextBox1.AppendText(n1 + " + ");
            }
            richTextBox1.AppendText(n1 + " = " + sum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            //Reverse number
            int n, n1, rev_num = 0;
            n = int.Parse(textBox1.Text);

            while (n > 0)
            {
                n1 = n % 10;
                rev_num = (10 * rev_num) + n1;
                n /= 10;
            }
            richTextBox1.AppendText("\n Reversed format: " + rev_num);            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            //A palindromic number is a number (such as 16461) that remains the same when its digits are reversed.
            int n, n1, n2, rev_num = 0;
            n = int.Parse(textBox1.Text);
            n1 = n;

            while (n1 > 0)
            {
                n2 = n1 % 10;
                rev_num = (10 * rev_num) + n2;
                n1 /= 10;
            }
            if (rev_num == n)
                richTextBox1.AppendText("\n\"" + n + "\" is a polindrome number");
            else
                richTextBox1.AppendText("\n\"" + n + "\" is not a polindrome number");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            //Count the number of digits in a given number
            long n, cnt = 0;
            n = long.Parse(textBox1.Text);
            while (n > 0)
            {
                n /= 10;
                cnt++;
            }
            richTextBox1.AppendText("\nNo of digits = " + cnt);
        }
    }
}