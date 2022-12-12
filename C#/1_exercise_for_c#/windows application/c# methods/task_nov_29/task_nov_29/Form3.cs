using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_nov_29
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //palindrome string check using method
            string str, str1;
            str = textBox1.Text;
            str1 = String_reverse(str);
            richTextBox1.Clear();
            if (str == str1)
                richTextBox1.AppendText(str1 + " is \"a palindrome\" string");
            else
                richTextBox1.AppendText(str + " is \"Not a palindrome\" string");
        }

        private string String_reverse(string s)
        {
            int i = 1;
            string s1 = "";
            //char[] str = new char[s.Length]; 
            //while(i <= (s.Length / 2))
            //{
            //    str[i-1] = s[s.Length - i];
            //    str[s.Length - i] = s[i - 1];                
            //    i++;
            //}

            //i = 0;
            //while(i < s.Length)
            //    richTextBox1.AppendText(str[i++].ToString());

            //s = str.ToString();
            
            for(i = s.Length-1; i >= 0; i--)
                s1 += s[i];

            return s1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
