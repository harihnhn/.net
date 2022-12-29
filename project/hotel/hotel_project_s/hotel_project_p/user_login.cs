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
        public user_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_registratrion ur = new user_registratrion();
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
                    food_menu fm = new food_menu();
                    fm.Show();
                }
                else
                    MessageBox.Show("Wrong password");
            }
            else
                MessageBox.Show("Wrong mail id");
            
            
            con.Close();
        }
    }
}
