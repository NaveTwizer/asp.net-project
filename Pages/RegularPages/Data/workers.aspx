<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="workers.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Data.workers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../../Styles/DataFilesStyle.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>עובדים</h1>
    <%ListWorkers(); %>
</asp:Content>