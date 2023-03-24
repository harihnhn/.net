using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel_project_p
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_registration ar = new admin_registration();
            this.Hide();
            ar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hotel;Integrated Security=True");

            string email, pswd;
            email = textBox1.Text;
            pswd = textBox2.Text;
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from admininfo where aemail = '" + email + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (dr["apswd"].ToString() == pswd)
                {
                    food_list fm = new food_list();
                    this.Hide();
                    fm.Show();
                }
                else
                    MessageBox.Show("Wrong password");
            }
            else
                MessageBox.Show("Wrong mail id");
            con.Close();
        }

        private void admin_login_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            welcome_page wp = new welcome_page();
            this.Hide();
            wp.Show();
        }
    }
}
