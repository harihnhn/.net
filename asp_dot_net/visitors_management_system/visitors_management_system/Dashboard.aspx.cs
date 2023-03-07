using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace visitors_management_system
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 10;
            Console.Write(a);
            Console.Write("page_load");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}