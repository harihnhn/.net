﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_nov_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 task1 = new Form2();
            task1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 task2 = new Form3();
            task2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 task4 = new Form4();
            task4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 task5 = new Form5();
            task5.Show();
        }
    }
}
