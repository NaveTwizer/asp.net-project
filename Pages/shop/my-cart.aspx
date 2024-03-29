﻿<%@ Page Title="עגלת הקניות שלי" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="my-cart.aspx.cs" Inherits="Nave_Project2.Pages.MyCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/my-cart.css" rel="stylesheet" />
    <style type="text/css">
        .btn {
            text-decoration:none;
            text-align:center;
            background-color:aqua;
            border:1px solid aqua;

            padding:15px;
            font-size:1.5rem;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 runat="server" class="header" id="header"></h1>
    <div class="container" id="CartDiv" runat="server"></div>
    <div class="footer" id="ToPay" runat="server"></div>
    <div class="bottom">
        <form runat="server">
            <asp:Button ID="PayButton" runat="server" Text="שלם" OnClick="PayButton_Click" CssClass="btn" />
            <asp:Button ID="ClearCartButton" runat="server" Text="נקה את העגלה" CssClass="btn" OnClick="ClearCartButton_Click" />
        </form> 
    </div>
    <script src="../../Scripts/my-cart.js"></script>
</asp:Content>