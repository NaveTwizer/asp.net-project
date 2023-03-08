<%@ Page Title="הרכישות שלי" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="my-purchases.aspx.cs" Inherits="Nave_Project2.Pages.my_purchases" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            direction:rtl;
            font-size:40px;
            background-color:gray;
        }
        table {
            border-collapse:collapse;
            text-align:center;
        }
        td {
            border:1px solid black;
            padding-left:20px;
        }
        a {
            text-decoration:none;
            color:blue;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div id="TableDiv" runat="server"></div>
</asp:Content>