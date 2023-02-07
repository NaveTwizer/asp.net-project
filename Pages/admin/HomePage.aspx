<%@ Page Title="דף הבית למנהל" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Nave_Project2.Pages.admin.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            direction:rtl;
            background:url(/images/admin.jpg) no-repeat;
            background-size:cover;
        } 
        .circle-wrapper {
            width:150px;
            text-align:center;
        }
        .circle {
            width: 120px;
            line-height: 120px;
            border-radius: 50%;
            text-align: center;
            font-size: 32px;
            border: 3px solid #000;
        }
        .title {
            text-align:center;
            color:white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="title">דף הבית למנהל</h1>
</asp:Content>