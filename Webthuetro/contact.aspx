<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Webthuetro.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assest/css/contact.css" rel="stylesheet" />
    <div class="container">
                <div>
                    <div class="title">
                        <p> LIÊN HỆ TRỰC TIẾP</p>
                    </div>
                    <div class="contact">
                        <ul>
                            <li>
                                <label for="--">
                                    <i class="fa-solid fa-user"></i>
                                    User
                                </label>
                            </li>
                            <li>
                                <div class="rating-container">
                                    <label for="--">Đánh giá</label>
                                    <div class="rating">
                                        <span class="star" data-value="1">&#9733;</span>
                                        <span class="star" data-value="2">&#9733;</span>
                                        <span class="star" data-value="3">&#9733;</span>
                                        <span class="star" data-value="4">&#9733;</span>
                                        <span class="star" data-value="5">&#9733;</span>
                                    </div>
                                </div>
                            </li>
    
                            <li>
                                <p> Mô tả :</p>
                            </li>
                        </ul>
    
    
                    </div>
                </div>
                <hr class="horizontal-line">
                <div class="suggest">
                    <label class="custom-label" onclick="window.location.href='index.html'">Trọ này còn không</label>
                    <label class="custom-label" onclick="window.location.href='index.html'">Thời hạn thuê bao lâu</label>
                    <label class="custom-label" onclick="window.location.href='index.html'">Có thêm chi phí phát sinh
                        không</label>
                </div>
                <hr class="line">
                <div class="form-button">
                    <div class="button-container">
                        <button><i class="fas fa-phone icon"></i>SĐT</button>
                    </div>
                    <div class="button-container">
                        <button><i class="fas fa-comments icon"></i>Chat</button>
                    </div>
                </div>
            </div>

            <!--Đánh giá ngôi sao-->
            <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
            <script>
                $(".star").click(function () {
                    var value = $(this).data("value");
                    $(".star").removeClass("rated");
                    $(this).prevAll().addBack().addClass("rated");

                });
            </script>
</asp:Content>
