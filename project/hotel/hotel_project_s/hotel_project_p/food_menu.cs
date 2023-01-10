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
    public partial class Food_menu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hotel;Integrated Security=True");
        
        public Food_menu()
        {
            InitializeComponent();
        }

        public void wallet_refresh()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select uwallet from userinfo where uid = " + user_login.uid + "", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
                textBox6.Text = dr["uwallet"].ToString();
            con.Close();
        }
        private void Food_menu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized; // to open in full screen

            #region user id and user wallet update   
            textBox5.Text = (user_login.uid).ToString();
            wallet_refresh();
            #endregion
            
            SqlCommand cmd2 = new SqlCommand("select fid as Food_Id, fname as Food_Name, ftype as Type, veg_or_nonveg, fprice as Price from foodmenu where favail = 1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);

            DataSet ds = new DataSet();
            da.Fill(ds, "foodmenu");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "foodmenu";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fid = int.Parse(textBox1.Text);
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from foodmenu where fid = "+fid+"", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string fname = dr["fname"].ToString();
                float fprice = float.Parse(dr["fprice"].ToString());
                int quantity = 1;
                if(textBox2.Text != "")
                    quantity = int.Parse(textBox2.Text);
                float amount = fprice * quantity;
                con.Close();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from cart where fid = "+fid+"", con);
                SqlDataReader dr2 = cmd1.ExecuteReader();
                if(dr2.Read()) //to check this food is already added in the cart
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd11 = new SqlCommand("update cart set quantity = quantity + "+quantity+", amount = amount+"+amount+" where fid = "+fid+"", con);
                    cmd11.ExecuteNonQuery();
                    cart_refresh();
                    textBox4.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    
                }
                else
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("insert into cart values(" + fid + ", '" + fname + "', " + fprice + ", " + quantity + ", " + amount + ")", con);
                    cmd2.ExecuteNonQuery();
                    cart_refresh();
                    textBox1.Clear();
                    textBox2.Clear();                    
                }
                con.Close();
                TotalAmountRefresh();
            }
            else
                MessageBox.Show("invalid food id");            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fid = int.Parse(textBox1.Text);

            con.Open();
            if(textBox2.Text != "")
            {
                int quantity = int.Parse(textBox2.Text);               
                SqlCommand cmd1 = new SqlCommand("update cart set quantity = quantity - " + quantity + ", amount = amount - (" +quantity+ " * fprice) where fid = " + fid + "", con);
                cmd1.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("delete from cart where fid = " + fid + "", con);
                cmd2.ExecuteNonQuery();
            }            
            con.Close();
            cart_refresh();
            TotalAmountRefresh();
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }

        //user defined function
        public void cart_refresh()
        {
            SqlCommand cmd = new SqlCommand("select * from cart", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "cart");

            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "cart";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox4.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox4.Text = row.Cells[1].Value.ToString();
        }

        public void TotalAmountRefresh()
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select sum(amount) as total from cart", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                textBox3.Text = dr3["total"].ToString();
            }
            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            user_sales_record usr = new user_sales_record();
            this.Hide();
            usr.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox4.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox4.Text = row.Cells[1].Value.ToString();
        }

        //buy button
        private void button2_Click(object sender, EventArgs e)
        {            
            //compare wallet balance and total bill amount
            if (float.Parse(textBox6.Text) >= float.Parse(textBox3.Text))
            {
                SqlCommand cmd8 = new SqlCommand("update userinfo set uwallet = (uwallet - " + float.Parse(textBox3.Text) + ") ", con);
                con.Open();
                cmd8.ExecuteNonQuery();
                con.Close();

                #region version1
                //int cnt = 0, id = 1;
                //con.Open();
                //SqlCommand cmd1 = new SqlCommand("alter table cart add cnt int identity", con);
                //cmd1.ExecuteNonQuery();
                //con.Close();

                //con.Open();
                //SqlCommand cmd2 = new SqlCommand("select count(cnt) as cnt from cart", con);
                //SqlDataReader dr = cmd2.ExecuteReader();
                //if (dr.Read())
                //{
                //    cnt = Convert.ToInt32(dr["cnt"]);
                //}
                //con.Close();

                //con.Open();
                //SqlCommand cmd5 = new SqlCommand("select max(billid) as id from sales_record", con);
                //SqlDataReader dr2 = cmd5.ExecuteReader();
                //if (dr2.Read())
                //{
                //    try
                //    {
                //        id = Convert.ToInt32(dr2["id"]) + 1;
                //    }
                //    catch { }

                //}
                //con.Close();

                //for (int i = 1; i <= cnt; i++)
                //{
                //    con.Open();
                //    SqlCommand cmd3 = new SqlCommand("insert into sales_record (fid, fname, fprice, quantity, amount) select fid, fname, fprice, quantity, amount from cart where cnt = " + i + "", con);
                //    cmd3.ExecuteNonQuery();
                //    con.Close();

                //    con.Open();
                //    SqlCommand cmd4 = new SqlCommand("update sales_record set uid = " + user_login.uid + ", billid = " + id + " where billid is null", con);
                //    cmd4.ExecuteNonQuery();
                //    con.Close();
                //}

                //#region delete all records and cnt column in cart table
                //con.Open();
                //SqlCommand cmd6 = new SqlCommand("truncate table cart", con);
                //cmd6.ExecuteNonQuery();
                //con.Close();

                //con.Open();
                //SqlCommand cmd7 = new SqlCommand("alter table cart drop column cnt", con);
                //cmd7.ExecuteNonQuery();
                //con.Close();
                //#endregion
                #endregion

                #region current version
                int id = 1;                
                con.Open();
                SqlCommand cmd5 = new SqlCommand("select max(billid) as id from sales_record", con);
                SqlDataReader dr2 = cmd5.ExecuteReader();
                if (dr2.Read())
                {
                    try
                    {
                        id = Convert.ToInt32(dr2["id"]) + 1;
                    }
                    catch { }

                }
                con.Close();
                
                con.Open();
                SqlCommand cmd3 = new SqlCommand("insert into sales_record (fid, fname, fprice, quantity, amount) select * from cart", con);
                cmd3.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd4 = new SqlCommand("update sales_record set uid = " + user_login.uid + ", billid = " + id + " where billid is null", con);
                cmd4.ExecuteNonQuery();
                con.Close();             
                
                con.Open();
                SqlCommand cmd6 = new SqlCommand("truncate table cart", con);
                cmd6.ExecuteNonQuery();
                con.Close();                
                #endregion

                cart_refresh();
                TotalAmountRefresh();
                wallet_refresh();
                MessageBox.Show("Your Order Placed Successfully!!! \n Bill ID: " + id);
            }
            else
                MessageBox.Show("Insufficient Wallet balance \n To Recharge your wallet balance contact admin");           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            user_login ul = new user_login();
            this.Hide();
            ul.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            sales_record sr = new sales_record();
            this.Hide();
            sr.Show();
        }
    }
}
