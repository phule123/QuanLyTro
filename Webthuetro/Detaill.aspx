<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detaill.aspx.cs" Inherits="Webthuetro.Detaill" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="assest/css/detail.css" rel="stylesheet" />
    <!-- phan than -->

    <div id="detail">
        <div class="container">
            <div class="container-detail">
                <%--<div class="container-detail-left">--%>
                <%--<div class="listimg">
                            <img src="/assest/img/2.jpg" alt="">
                        </div>
                        <h3>cho thuê phòng q3 full nội thất</h3>
                        <div class="thongtin">
                            <p class="gia">3,3 triệu /tháng</p>
                            <p class="dientich">-40m2</p>
                            <p><i class="fa-solid fa-share"></i>chia sẽ</p>
                            <p><i class="fa-solid fa-heart"></i>lưu tin</p>
                        </div>
                        <div class="diachi "><i class="fa-solid fa-location-dot"></i>18 phan tứ, mỹ an, ngũ hành sơn, đà nẵng</div>
                        <div class="thoigian "><i class="fa-solid fa-business-time"></i></i>đăng 3 giờ trước</div>
                        <div class="kiemduyet "><i class="fa-solid fa-shield"></i>tin đã được kiểm duyệt</div>

                        <div class="content-characteristic">
                            <h4>đặc điểm bất động sản</h4>
                            <div class="characteristic">
                                <div class="characteristic-left">
                                    <p><i class="fa-solid fa-cart-shopping"></i>cho thuê</p>
                                    <p><i class="fa-solid fa-couch"></i>tình trạng nội thất: nội thất đầy đủ</p>
                                </div>
                                <div class="characteristic-right">
                                    <p><i class="fa-brands fa-codepen"></i>diện tích: 40 m²</p>
                                    <p><i class="fa-solid fa-dollar-sign"></i>số tiền cọc: 1.300.000 đ</p>
                                </div>
                            </div>
                        </div>
                        <div class="content-characteristic">
                            <h4>mô tả chi tiết</h4>
                            <p>giá 1.3tr-1.5tr/tháng/người cho thuê ký túc xá ( sạch sẽ, rộng rãi, an ninh )

                                🏘 vị trí đắc địa, không gian thoáng mát, khu đông dân cư, khu nhiều tiện ích ( chợ, siêu thị, circle k, family mart, cafe 24/24, phòng gym...)
                                
                                gần nhiều trường đại học (2--5 phút ra các trường đh công nghiệp, đh nguyễn tất thành, việt mỹ, đh trần đại nghĩa, văn lang .. )
                                
                                đối tượng ở: sinh viên, người độc thân đang đi làm
                                
                                - khu ở được vệ sinh 2-3 ngày/ tuần, phòng có máy lạnh và máy quạt mở xuyên suốt
                                - có khu nấu ăn, sinh hoạt riêng, trong phòng chỉ để quần áo, góc học tập or làm việc và giường ngủ.
                                - mỗi người một giường+tủ khóa riêng biệt+ nhà vệ sinh trong phòng có máy tắm nước nóng
                                - khu sinh hoạt có đầy đủ nội thất ( chén dĩa, tủ bếp,bếp điện, máy giặt, tủ lạnh, bàn ghế ăn, máy lọc nước uống )
                                - bãi đậu xe rộng rãi, ra vào sử dụng khoá vân tay, có camera an ninh
                                phòng ở 4-8 người
                                
                                giá trọn gói, ko phát sinh thêm nên bạn nào muốn tiết kiệm chi phí thì liên hệ để xem phòng
                                địa chỉ : 270 nguyễn oanh, p17, gò vấp</p>
                        </div>--%>
                <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                <hr />
                <h4>Bình luận</h4>
                <div id="commentsContainer" runat="server"></div>
                <!-- Form bình luận -->
                <asp:Panel ID="pnlComment" runat="server">
                    <asp:TextBox ID="txtComment" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    <asp:Button ID="btnSubmitComment" runat="server" Text="Đăng bình luận" CssClass="btn btn-primary" OnClick="btnSubmitComment_Click" />
                </asp:Panel>


                <%--</div>--%>
                <%--<div class="container-detail-right">
                        <div class="taikhoan">
                            <div class="taikhoan-left">
                                <h4 class="ten">phạm thị thu hà</h4>
                                <p class="con"><i class="fa-solid fa-folder"></i>môi giới</p>
                                <p class="con">hoạt động 21 giờ trước</p>
                            </div>
                            <div class="taikhoan-right">
                                <div class="xemtrang">xem trang<i class="fa-solid fa-chevron-right"></i></div>
                            </div>
                            

                        </div>
                        <div class="lienhe">
                            <p class="dau">liên hệ người bán</p>
                            <p class="cuoi">phản hồi: 90%</p>
                        </div>
                        <div class="call">
                            <a class="sdt" href="/contact.html"><p><i class="fa-solid fa-phone"></i>0356337618</p><p>bấm để hiện số</p></a>
                            <a class="chat" href=""><p><i class="fa-solid fa-message"></i></p><p>chat với người bán</p></a>
                        </div>
                    </div>--%>
            </div>
        </div>
    </div>




    </div>
   
    <script src="assest/vscode/style.js">
        
    </script>
</asp:Content>
