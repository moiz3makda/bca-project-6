<%@ Page Language="C#" MasterPageFile ="~/loggedin.master" AutoEventWireup="true" CodeFile="admin_feedback.aspx.cs" Inherits="admin_feedback" %>

<asp:Content ID="content" ContentPlaceHolderID ="slider" runat ="server">
<center>
    <asp:GridView ID="gd1" runat ="server" Font-Size="Larger" Height="50px" BorderColor ="black" BorderWidth ="20px" 
        Width ="1000px" align="center"  
        AutoGenerateColumns="true" DataKeyNames="id">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('are you sure to delete?');" OnClick="LinkButton1_Click">Delete Record</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
    </center><br /><br />
    <center><asp:LinkButton ID="LinkButton2" runat ="server" Text="back to admin home page" PostBackUrl ="~/admin_link.aspx"></asp:LinkButton></center><br /><br />
        <center><asp:LinkButton ID="logout" runat ="server" Text="LogOut" PostBackUrl ="~/Admin_Login.aspx"></asp:LinkButton></center>
</asp:Content>