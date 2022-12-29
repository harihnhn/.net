using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using arithmetic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 10, b = 20;
            arithmetic1 obj = new arithmetic1();
            MessageBox.Show(obj.add(a, b).ToString());
            MessageBox.Show(obj.sub(a, b).ToString());
            MessageBox.Show(obj.mul(a, b).ToString());
            MessageBox.Show(obj.div(a, b).ToString());
        }
    }
}
