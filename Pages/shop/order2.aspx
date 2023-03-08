<%@ Page Title="הזמנת מוצרים" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="order2.aspx.cs" Inherits="Nave_Project2.Pages.shop.order2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            direction:rtl;
        }
        table {
            border-collapse:collapse;
            border:1px solid black;
            text-align:center;
        }
        tr,td {
            border:1px solid black;
            font-size:25px;
        }
        .inputs {
            text-align:center;
            padding:10px 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fullscreen">
        <form runat="server" method="post" action="order2.aspx">
            <div id="OrderSection" runat="server"></div>
        </form>
    </div>
</asp:Content>