using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_deposit_withdrawl_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void load()
        {
            textBox4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deposit obj1 = new deposit();
            obj1.name = textBox1.Text;
            obj1.id = int.Parse(textBox2.Text);
            obj1.balance = int.Parse(textBox4.Text);
            int amt = int.Parse(textBox3.Text);            
            textBox4.Text = obj1.dep(amt).ToString();
            textBox4.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdrawl obj1 = new withdrawl();
           
            obj1.name = textBox1.Text;
            obj1.id = int.Parse(textBox2.Text);
            obj1.balance = int.Parse(textBox4.Text);
            int amt = int.Parse(textBox3.Text);
            
            textBox4.Text = obj1.with(amt).ToString();
            textBox4.Visible = true;
           
        }
    }
}
