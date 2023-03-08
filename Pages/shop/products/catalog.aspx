<%@ Page Title="קטלוג המוצרים" Language="C#" MasterPageFile="~/Master Pages/Master1.Master" AutoEventWireup="true" CodeBehind="catalog.aspx.cs" Inherits="Nave_Project2.Pages.shop.catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/catalog.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="fullscreen">
        <form runat="server" method="post" action="catalog.aspx">
            <label>חפש מוצר</label>
            <input type="text" id="product" name="product" placeholder="שם מוצר" />
            <asp:Button ID="SearchButton" runat="server" Text="חפש" OnClick="SearchButton_Click" CssClass="search" />
        </form>
        <br />
        <div id="CatalogTableDiv" runat="server"></div>
    </div>
</asp:Content>