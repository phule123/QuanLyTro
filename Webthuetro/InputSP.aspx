<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="InputSP.aspx.cs" Inherits="Webthuetro.InputSP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assest/css/InputSP.css" rel="stylesheet" />
    <div class="container">
        <div class="container-inputsp">
            <div>
                <asp:Label ID="Label1" runat="server" Text="Tiêu Đề"></asp:Label>
                <asp:TextBox ID="Tieude" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Giá Thuê"></asp:Label>
                <asp:TextBox ID="Giathue" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Diện Tích"></asp:Label>
                <asp:TextBox ID="Dientich" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Địa Chỉ"></asp:Label>
                <asp:TextBox ID="Diachi" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Tình Trạng Nội Thất"></asp:Label>
                <asp:TextBox ID="Tinhtrang" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="Số Tiền Cọc"></asp:Label>
                <asp:TextBox ID="Tiencoc" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label7" runat="server" Text="Mô Tả Chi Tiết" CssClass="mota"></asp:Label>
                <asp:TextBox ID="Mota" runat="server"></asp:TextBox>
            </div>
            <div class="gioitinh">
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="user" Text="Thuê Trọ" />
                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="user" Text="Tìm trọ" />
            </div>
            <div>
                <asp:Label ID="Label8" runat="server" Text="Hình ảnh"></asp:Label>
                <%--<input type="file" name="file" id="file" accept="image/*">--%>
                <asp:FileUpload ID="FileUpload1" runat="server" Text="Hình ảnh" />
            </div>
            <asp:Button ID="btnDangTin" runat="server" Text="Đăng Tin Trọ" OnClick="BtnDangTin_Click" />
        </div>
    </div>
    <script src="assest/vscode/style.js">
        
    </script>
</asp:Content>
