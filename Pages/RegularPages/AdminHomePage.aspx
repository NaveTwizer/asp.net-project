<%@ Page Title="דף הבית" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.AdminHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../Styles/dropdown.css" rel="stylesheet" />
    <style type="text/css">
        h1 {
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>מרכז בקרת מנהל</h1>
</asp:Content>