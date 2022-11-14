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
    public partial class task2 : Form
    {
        public task2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 105; i >= 85; i -= 5)
            {
                OutputBox.Items.Add(i);
            }
            
        }
    }
}
