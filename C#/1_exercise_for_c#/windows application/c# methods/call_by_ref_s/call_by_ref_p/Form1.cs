using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace call_by_ref_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b, p;
            b = int.Parse(textBox1.Text);
            p = int.Parse(textBox2.Text);
            Power(ref b, ref p); //function call
            MessageBox.Show(b.ToString());
        }

        //Function definition
        public void Power(ref int b, ref int p)
        {
            int i = 1, ans = b;
            while (i++ < p)
                ans *= b;
            b = ans;
        }
    }
}
