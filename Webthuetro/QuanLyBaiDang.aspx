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
                    <div class="post-container">
                        <a class="content-link" href='<%# "Detaill.aspx?id=" + Eval("ID_BAIDANG") %>'>
                            <div class="view-content">
                                <div class="img">
                                    <asp:Image ID="imgHinhAnh" runat="server" ImageUrl='<%# "/Images/" + Eval("HINHANH") %>' AlternateText="Image" CssClass="post-image" />
                                </div>
                                <div class="content">
                                    <h6 class="post-title"><%# Eval("TIEUDE") %></h6>
                                    <div class="content-details">
                                        <p class="dientich"><%# Eval("DIENTICH") %> M2</p>
                                        <p class="sophong">2 PN</p>
                                        <div class="gia"><%# Eval("GIA", "{0:N0}") %> VNĐ/tháng</div>
                                        <div class="gio"><%# Eval("NGAYDANG") %></div>
                                        <div class="diachi"><%# Eval("DIACHI") %></div>
                                    </div>
                                </div>
                            </div>
                        </a>
                        <asp:Button runat="server" CssClass="button-delete-post" ID="buttonDeletePost" CommandName="DeletePost" CommandArgument='<%# Eval("ID_BAIDANG") %>' Text="Xóa" OnClick="DeletePost_Click" />

                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
