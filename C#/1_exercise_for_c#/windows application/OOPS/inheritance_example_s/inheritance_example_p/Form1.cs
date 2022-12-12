using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance_example_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insentive emp1 = new insentive();            
            emp1.name = textBox1.Text;
            emp1.id = int.Parse(textBox2.Text);
            emp1.des = (radioButton1.Checked) ? 3 : (radioButton2.Checked) ? 2 : 1;
            emp1.exp = int.Parse(textBox4.Text);
            emp1.age = Convert.ToInt32(textBox5.Text);
            MessageBox.Show(emp1.name + " (" + emp1.id +"):\n" + "\nSalary : " + emp1.salary() + "\nBonus : " + emp1.bon() + "\nInsentive : " + emp1.ins());
        }
    }
}