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
    public partial class food_list : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hotel;Integrated Security=True");
        public food_list()
        {
            InitializeComponent();
        }

        private void food_menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.foodmenu' table. You can move, or remove it, as needed.
            this.foodmenuTableAdapter1.Fill(this.hotelDataSet1.foodmenu);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'hotelDataSet.foodmenu' table. You can move, or remove it, as needed.
            //this.foodmenuTableAdapter.Fill(this.hotelDataSet.foodmenu);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox4.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int avail = radioButton1.Checked == true ? 1 : 0;
            char vn = radioButton3.Checked == true ? 'V' : 'N';
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into foodmenu values('" + textBox4.Text + "', '" + textBox1.Text + "', '"+vn+"' ,'" + textBox2.Text + "', " + textBox3.Text + ", " + avail + ")", con);
                cmd.ExecuteNonQuery();                
                this.foodmenuTableAdapter1.Fill(this.hotelDataSet1.foodmenu);
                con.Close();
                MessageBox.Show("food added successfully");
                clear_inputs();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("ERROR : \n" + ex.Message);
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {            
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from foodmenu where fid = " + textBox4.Text + "", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    con.Open();
                    if (textBox1.Text != "")
                    {
                        SqlCommand cmd2 = new SqlCommand("update foodmenu set fname = '" + textBox1.Text + "' where fid = " + textBox4.Text + "", con);
                        cmd2.ExecuteNonQuery();                                                                    
                    }
                    if (textBox2.Text != "")
                    {
                        SqlCommand cmd2 = new SqlCommand("update foodmenu set ftype = '" + textBox2.Text + "' where fid = " + textBox4.Text + "", con);
                        cmd2.ExecuteNonQuery();                                                                   
                    }
                    if (textBox3.Text != "")
                    {
                        SqlCommand cmd2 = new SqlCommand("update foodmenu set fprice = " + textBox3.Text + " where fid = " + textBox4.Text + "", con);
                        cmd2.ExecuteNonQuery();                                            
                    }
                    if (radioButton3.Checked == true || radioButton4.Checked == true)
                    {
                        char vn = radioButton3.Checked == true ? 'V' : 'N';
                        SqlCommand cmd2 = new SqlCommand("update foodmenu set veg_or_nonveg = '" + vn + "' where fid = " + textBox4.Text + "", con);
                        cmd2.ExecuteNonQuery();
                    }
                    if (radioButton1.Checked == true || radioButton2.Checked == true)
                    {
                        int avail = radioButton1.Checked == true ? 1 : 0;
                        SqlCommand cmd2 = new SqlCommand("update foodmenu set favail = " + avail + " where fid = " + textBox4.Text + "", con);
                        cmd2.ExecuteNonQuery();                                              
                    }                
                    this.foodmenuTableAdapter1.Fill(this.hotelDataSet1.foodmenu);
                    MessageBox.Show("Updated Successfully");
                    clear_inputs();
                }
                else
                {
                    MessageBox.Show("Invalid food id");
                }

            con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("ERROR : \n" + ex.Message); 
            }
        }

        //delete
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from foodmenu where fid = " + textBox4.Text + "", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("delete from foodmenu where fid = " + textBox4.Text + "", con);
                    cmd2.ExecuteNonQuery();                    
                    this.foodmenuTableAdapter1.Fill(this.hotelDataSet1.foodmenu);
                    MessageBox.Show("deleted successfully");
                    clear_inputs();
                }
                else
                {
                    MessageBox.Show("Invalid food id");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("ERROR : \n" + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            user_table ut = new user_table();
            this.Hide();
            ut.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox4.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                if (Convert.ToChar(row.Cells[3].Value) == 'V') radioButton3.Checked = true;
                else radioButton4.Checked = true;
                textBox3.Text = row.Cells[4].Value.ToString();
                if (Convert.ToInt32(row.Cells[5].Value) == 1) radioButton1.Checked = true;
                else radioButton2.Checked = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            admin_login al = new admin_login();
            this.Hide();
            al.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sales_record sr = new sales_record();
            this.Hide();
            sr.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        //to clear all input fields
        public void clear_inputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();            
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}