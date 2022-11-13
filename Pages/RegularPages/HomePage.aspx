<%@ Page Title="דף הבית" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <style type="text/css">
        body {
            background:url("../../images/HomeBackground.jpg");
            background-size:cover;
            background-repeat:no-repeat;
            margin:0;
            padding:0;
        }
        .title {
            color:black;
            font-size:50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <h1 class="title">דף הבית</h1>
</asp:Content>