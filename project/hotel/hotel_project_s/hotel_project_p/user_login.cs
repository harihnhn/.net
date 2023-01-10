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
    public partial class user_login : Form
    {
        public static int uid = 10;
        public user_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_registratrion ur = new user_registratrion();
            this.Hide();
            ur.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hotel;Integrated Security=True");

            string email, pswd;
            email = textBox1.Text;
            pswd = textBox2.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from userinfo where uemail = '"+email+"'", con);           
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (dr["upswd"].ToString() == pswd)
                {
                    uid = Convert.ToInt32(dr["uid"]);
                    //user_id obj = new user_id(int.Parse(dr["uid"].ToString()));
                    Food_menu fm = new Food_menu();
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

        private void user_login_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            welcome_page wp = new welcome_page();
            wp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            welcome_page w = new welcome_page();
            this.Hide();
            w.Show();
        }
    }
}
