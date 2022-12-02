using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace call_by_value_p
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
            int a, b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);            
            Add(a, b);  
        }

        //function definition
        public void Add(int a, int b)
        {
            int c = a + b;
            MessageBox.Show(c.ToString());
        }

    }
}
