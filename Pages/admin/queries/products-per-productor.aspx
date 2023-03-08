<%@ Page Title="סך מוצרים לפי יצרן" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="products-per-productor.aspx.cs" Inherits="Nave_Project2.Pages.admin.queries.products_per_productor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/queries.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>סך מוצרים לפי יצרן</h1>
    <div id="TableDiv" runat="server"></div>
</asp:Content>
