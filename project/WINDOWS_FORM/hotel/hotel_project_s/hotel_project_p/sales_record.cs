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
using System.Security.Cryptography;

namespace hotel_project_p
{
    public partial class sales_record : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hotel;Integrated Security=True");
        string search_data { get; set; }
        string col_name { get; set; }
        public sales_record()
        {
            InitializeComponent();
        }

        private void sales_record_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            SqlCommand cmd1 = new SqlCommand("select * from sales_record order by billid desc", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds, "sales_record");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "sales_record";

            comboBox1.SelectedText = "--select--";

            comboBox2.Hide();
            textBox1.Hide();
            label4.Hide();
            textBox2.Hide();
            label5.Hide();
            textBox3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user_table ut = new user_table();
            this.Hide();
            ut.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            user_table ut = new user_table();
            this.Hide();
            ut.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            food_list fl = new food_list();
            this.Hide();
            fl.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            col_name = comboBox1.Text;
            search_data = null;
            //Bill id, uid, fid
            if (col_name == "billid" || col_name == "uid" || col_name == "fid")
            {
                comboBox2.Hide();
                textBox1.Show(); //Show
                label4.Hide();
                textBox2.Hide();
                label5.Hide();
                textBox3.Hide();
            }

            else if (col_name == "fname")
            {                
                comboBox2.Show(); //Show
                textBox1.Hide();
                label4.Hide();
                textBox2.Hide();
                label5.Hide();
                textBox3.Hide();
                
                comboBox2.Items.Clear();
                comboBox2.SelectedText = "--select--";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select distinct fname from sales_record", conn);
                SqlDataReader dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    comboBox2.Items.Add(dr[0].ToString());
                }
                conn.Close();
            }
            else if (col_name == "fprice" || col_name == "quantity" || col_name == "amount")
            {
                comboBox2.Hide(); //Hide
                textBox1.Hide(); //Hide
                label4.Show();
                textBox2.Show();
                label5.Show();
                textBox3.Show();
            }
            else
            {
                //all hide
                comboBox2.Hide();
                textBox1.Hide();
                label4.Hide();
                textBox2.Hide();
                label5.Hide();
                textBox3.Hide();
            }
        }

        //search button click event
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand();
            bool flag = radioButton2.Checked; 
                
            //search with only date
            //if(search_data == null || search_data == "(none)" || search_data == "")
            if(col_name == "(none)" || col_name == null)
            {
                //SqlCommand cmd1 = new SqlCommand("select * from sales_record where billdate >= '" + dateTimePicker1.Value.ToString("MM-dd-yyyy") + "' and billdate <= '" + dateTimePicker2.Value.ToString("MM-dd-yyyy") + "'", conn);

                cmd1 = new SqlCommand("select * from sales_record where billdate >= '" + dateTimePicker1.Value.ToString("MM-dd-yyyy") + "' and billdate <= dateadd(day, 1, '" + dateTimePicker2.Value.ToString("MM-dd-yyyy") + "') ", conn);
            }
            
            else
            {
                if(col_name == "billid" || col_name == "uid" || col_name == "fid" || col_name == "fname")
                {
                    if(col_name != "fname") 
                    {
                        search_data = textBox1.Text;
                    }                    
                    if(flag) //search without date
                    {
                        cmd1 = new SqlCommand("select * from sales_record where (" + col_name + " = '" + search_data + "') ", conn);
                    }
                    else //search with date
                    {
                        cmd1 = new SqlCommand("select * from sales_record where (billdate >= '" + dateTimePicker1.Value.ToString("MM-dd-yyyy") + "' and billdate <= dateadd(day, 1, '" + dateTimePicker2.Value.ToString("MM-dd-yyyy") + "')) and (" + col_name + " = '" + search_data + "') ", conn);
                    }
                }

                else
                {
                    int from = int.Parse(textBox2.Text), to = int.Parse(textBox3.Text);
                    if (flag)
                    {
                        cmd1 = new SqlCommand("select * from sales_record where ((" + col_name + " >= " + from + ") and (" + col_name + " <= " + to + ")) ", conn);
                    }
                        
                    else
                    {
                        cmd1 = new SqlCommand("select * from sales_record where (billdate >= '" + dateTimePicker1.Value.ToString("MM-dd-yyyy") + "' and billdate <= dateadd(day, 1, '" + dateTimePicker2.Value.ToString("MM-dd-yyyy") + "')) and ((" + col_name + " >= " + from + ") and (" + col_name + " <= " + to + ")) ", conn);
                    }
                        
                }
            }

            conn.Open();            
            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            DataSet ds = new DataSet();
            da.Fill(ds, "sales_record");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "sales_record";
            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_data = comboBox2.Text;
        }
    }
}