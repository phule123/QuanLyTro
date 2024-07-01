<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webthuetro.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assest/css/dssanpham.css" rel="stylesheet" />
    <link href="assest/css/trangchu.css" rel="stylesheet" />
    <div id="header">
        <div class="container">
            <div class="container_header">
                <div class="slide">
                    <div class="dieuhuong">
                        <i class="fa-solid fa-angle-left" onclick="PreviousSlide()"></i>
                        <i class="fa-solid fa-angle-right" onclick="NextSlide()"></i>
                    </div>
                    <div class="slide-chuyenanh">
                        <img src="assest/img/Screenshot 2024-02-26 092621.jpg" alt="">
                        <img src="assest/img/1.jpg" alt="">
                        <img src="assest/img/2.jpg" alt="">
                        <img src="assest/img/3.jpg" alt="">
                        <img src="assest/img/5.jpg" alt="">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="themmoi" runat="server" class="themmoi" >
        <div class="container">
            <div class="container-themmoi">
                <a href="InputSP.aspx">Đăng tin mới</a>
            </div>
        </div>
    </div>
    <div class ="theloai" style="margin-top:20px;">
        <div class="container">
            <div class="container-theloai">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2Click" CssClass="a">THUÊ TRỌ</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton1Click">TÌM TRỌ</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton3Click">Tất cả</asp:LinkButton>
            </div>
        </div>
    </div>
    
    <!-- nội dung -->

    <div class="container">
        <div class="container-view_content" id="data-container">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
        <div id="pagingContainer" runat="server" class="paging-container">
            <!-- Liên kết phân trang sẽ được tạo động tại đây -->
        </div>
    </div>
    <style>
        .paging-container {
            text-align: center;
            margin-top: 20px;
        }

        .paging-link {
            margin: 0 5px;
            padding: 10px 15px;
            border: 1px solid #ddd;
            background-color: #f9f9f9;
            text-decoration: none;
            color: #007bff;
        }

            .paging-link:hover {
                background-color: #e9e9e9;
                border-color: #ccc;
            }

            .paging-link.active {
                background-color: #007bff;
                color: #fff;
                border-color: #007bff;
            }
    </style>
    <script>
        $(document).ready(function () {
            let pageNumber = 1;
            const pageSize = 10;
            let isLoading = false;

            function loadData() {
                if (isLoading) return;
                isLoading = true;
                $('#loading-message').show();
                pageNumber++;
                const searchKeyword = new URLSearchParams(window.location.search).get('searchKeyword') || '';
                $.get(`/Default.aspx?pageNumber=${pageNumber}&pageSize=${pageSize}&searchKeyword=${searchKeyword}`, function (data) {
                    $('#data-container').append($(data).find('#data-container').html());
                    $('#loading-message').hide();
                    isLoading = false;
                });
            }

            $(window).scroll(function () {
                if ($(window).scrollTop() + $(window).height() >= $(document).height() - 100) {
                    loadData();
                }
            });
        });
    </script>

</asp:Content>
