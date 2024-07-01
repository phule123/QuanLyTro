<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="QuanLyBaiDang.aspx.cs" Inherits="Webthuetro.QuanLyBaiDang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assest/css/QuanLyBaiDang.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <h2 class="h2content">Bài đăng của bạn</h2>
    <div id="container">
        <asp:Repeater ID="repeaterPosts" runat="server">
            <ItemTemplate>
                <div>
                    <a class="content-content" href='<%# "Detaill.aspx?id=" + Eval("ID_BAIDANG") %>'>
                        <div class="view_content">
                            <div class="img">
                                <asp:Image ID="imgHinhAnh" runat="server" ImageUrl='<%# "/Images/" + Eval("HINHANH") %>' AlternateText="" />
                            </div>
                            <div class="content">
                                <h6 id="tieude"><%# Eval("TIEUDE") %></h6>
                                <div class="content1">
                                    <p class="dientich" id="dientich"><%# Eval("DIENTICH") %></p>
                                    <p class="sophong" id="phong">2 PN</p>
                                    <div class="gia" id="gia"><%# Eval("GIA", "{0:N0}") %> VNĐ/tháng</div>
                                    <div class="gio" id="ngaydang"><%# Eval("NGAYDANG") %></div>
                                    <div class="diachi" id="diachi"><%# Eval("DIACHI") %></div>
                                </div>
                            </div>
                        </div>
                    </a>
                    <asp:Button runat="server" CommandName="DeletePost" CommandArgument='<%# Eval("ID_BAIDANG") %>' Text="Xóa" OnClick="DeletePost_Click"/>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
</asp:Content>
