<%@ Page Title="סך מכירות לכל לקוח" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="sales-per-user.aspx.cs" Inherits="Nave_Project2.Pages.admin.queries.sales_per_user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/queries.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>סך מכירות לכל לקוח</h1>
    <div id="TableDiv" runat="server"></div>
</asp:Content>