<%@ Page Title="דף הבית" Language="C#" MasterPageFile="~/Master Pages/Master1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Nave_Project2.Pages.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        * {
            margin:0;
            box-sizing:border-box;
            font-family:sans-serif;
        }
        .NewsDiv {
            width:100%;
            display:flex;
            justify-content:space-evenly;
            border:2px solid black;
        }
        .moving-headers {
            display:inline;
            float:right;
            padding:10px;
            animation:move-rtl 10s linear infinite;
        }
        @keyframes move-rtl {
            0% { transform:translateX(0); }
            100% { transform:translateX(-600%); }
        }
        body {
            background:url(/images/homepage.jpg) no-repeat;
            background-size:cover;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center; font-size:50px;">דף הבית</h1>

    <h1 style="float:right; font-size:35px;">ההנחות של היום</h1>
    <div class="NewsDiv">
        <h1 class="moving-headers" id="discount1" runat="server"></h1>
        <h1 class="moving-headers" id="discount2" runat="server"></h1>
        <h1 class="moving-headers" id="discount3" runat="server"></h1>
    </div>
</asp:Content>