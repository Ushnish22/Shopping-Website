<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Website1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
   
    </head>
<body>
   
  
    <form id="form1" runat="server">
   
  
    <table style="width: 700px; height: 600px; background-color: #5F98F3;" align="center">
        <tr>
            <td colspan="2" align="center"><b>Login Page</b></td>
        </tr>
        <tr>
            <td align="center" width="50%">Email</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="38px" Width="183px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" width="50%">Password</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="38px" Width="193px" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Login" Font-Bold="True" Font-Size="Large" OnClick="Button1_Click" /></td>
           
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
        </tr>
    </table>
   
  
    </form>
   
  
</body>
</html>
