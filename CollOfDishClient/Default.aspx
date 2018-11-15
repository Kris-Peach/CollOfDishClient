<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CollOfDishClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="main-title">
            <div class="title-client">
                <p> COLLOFDISH
            </div>
            <div class="under-title">
                <p>- Find Your Dish -</p>
            </div>
            
        </div>
        <div class="galary">
            
            <div class="col-md-3">
                <img src="Source/Images/348s.jpg" class="img-responsive" alt="Responsive image"/>
            </div>
            <div class="col-md-3">
                <img src="Source/Images/f4e19f8554.jpg" class="img-responsive"  alt="Responsive image"/>
            </div>
            <div class="col-md-3">
                <img src="Source/Images/212783-one-eyeland-roasted_chicken_slices-by-greg-stroube.jpg" class="img-responsive"  alt="Responsive image"/>
            </div>
            <div class="col-md-3">
                <img src="Source/Images/2.jpg" class="img-responsive"  alt="Responsive image" />
            </div>
                  
        </div>
        <div class="btn-on-home-page">
            <div class="col-md-6 text-right">
                <button type="button" class="my-btn btn btn-warning ">ВХОД</button>
            </div>
            <div class="col-md-6 text-left">
                <button type="button" class="my-btn btn btn-warning">РЕГИСТРАЦИЯ</button>
            </div>
        </div>
        
        <!--<p><b>Название статьи:</b> <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="219px" BorderStyle="Dotted" Font-Size="Large"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Редактировать" OnClick="Button2_Click" CssClass="button2" />
                <br /></p>
        <asp:Label ID="Label1" runat="server" Text="Статья" CssClass="lable" Font-Size="X-Large"></asp:Label><br />
        <br />-->
    </div>

</asp:Content>
