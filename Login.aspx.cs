using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Website1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-39GOOGC\SQLEXPRESS; Initial Catalog=Ushnish; Integrated Security= True;");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Register where Email='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {

                Label1.Text = "Login Successful";
                Response.Redirect("Site1.aspx");
            }
            else
            {
                Label1.Text = "Login Unsuccessful";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}