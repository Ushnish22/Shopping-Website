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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-39GOOGC\SQLEXPRESS; Initial Catalog=Ushnish; Integrated Security= True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Register" + "(FName,LName,Address,Gender,Phone,Email,Password)values(@FName,@LName,@Address,@Gender,@Phone,@Email,@Password)", con);
            cmd.Parameters.AddWithValue("@FName", TextBox1.Text);
            cmd.Parameters.AddWithValue("@LName", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Address", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Gender", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@Phone", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Email", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox7.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Registered Successfully";
        }
    }

}
   
