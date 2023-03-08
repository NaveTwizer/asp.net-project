<%@ Page Title="סך מוצרים לפי ארץ יצרן" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="products-per-country.aspx.cs" Inherits="Nave_Project2.Pages.admin.queries.products_per_country" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/queries.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>סך מוצרים לפי ארץ היצרן</h1>
    <div id="TableDiv" runat="server"></div>
</asp:Content>