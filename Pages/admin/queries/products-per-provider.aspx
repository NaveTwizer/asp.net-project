<%@ Page Title="סך מוצרים לספק" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="products-per-provider.aspx.cs" Inherits="Nave_Project2.Pages.admin.queries.products_per_provider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/queries.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>סך מוצרים לספק</h1>
    <div id="TableDiv" runat="server"></div>
</asp:Content>