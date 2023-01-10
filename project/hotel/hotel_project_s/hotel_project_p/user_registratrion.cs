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
    public partial class user_registratrion : Form
    {
        public user_registratrion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hotel;Integrated Security=True");

            #region get input
            string uname, uemail, upass, uconf_pass;
            long umob_no;
            uname = textBox1.Text;
            uemail = textBox2.Text;
            upass = textBox3.Text;
            uconf_pass = textBox4.Text;
            umob_no = long.Parse(textBox5.Text);

            #endregion

            //input validation
            if (uname == null || uemail == null || upass == null || upass != uconf_pass)
                MessageBox.Show("Invalid input");
            
            else
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into userinfo(uname, uemail, upswd, umobileno) values('" + uname + "', '" + uemail + "', '" + upass + "', " + umob_no + ")", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully");
                    user_login ul = new user_login();
                    this.Hide();
                    ul.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();                
            }
        }

        private void user_registratrion_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user_login ul = new user_login();
            this.Hide();
            ul.Show();
        }
    }
}