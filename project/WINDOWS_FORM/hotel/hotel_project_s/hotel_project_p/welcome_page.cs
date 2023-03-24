using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_project_p
{
    public partial class welcome_page : Form
    {
        public welcome_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_login ul = new user_login();
            this.Hide();        
            ul.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_login al = new admin_login();
            this.Hide();
            al.Show();
        }

        private void welcome_page_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
    }
}
