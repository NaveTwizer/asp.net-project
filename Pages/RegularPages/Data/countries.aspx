<%@ Page Title="מדינות" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="countries.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Data.countries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <style type="text/css">
        table {
            margin-left: auto;
            margin-right: auto;
            text-align:center;
            border-collapse:collapse;
            font-size:120%;
        }
        table td {
            border:1px solid black;
            padding:4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>מדינות</h1>
    <%ListCountries(); %>
</asp:Content>