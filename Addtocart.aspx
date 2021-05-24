<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addtocart.aspx.cs" Inherits="Website1.Addtocart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" style="margin:0 auto;">
            <h2 style="text-decoration: underline overline blink; color:#5F98F3">You Have Following Products In Your Cart</h2>
            <br /><br />
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Names="Colonna MT" Font-Size="X-Large" NavigateUrl="~/Site1.aspx">Continue Shopping</asp:HyperLink>
            <br /><br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#FF6699" BorderColor="#333333" BorderWidth="5px" Font-Bold="True" Height="257px" ShowFooter="True" Width="1200px" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="sno" HeaderText="Serial No.">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Pid" HeaderText="ProductId">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="P_Name" HeaderText="Product Name">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:ImageField DataImageUrlField="P_Image" HeaderText="Product Image">
                        <ControlStyle Height="300px" Width="340px" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:ImageField>
                    <asp:BoundField DataField="Price" HeaderText="Price">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Qty" HeaderText="Quantity">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Total" HeaderText="Total Price">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:CommandField DeleteText="Remove" ShowDeleteButton="True" />
                </Columns>
                <FooterStyle BackColor="#6666FF" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#660033" ForeColor="White" />
            </asp:GridView>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Go to payments page" BackColor="#FF6699" BorderColor="#0A2C2A" BorderStyle="Ridge" Height="40px" OnClick="Button1_Click" Width="150px" Font-Bold="True" Font-Size="Small" ForeColor="Blue" />
        </div>
    </form>
</body>
</html>
