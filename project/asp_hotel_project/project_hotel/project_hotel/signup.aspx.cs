using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace project_hotel
{
    public partial class signup : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hotel;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void sign_up()
        {
            int a = 10;
        }
    }
}