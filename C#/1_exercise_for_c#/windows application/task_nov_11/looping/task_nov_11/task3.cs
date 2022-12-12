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
    public partial class task3 : Form
    {
        public task3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 103; i <= 109; i += 2)
            {
                OutputBox.Items.Add(i);
            }
        }
    }
}
