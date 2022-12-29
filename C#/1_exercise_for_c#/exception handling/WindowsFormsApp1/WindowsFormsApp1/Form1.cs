using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region try, catch
            //try
            //{
            //    int a = int.Parse(textBox1.Text), b = int.Parse(textBox2.Text);
            //    MessageBox.Show((a + b).ToString());
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("catch" + "\n" + ex.Message);
            //}
            #endregion

            #region try, catch, catch, catch, ...
            //try
            //{
            //    int a = int.Parse(textBox1.Text), b = int.Parse(textBox2.Text);
            //    MessageBox.Show((a + b).ToString());
            //}

            //catch(DivideByZeroException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //catch(FormatException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //catch (WarningException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}            
            #endregion        

            #region try, catch, finally
            //try
            //{
            //    int a = int.Parse(textBox1.Text), b = int.Parse(textBox2.Text);
            //    MessageBox.Show((a + b).ToString());
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("catch" + "\n" + ex.Message);
            //}

            ////finally section execute after the try and catch executed            
            //finally
            //{
            //    MessageBox.Show("finally");
            //}
            #endregion

            #region try, finally
            //try
            //{
            //    int a = int.Parse(textBox1.Text), b = int.Parse(textBox2.Text);
            //    MessageBox.Show((a + b).ToString());
            //}

            ////finally section execute after the try and catch executed
            ////if we don't need to use catch we use finally section
            //finally
            //{
            //    MessageBox.Show("finally");
            //}
            #endregion
        }
    }
}
