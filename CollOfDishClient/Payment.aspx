<%@ Page Title="Payment" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="CollOfDishClient.Payment" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Оплата заказа</h2>
    <div class="row">
        <div class="col-md-12" style="margin-top:5%;">
            <!-- Credit Card -->
        <div id="form-errors" class="hidden">
            <i class="fa fa-exclamation-triangle"></i>
            <p id="card-error">Card error</p>
        </div>
        <div id="form-container">

          <div id="card-front">
            <div id="shadow"></div>
            <div id="image-container">
              <span id="amount">Оплата: <strong><asp:Label ID="Lbl_cost" runat="server"
                 Text="300p." Visible="true" ></asp:Label></strong></span>
              <span id="card-image">
      
               </span>
            </div>
            <!--- end card image container --->

           <label for="card-number">
                Номер карты
            </label>
            <!--<input type="text" id="card-number" placeholder="1234 5678 9101 1112" length="16"> -->
           <asp:TextBox ID="TxtBox_cardNumber" CssClass="card-number" placeholder="1234 5678 9101 1112"
                length="16" Visible="true" runat="server"></asp:TextBox>
            <div id="cardholder-container">
                <label for="card-holder">Имя держателя карты
                </label>
                <!--<input type="text" id="card-holder" placeholder="e.g. John Doe" />-->
                <asp:TextBox ID="TxtBox_cardHolder" CssClass="card-holder"
                    placeholder="IVAN IVANOV" Visible="true" runat="server"></asp:TextBox>
            </div>
           <!--- end card holder container --->
            <div id="exp-container">
                <label for="card-exp">
                    Срок действия карты
                </label>
                <!--<input id="card-month" type="text" placeholder="MM" length="2">-->
                <asp:TextBox ID="TxtBox_cardMonth" Visible="true" placeholder="MM" length="2" runat="server" />
               <!-- <input id="card-year" type="text" placeholder="YY" length="2"> -->
                <asp:TextBox ID="TxtBox_cardYear" Visible="true" placeholder="YY" length="2" runat="server"></asp:TextBox>
            </div>
           <div id="cvc-container">
            <label for="card-cvc"> CVC/CVV</label>
            <!--<input id="card-cvc" placeholder="XXX-X" type="text" min-length="3" max-length="4"> -->
               <asp:TextBox ID="TxtBox_cardCVC" Visible="true" CssClass="card-cvc" placeholder="XXX" length="3" runat="server"></asp:TextBox>
            <p>Last 3 or 4 digits</p>
           </div>
        <!--- end CVC container --->
        <!--- end exp container --->
         </div>
        <!--- end card front --->
           <div id="card-back">
                <div id="card-stripe">
            </div>

            </div>
        <!--- end card back --->
        <input type="text" id="card-token" />
       <!-- <button type="button" id="card-btn">Submit</button> -->
            

   </div>
    </div>
        <div class="col-md-12 text-center" style="padding-top:5%;">
            <asp:Button ID="Btn_cardBtn" Visible="true" CssClass="my-btn btn btn-warning"
                Text="Оплатить" runat="server" />
        </div>
    </div>
</asp:Content>

