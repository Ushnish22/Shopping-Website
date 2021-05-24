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
    public partial class Addtocart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["buyitems"] == null)
                {
                    Button1.Enabled = false;
                }
                else
                {
                    Button1.Enabled = true;
                }
                
                Session["addproduct"] = false;
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("sno");
                dt.Columns.Add("Pid");
                dt.Columns.Add("P_name");
                dt.Columns.Add("P_image");
                dt.Columns.Add("Price");
                dt.Columns.Add("Qty");
                dt.Columns.Add("Total");



                if(Request.QueryString["id"] != null)
                {
                    if (Session["BuyItems"] == null)
                    {
                        dr = dt.NewRow();
                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-39GOOGC\SQLEXPRESS; Initial Catalog=RecordDB; Integrated Security= True;");
                        SqlDataAdapter da = new SqlDataAdapter("select * from Products where ProductId=" + Request.QueryString["id"], con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dr["sno"] = 1;
                        dr["Pid"] = ds.Tables[0].Rows[0]["ProductId"].ToString();
                        dr["P_Name"] = ds.Tables[0].Rows[0]["P_Name"].ToString();
                        dr["P_Image"] = ds.Tables[0].Rows[0]["P_Image"].ToString();
                        dr["Price"] = ds.Tables[0].Rows[0]["Price"].ToString();
                        dr["Qty"] = Request.QueryString["Qty"];

                        int price = Convert.ToInt32(ds.Tables[0].Rows[0]["Price"].ToString());
                        int Quantity = Convert.ToInt32(Request.QueryString["Qty"].ToString());
                        int TotalPrice = price * Quantity;
                        dr["Total"] = TotalPrice;


                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        Session["buyitems"] = dt;
                        Button1.Enabled = true;

                        GridView1.FooterRow.Cells[5].Text = "Total Amount";
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        Response.Redirect("Addtocart.aspx");
                    }
                    else
                    {
                        dt = (DataTable)Session["buyitems"];
                        int sr;
                        sr = dt.Rows.Count;

                        dr = dt.NewRow();
                        SqlConnection scon = new SqlConnection(@"Data Source=DESKTOP-39GOOGC\SQLEXPRESS; Initial Catalog=RecordDB; Integrated Security= True;");
                        SqlDataAdapter da = new SqlDataAdapter("select * from Products where ProductId=" + Request.QueryString["id"], scon);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dr["sno"] = sr+1;
                        dr["Pid"] = ds.Tables[0].Rows[0]["ProductId"].ToString();
                        dr["P_Name"] = ds.Tables[0].Rows[0]["P_Name"].ToString();
                        dr["P_Image"] = ds.Tables[0].Rows[0]["P_Image"].ToString();
                        dr["Price"] = ds.Tables[0].Rows[0]["Price"].ToString();
                        dr["Qty"] = Request.QueryString["Qty"];


                        int price = Convert.ToInt32(ds.Tables[0].Rows[0]["Price"].ToString());
                        int Quantity = Convert.ToInt16(Request.QueryString["Qty"].ToString());
                        int TotalPrice = price * Quantity;
                        dr["Total"] = TotalPrice;

                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        Session["buyitems"] = dt;
                        Button1.Enabled = true;

                        GridView1.FooterRow.Cells[5].Text = "Total Amount";
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        Response.Redirect("Addtocart.aspx");

                    }
                }
                else
                {
                    dt = (DataTable)Session["buyitems"];
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    if(GridView1.Rows.Count>0)
                    {
                        GridView1.FooterRow.Cells[5].Text = "Total Amount";
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                    }

                }

            }
            string OrderDate = DateTime.Now.ToShortDateString();
            Session["Orderdate"] = OrderDate;
            orderid();


            //2.Calculating Final Price


             int grandtotal()
             {
                DataTable dt = new DataTable();
                dt = (DataTable)Session["buyitems"];
                int nrow = dt.Rows.Count;
                int i = 0;
                int totalprice = 0;
                while (i < nrow)
                {
                    totalprice = totalprice + Convert.ToInt32(dt.Rows[i]["Price"].ToString());
                    i = i + 1;
                }
                return totalprice;
             }
             void orderid()
            {
                string alpha = "abCdefghIjklmNopqrStuvwXyz123456789";
                Random r = new Random();
                char[] myArray = new char[5];
                for(int i=0;i<5;i++)
                {
                    myArray[i] = alpha[(int)(35 * r.NextDouble())];
                }
                String order;
                order = "Order_Id:" + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + new string(myArray) + DateTime.Now.Month.ToString();
                Session["Orderid"] = order;
            }

            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];

            for(int i=0; i<=dt.Rows.Count-1;i++)
            {
                int sr;
                int sr1;
                string qdata;
                string dtdata;
                sr = Convert.ToInt32(dt.Rows[i]["sno"].ToString());
                TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];
                qdata = cell.Text;
                dtdata = sr.ToString();
                sr1 = Convert.ToInt32(qdata);

                if(sr == sr1)
                {
                    dt.Rows[i].Delete();
                    dt.AcceptChanges();
                    break;
                }
            }

            for(int i=1; i<=dt.Rows.Count; i++)
            {
                dt.Rows[i - 1]["sno"] = i;
                dt.AcceptChanges();
            }
            Session["buyitems"] = dt;
            Response.Redirect("Addtocart.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = (DataTable)Session["buyitems"];
            for(int i=0; i<= dt.Rows.Count-1; i++)
            {
                SqlConnection scon = new SqlConnection(@"Data Source=DESKTOP-39GOOGC\SQLEXPRESS; Initial Catalog=RecordDB; Integrated Security= True");
                scon.Open();
                SqlCommand cmd = new SqlCommand("Insert into OrderDetails(Orderid,sno,productid,productname,price,quantity,orderdate)values('"+Session["Orderid"]+"',"
             +dt.Rows[i]["sno"]+","+dt.Rows[i]["Pid"]+",'"+dt.Rows[i]["P_Name"]+"',"+dt.Rows[i]["Price"]+","+dt.Rows[i]["Qty"]+ ",'"+Session["Orderdate"]+"')", scon);
                cmd.ExecuteNonQuery();
                scon.Close();
                
            }


            if(Session["username"] == null)
            {
                Response.Redirect("PlaceOrder.aspx");
            }
            else
            {
                if(GridView1.Rows.Count.ToString() == "0")
                {
                    Response.Write("<script>alert('Your Cart Is Empty. You cannot place an order');</script>");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }

}


    
