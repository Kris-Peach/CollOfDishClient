<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="CollOfDishClient.SearchPage" %>

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
        <div class="col-md-9" >
            <div class="form-inline">
                
                <div class="form-group" style="padding-top: 3%; padding-right:0; width:87%;">
                    <label  class="col-xs-6 control-label" for="search" style="width:auto; font-size:25px;">Поиск блюд <span class = "glyphicon glyphicon-search" style="padding-top:3%;"></span>:</label>
                    <asp:TextBox ID="TxtBox_search"  placeholder="Введите название блюда" runat="server"
                    CssClass="txt-search input-lg"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="valid_search" ControlToValidate="TxtBox_search"
                Display="Dynamic">пустой запрос</asp:RequiredFieldValidator>
                </div>
                <asp:Button ID="Btn_search" runat="server" CausesValidation="true" CssClass="btn-search btn btn-warning"
                Text="найти" OnClick="Btn_search_Click" /><!--<span class = "glyphicon glyphicon-search"></span> -->
            </div>
            
            </div>
            
        <div class="col-md-3">
            <div class="row" style="padding-top:3%;">
                <div class="col-md-4" style="padding-top:3%;">
                    <img src="Source/Images/user-icon-png-pnglogocom.png" class="img-responsive" alt="Responsive Image"/> 
                </div>
                <div class="col-md-4" style="padding-top:6%;">
                  <asp:Label runat="server" ID="Lbl_usrName" CssClass="lable-user">Kristina Gridneva</asp:Label>  
                </div>
            </div>
        </div>
    </div>
</asp:Content>


