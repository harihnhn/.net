using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_nov_11_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m1, m2, m3, avg;
            string sname = textBox1.Text;
            m1 = int.Parse(textBox2.Text);
            m2 = int.Parse(textBox3.Text);
            m3 = int.Parse(textBox4.Text);
            //m2 = Convert.ToInt32(textBox2.Text);
            //m3 = Convert.ToInt32(textBox3.Text);
            int tot = m1 + m2 + m3;
            MessageBox.Show(tot.ToString());
            avg = tot / 3;

            if (avg >= 90)
            {
                MessageBox.Show("Name : " + sname + "\ntotal marks : " + tot + "\naverage : " + avg + "\ngrade = \"O\"");
            }
            else if (avg >= 80)
            {
                MessageBox.Show("Name : " + sname + "\ntotal marks : " + tot + "\naverage : " + avg + "\ngrade = \"A+\"");
            }
            else if (avg >= 70)
            {
                MessageBox.Show("Name : " + sname + "\ntotal marks : " + tot + "\naverage : " + avg + "\ngrade = \"A\"");
            }
            else if (avg >= 60)
            {
                MessageBox.Show("Name : " + sname + "\ntotal marks : " + tot + "\naverage : " + avg + "\ngrade = \"B+\"");
            }
            else if (avg >= 50)
            {
                MessageBox.Show("Name : " + sname + "\ntotal marks : " + tot + "\naverage : " + avg + "\ngrade = \"B\"");
            }
            else
            {
                MessageBox.Show("Name : " + sname + "\ntotal marks : " + tot + "\naverage : " + avg + "\ngrade = \"U\"");
            }
        }
    }
}
