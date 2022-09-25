<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <style type="text/css">
        body {
            background:url("../../images/AC2.jpg");
            background-size:cover;
            background-repeat:no-repeat;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="title">דף הבית</h1>
</asp:Content>