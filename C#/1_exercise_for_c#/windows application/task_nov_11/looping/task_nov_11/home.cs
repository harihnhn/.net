using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_nov_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task1 Task1 = new task1();
            Task1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            task2 Task2 = new task2();
            Task2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            task3 Task3 = new task3();
            Task3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
        private void button2_Click(object sender, EventArgs e)
        {
            task2 Task2 = new task2();
            Task2.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            task3 Task3 = new task3();
            Task3.Show();
        }
        */
    }
}
