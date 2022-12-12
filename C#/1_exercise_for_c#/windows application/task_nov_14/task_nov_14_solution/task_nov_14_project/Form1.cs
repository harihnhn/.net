using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_nov_14_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Task3 = new Form4();
            Task3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Task1 = new Form2();
            Task1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Task2 = new Form3();
            Task2.Show();
        }
    }
}
