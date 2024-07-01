<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="forgot-password.aspx.cs" Inherits="Webthuetro.forgot_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assest/css/forgot-password.css" rel="stylesheet" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="header-forgot-password-form">
        <div class="body-forgot-password-form">
            <div class="header-username">
                <label for="txtUsername">Tên đăng nhập :</label>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>
            <div class="header-password">
                <label for="txtNewPassword">Nhập mật khẩu mới:</label>
                <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="header-password-again">
                <label for="txtConfirmPassword">Xác nhận mật khẩu mới:</label>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="header-verification-code">
                <label for="txtVerificationCode">Mã xác minh:</label>
                <asp:TextBox ID="txtVerificationCode" runat="server"></asp:TextBox>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="header-btn-sb" style="font-size:11px; margin-top:10px;">
                        <asp:Button ID="btnSubmit" CssClass="" runat="server" Text="Gửi mã xác minh" OnClick="btnSubmit_Click" />
                    </div>
                    <div class="header-btn-verify  header-btn-submit "style="margin-top:15px; margin-bottom:10px;">
                        <asp:Button ID="btnVerify" CssClass="btnVerify btnSubmit" runat="server" Text="Đổi Mật Khẩu" OnClick="btnVerify_Click" />
                    </div>
                    <asp:Label ID="lblMessage" runat="server" CssClass="message-label" ></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <style>
                .message-label {
                    margin-top: 20px;
                    font-weight: bold;
                    font-size: 14px;
                }
            </style>
        </div>
    </div>
</asp:Content>
