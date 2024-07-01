<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="quangcao.aspx.cs" Inherits="Webthuetro.quangcao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="assest/css/advertisement.css" rel="stylesheet" />
        <!-- Menu Thông Báo  -->
        <div id="notification">
            <div class="container">
                <div class="header-menu-notification">
                    <div class="body-notification">
                        <a href=""><img src="../support/img/icon email.jpg" alt=""></a>
                        <a class="notification" href="">Thông Báo</a>
                    </div>
                    <div class="body-account">
                        <a href=""><img src="../support/img/icon counselors.png" alt=""></a>
                        <a class="account" href="">Tư Vấn Viên</a>
                    </div>
                </div>
            </div>
        </div>
        <!-- Menu Quảng Cáo -->
        <div id="advertisement">
            <div class="container">
                <div class="menu-advertisement">
                    <div class="header-menu-advertisement">
                        <div class="body-advertising-information-img">
                            <img src="assest/img/3.jpg" alt="">
                        </div>
                        <div class="body-advertising-information">
                            <h1>Quảng Cáo</h1>
                            <h3>Cho thuê phòng full nội thất ngay khu Phan Xích Long, Phú Nhuận</h3>
                            <p><i class="fa-solid fa-location-dot"></i> Đường Phan Xích Long, Phường 1, Quận Phú Nhuận, Tp Hồ Chí Minh</p>
                            <p><i class="fa-solid fa-sack-dollar"></i>  5,3 Triệu/Tháng</p>
                            <p><i class="fa-solid fa-layer-group"></i> Diện tích: 25 m²</p>
                        </div>
                    </div>
                </div>
                    
            </div>
        </div>

        <div id="contentt">
            <div class="container">
                <!-- Menu Mô Tả -->
                <div class="header-">
                    <p>Mình đang còn 1 phòng cho thuê ngay khu Phố ẩm thực Phan Xích Long, Phú Nhuận.
                        Phòng trang bị đầy đủ nội thất: Máy lạnh, tủ lạnh, tủ quần áo, bộ sofa, nệm,...
                        Có cửa sổ thoáng mát, có thang máy, nhà xe dưới trệt free, giờ giấc tự do.
                        Giá cho thuê 5tr3/tháng, cọc 1 tháng, tặng gói sửa chữa miễn phí khi liên hệ trực tiếp mình Chính Chủ.</p>
                </div>
            </div>
        </div>    
    
            
        <div id="lienhe">
            <div class="container">
                    <!-- Menu Liên Hệ -->
                    <div class="header-contact">
                        <div class="body-contact-name">
                            <a href="">Liên Hệ : Lê Tú</a>
                        </div>
                        <div class="body-contact-phone-number">
                            <a href=""><i class="fa-solid fa-phone"></i>0903478989</a>
                        </div>
                        <div class="body-contact-zalo">
                            <a href="">Zalo : 0903478989</a>
                        </div>
                    </div>


                    <!-- Menu Button -->
                    <div class="header-menu-button">
                            <button>Đăng</button>
                            <button>Xóa</button>
                    </div>
            </div>
        </div>
</asp:Content>
