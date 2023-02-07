<%@ Page Title="מכירות" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="sales.aspx.cs" Inherits="Nave_Project2.Pages.data.sales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/TablesStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div runat="server" id="TableDiv"></div>
    <form action="sales.aspx" method="post" runat="server">
        <input type="text" name="code" placeholder="חפש לפי קוד מכירה" />
        <asp:Button runat="server" ID="SearchSaleByCode" OnClick="SearchSaleByCode_Click" Text="חפש" />
    </form>
</asp:Content>