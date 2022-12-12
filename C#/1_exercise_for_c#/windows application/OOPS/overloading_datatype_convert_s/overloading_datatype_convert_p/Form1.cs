using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overloading_datatype_convert_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stringconvert str = new stringconvert();
            int a = int.Parse(textBox1.Text);
            string b = str.convert(a);
            MessageBox.Show(b.Length.ToString());
        }
    }
}
