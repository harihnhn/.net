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
    public partial class user_table : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hotel;Integrated Security=True");
        public user_table()
        {
            InitializeComponent();
        }

        private void user_table_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            con.Open();
            gridview_refresh();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from userinfo where uid = "+textBox1.Text+" ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                con.Open();
                //dr["uwallet"] += int.Parse(textBox2.Text);
                SqlCommand cmd2 = new SqlCommand("update userinfo set uwallet = (uwallet + "+textBox2.Text+ ") where uid = "+textBox1.Text+" ", con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Wallet money added");
                gridview_refresh();
            }
            else
                MessageBox.Show("Invalid user id");
            con.Close();
        }

        //user defined function
        public void gridview_refresh()
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("select uid as User_id, uname as User_name, uemail as User_email, umobileno as Mobile_no, uwallet as Wallet_Amount from userinfo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "userinfo");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "userinfo";
            //con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            food_list fl = new food_list();
            this.Hide();
            fl.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sales_record sr = new sales_record();
            this.Hide();
            sr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            food_list fl = new food_list();
            this.Hide();
            fl.Show();
        }
    }
}
