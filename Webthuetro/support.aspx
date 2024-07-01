<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="support.aspx.cs" Inherits="Webthuetro.support" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assest/css/support.css" rel="stylesheet" />
    
        <div class="container">

           

         <!-- Menu Thông Báo  -->
        <div class="header-menu-notification">
            <div class="body-notification">
                <a href=""><img src="img/icon email.jpg" alt=""></a>
                <a class="notification" href="">Thông Báo</a>
            </div>
            <div class="body-account">
                <a href=""><img src="img/icon counselors.png" alt=""></a>
                <a class="account" href="../index.html">Tư Vấn Viên</a>
            </div>
        </div>
 

        <!-- Menu Liên Hệ -->
         <div class="header-Contact">
            <div class="header-title-contact">
                <h1>Hỗ Trợ</h1>
            </div>

            <div class="body-contact">
                <div class="body-contact-direct">
                    <a href=""><img src="img/contact-direc.png" alt=""></a>
                    <a href=""><p>Liên hệ trực tiếp</p></a>
                </div>
                <div class="body-contact-email">
                    <a href=""><img src="img/contact-email.png" alt=""></a>
                    <a href=""><p>thuetro@gmail.com</p></a>
                </div>
                <div class="body-contact-phone-number">
                    <a href=""><img src="img/contact-phone-number.png" alt=""></a>
                    <a href=""><p>19005005</p></a>
                </div>
            </div>
         </div>
 
        
         <!-- Menu Center Support -->
         <div class="header-center-support">
            <a class="body-center-support" href="">Trung tâm trợ giúp</a>
            <a class="body-renter" href="">Tôi là người cho thuê</a>
            <a class="body-tenant" href="">Tôi là người thuê</a>
         </div>
</asp:Content>
