using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_defined_exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                //checking user defined exception
                if (a > 100 || b > 100)
                {
                    throw new MyException("user defined exception");
                }

                MessageBox.Show((a + b).ToString());
            }

            //if user defined exception executed
            catch(MyException ex)
            {
                MessageBox.Show(ex.msg);
            }
            
            catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
