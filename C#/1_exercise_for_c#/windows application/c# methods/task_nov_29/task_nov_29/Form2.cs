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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //prime number with c# methods
            int n;
            n = int.Parse(textBox1.Text);
            richTextBox1.Clear();
            richTextBox1.AppendText(Convert.ToString(Fact(n)));                      
        }

        //user defined function
        public int Fact(int n)
        {
            int i = 1, fact = 1;            
            while (i <= n)
                fact *= i++;
            return fact;
        }
    }
}
