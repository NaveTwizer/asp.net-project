<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="invoice.aspx.cs" Inherits="Nave_Project2.Pages.shop.Invoices.invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/invoice.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 id="title" runat="server"></h2>
    <h3 id="title2" runat="server"></h3>
    <h4 id="PurchaseDate" runat="server"></h4>
    <br />
    <div id="TableDiv" runat="server"></div>
    

    <button class="print-button" onclick="window.print();return false;"><span class="print-icon"></span></button>
</asp:Content>