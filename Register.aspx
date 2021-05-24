<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Website1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    
   
</head>
<body>
    
    
 
    <form id="form1" runat="server">
    
    
 
   <table align="center" style="width: 700px; height: 600px; background-color: #5F98F3" >
        <tr colspan="2" align="center">
            <td class="auto-style2"><h2 class="auto-style1">Registration Page</h2></td>
           
        </tr>
        <tr>
            <td width="50%">First Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="49px" Width="227px"></asp:TextBox>
            </td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </tr>
        <tr>
            <td width="50%">Last Name</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Height="49px" Width="227px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="50%">Address</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Height="49px" Width="227px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="50%">Gender</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="33px" Width="225px">
                    <asp:ListItem>Select Gender</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td width="50%">Phone</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Height="49px" Width="227px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="50%">Email</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Height="49px" Width="227px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="50%">Password</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Height="49px" Width="227px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="50%">Confirm Password</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" Height="49px" Width="227px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Register" Font-Bold="True" Font-Size="Large" Height="38px" Width="116px" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
 
    </form>
 
</body>
</html>
