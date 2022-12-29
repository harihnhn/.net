using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //-------------------doubt ((why this solution))

namespace ado_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int price = 501;
            //string s1 = "hariharan";

            ////make connection to 
            //SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = shop; Integrated Security = True"); //----------------------------doubt((integrated security means))
            //con.Open();
            ////SqlCommand cmd1 = new SqlCommand("alter table sales drop constraint[DF__sales__name1__4BAC3F29]", con);
            ////SqlCommand cmd2 = new SqlCommand("alter table sales alter column name1 varchar(100)", con);
            ////SqlCommand cmd3 = new SqlCommand("insert into sales(name1) values('Myname')", con);
            ////-------------------doubt((how to give multiple sql queries in one object))
            //price += price;
            //SqlCommand cmd1 = new SqlCommand("insert into sales(price, cname) values(" + price + ", '" + s1 + "')", con);

            //cmd1.ExecuteNonQuery();  //------------doubt((why this statement))
            ////cmd2.ExecuteNonQuery();  //------------doubt((why this statement))
            ////cmd3.ExecuteNonQuery();
            //con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region datareader
            //datareader (to get datas from database table)
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = shop; Integrated Security = True");
            con.Open();
            //SqlCommand cmd = new SqlCommand("select * from sales", con);
            SqlCommand cmd = new SqlCommand("select * from sales where cid = 2", con);

            SqlDataReader dr = cmd.ExecuteReader(); //--------------doubt((is SqlDataReader a data type)) , why this statement what does this statement
            MessageBox.Show(dr.Read().ToString()); //---------------doubt ((when i execute this statement why output does not show why?
            //if(dr.Read()) //----------------------------doubt ((dr.Read() meaning)), without this statement output does not show why?
            if (true)
                richTextBox1.AppendText(dr["cid"] + "\n" + dr["cname"]); //--------------doubt((when i debug why output doesn't show for this statement))
            con.Close();
            #endregion

            #region dataset
            SqlConnection con2 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=shop; Integrated Security=True");
            //con2.Open(); //---------------doubt((why it does not need sqlconnection open and close function))
            SqlCommand qery1 = new SqlCommand("select * from sales", con2);
            SqlDataAdapter da = new SqlDataAdapter(qery1);
            DataSet ds = new DataSet();
            da.Fill(ds, "sales");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "sales";

            //con2.Close();
            #endregion
        }
    }
}