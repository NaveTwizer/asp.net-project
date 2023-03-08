<%@ Page Title="חפש קבלה" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="search-invoice.aspx.cs" Inherits="Nave_Project2.Pages.shop.search_invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/search-invoice.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
      <h1>חפש קבלה</h1>
      <form action="search-invoice.aspx" method="post" runat="server">
        <label for="invoice-number">חפש קבלה</label>
        <input type="text" id="invoice-number" name="invoice-number" placeholder="הכנס מספר קבלה..">
        
        <asp:Button CssClass="submit" runat="server" ID="SearchButton" OnClick="SearchButton_Click" />
      </form>
    </div>
</asp:Content>