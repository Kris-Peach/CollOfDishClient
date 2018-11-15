<%@ Page Title="Enter" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnterPage.aspx.cs" Inherits="CollOfDishClient.About" %>

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

        <div style="padding-top:25%; padding-left:25%; ">
           <!-- <form class="form-horizontal"> -->
                <div class="form-group text-center" style="padding-top: 3%;">
                    <label for="usr" class="col-xs-2 control-label">Логин:</label>
                    <div class="col-xs-10">
                    <input type="text" class="form-control" id="usr" placeholder="Введите логин">
                    </div>
                </div>
                <div class="form-group text-center" style="padding-top:3%;">
                    <label for="inputPassword" class="col-xs-2 control-label">Пароль:</label>
                    <div class="col-xs-10">
                    <input type="password" class="form-control" id="inputPassword" placeholder="Введите пароль">
                    </div>
                </div>
                <div class="form-group" style="padding-top:5%;">
                    <div class="col-xs-offset-3 col-xs-10">
                        <button type="submit" class="my-btn btn btn-warning ">войти</button>
                    </div>
                </div>
           <!-- </form> -->
        </div>
        
        
    </div>
   
</asp:Content>
