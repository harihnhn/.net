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
    public partial class admin_registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hotel;Integrated Security=True");
        public admin_registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region get input
            string aname, aemail, apass, aconf_pass;
            long amob_no;
            aname = textBox1.Text;
            aemail = textBox2.Text;
            apass = textBox3.Text;
            aconf_pass = textBox4.Text;
            amob_no = long.Parse(textBox5.Text);

            #endregion

            //input validation
            if (aname == null || aemail == null || apass == null || apass != aconf_pass)
                MessageBox.Show("Invalid input");

            else
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into admininfo values('" + aname + "', '" + aemail + "', '" + apass + "', " + amob_no + ")", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully");
                    user_login ul = new user_login();
                    ul.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }
    }
}
