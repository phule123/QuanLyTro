<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="Webthuetro.ManageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assest/css/InputSP.css" rel="stylesheet" />
    <div class="container">
        <div class="container-inputsp">
            <div>
                <asp:Label ID="Label2" runat="server" Text="TÊN KHÁCH HÀNG"></asp:Label>
                <asp:TextBox ID="TEN" runat="server" EnableViewState="True" ></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="GIỚI TÍNH"></asp:Label>
                <asp:TextBox ID="SEX" runat="server" EnableViewState="True" ></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="SỐ ĐIỆN THOAI"></asp:Label>
                <asp:TextBox ID="NUMBER" runat="server" EnableViewState="True" ></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="EMAIL"></asp:Label>
                <asp:TextBox ID="EMAIL" runat="server" EnableViewState="True" ></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="MẬT KHẨU"></asp:Label>
                <asp:TextBox ID="PASSWORD" type="password" runat="server" EnableViewState="True" ></asp:TextBox>
            </div>                
            <asp:Button ID="btnDangTin" runat="server" Text="CẬP NHẬT" OnClick="btnDangTin_Click" AutoPostBack="true"/>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </div>
    <script src="assest/vscode/style.js">
        
    </script>
</asp:Content>
