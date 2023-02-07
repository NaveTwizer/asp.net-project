<%@ Page Title="Test" Language="C#" MasterPageFile="~/Master Pages/Master1.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Nave_Project2.Pages.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <asp:FileUpload runat="server" ID="FileUpload1" AllowMultiple="false" accept="image/*" />
        <asp:Button runat="server" ID="UploadButton" Text="העלה" OnClick="UploadButton_Click" />
    </form>
</asp:Content>