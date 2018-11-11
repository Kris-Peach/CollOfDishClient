<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CollOfDishClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <p><b>Название статьи:</b> <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="219px" BorderStyle="Dotted" Font-Size="Large"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Редактировать" OnClick="Button2_Click" CssClass="button2" />
                <br /></p>
        <asp:Label ID="Label1" runat="server" Text="Статья" CssClass="lable" Font-Size="X-Large"></asp:Label><br />
        <br />
    </div>

</asp:Content>
