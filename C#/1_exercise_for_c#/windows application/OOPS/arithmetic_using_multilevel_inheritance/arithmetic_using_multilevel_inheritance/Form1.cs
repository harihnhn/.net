using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arithmetic_using_multilevel_inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d obj = new d();
            MessageBox.Show(obj.add().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d obj = new d();
            MessageBox.Show(obj.sub().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d obj = new d();
            MessageBox.Show(obj.mul().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d obj = new d();
            MessageBox.Show(obj.div().ToString());
        }
    }
}
