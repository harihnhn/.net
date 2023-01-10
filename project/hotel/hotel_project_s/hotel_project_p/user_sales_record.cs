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
    public partial class user_sales_record : Form
    {        
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hotel;Integrated Security=True");
        public user_sales_record()
        {
            InitializeComponent();
        }

        private void user_sales_record_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            #region user id and user wallet update               
            textBox5.Text = (user_login.uid).ToString();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select uwallet from userinfo where uid = "+user_login.uid+"", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if(dr.Read())            
                textBox6.Text = dr["uwallet"].ToString();            
            con.Close();
            #endregion

            int uid = user_login.uid;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from sales_record where uid = "+uid+" order by billid desc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            
            DataSet ds = new DataSet();
            da.Fill(ds, "sales_record");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "sales_record";
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Food_menu fm = new Food_menu();
            this.Hide();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Food_menu fm = new Food_menu();
            this.Hide();
            fm.Show();
        }
    }
}
