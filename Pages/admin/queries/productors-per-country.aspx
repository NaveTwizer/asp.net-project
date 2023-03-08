<%@ Page Title="סך יצרנים מכל מדינה" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="productors-per-country.aspx.cs" Inherits="Nave_Project2.Pages.admin.queries.productors_per_country" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/queries.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>סך יצרנים מכל מדינה</h1>
    <div id="TableDiv" runat="server"></div>
</asp:Content>