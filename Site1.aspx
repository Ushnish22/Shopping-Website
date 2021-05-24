<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Site1.aspx.cs" Inherits="Website1.Site11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style="width:1400px; height:30px">
        <tr style="background-color:#5F98F3">
            <td colspan="2" style="text-align:right">
                <asp:Label ID="Label4" runat="server" style="text-align:left" Font-Bold="True" Font-Italic="True" Font-Names="Bahnschrift SemiBold"></asp:Label>
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Names="Arial Rounded MT Bold" NavigateUrl="~/Login.aspx">Click to Login</asp:HyperLink>
                <asp:Button ID="Button1" runat="server" Text="Log Out" BackColor="#FF5050" BorderColor="White" Font-Bold="True" Font-Names="Comic Sans MS" Height="27px" Width="105px" OnClick="Button1_Click" />
            </td>
            <td style="text-align:right">
                <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="174px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton2" runat="server" Height="33px" ImageUrl="~/Images/search.png" OnClick="ImageButton2_Click" />
            </td>
        </tr>
        </table>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Height="293px" Width="310px" RepeatColumns="5" RepeatDirection="Horizontal" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" OnItemCommand="DataList1_ItemCommand">
            <ItemTemplate>
                <table>
                    <tr>
                        <td style="text_align:center; background-color:#5F98F3">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("P_Name") %>' Font-Bold="True"
                                Font-Names="Open Sans Extrabold" ForeColor="White"></asp:Label>
                        </td>
                    </tr>
                     <tr>
                        <td style="text_align:center">
                            <asp:Image ID="Image1" runat="server" BorderColor="#5F98F3" BorderWidth="1px" 
                                Height="279px" Width="278px" ImageUrl='<%# Eval("P_Image") %>'/>
                        </td>
                    </tr>
                     <tr>
                        <td style="text_align:center; background-color:#5F98F3">
                            <asp:Label ID="Label2" runat="server" Text="Price Rs." Font-Bold="True" 
                                Font-Names="Arial" ForeColor="White" Style="text-align:center"></asp:Label>
                             <asp:Label ID="Label3" runat="server" Text='<%# Eval("Price") %>' Font-Bold="True" 
                                Font-Names="Arial" ForeColor="White" Style="text-align:center"></asp:Label>
                        </td>
                    </tr>
                     <tr>
                        <td style="text_align:center">Quantity
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="text_align:center">
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" ImageUrl="~/Images/addtocart.png" 
                                Width="160px" CommandArgument='<%# Eval("ProductId") %>' CommandName="AddToCart"/>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RecordDBConnectionString %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
</asp:Content>
