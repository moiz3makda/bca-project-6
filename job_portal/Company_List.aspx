<%@ Page Language="C#" MasterPageFile ="~/loggedin.master" AutoEventWireup="true" CodeFile="Company_List.aspx.cs" Inherits="Company_List" %>

<asp:Content ID ="content" ContentPlaceHolderID ="slider" runat ="server" >
    <asp:GridView ID ="gd1" align="center" BorderWidth="20px" BorderColor="Black" Height="50px" Width ="1000px" Font-Size="Larger" runat ="server">
        
</asp:GridView>

    <br /><br />
    <center><asp:LinkButton ID="logout" runat ="server" Text="LogOut" PostBackUrl ="~/User_Login.aspx"></asp:LinkButton></center>
</asp:Content>