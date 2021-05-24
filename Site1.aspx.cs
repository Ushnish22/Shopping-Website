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
    public partial class Site11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"]!= null)
            {
                Label4.Text = "Logged in as " + Session["username"].ToString();
                HyperLink1.Visible = false;
                Button1.Visible = true;
            }
            else
            {

                Label4.Text = "Hello you can Login.... ";
                HyperLink1.Visible = true;
                Button1.Visible = false;
            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Site1.aspx");
            Label4.Text="You Logged Out Successfully....";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-39GOOGC\SQLEXPRESS; Initial Catalog=RecordDB; Integrated Security= True;");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Products  where (P_Name like '%" + TextBox1.Text + "%')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataList1.DataSourceID = null;
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Session["AddProduct"] = "true";
            if (e.CommandName == "AddToCart")
            {
                DropDownList list = (DropDownList)(e.Item.FindControl("DropDownList1"));
                Response.Redirect("Addtocart.aspx?id=" + e.CommandArgument.ToString() + "&Qty=" + list.SelectedItem.ToString());
            }

        }
    }
}