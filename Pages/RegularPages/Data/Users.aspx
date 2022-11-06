<%@ Page Title="משתמשים" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Data.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <style type="text/css">
        table {
            margin-left: auto;
            margin-right: auto;
            text-align:center;
            border-collapse:collapse;

        }
        table td {
            border:1px solid black;
            padding:4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>טבלת משתמשים</h1>
    <%ListUsers(); %>
</asp:Content>
