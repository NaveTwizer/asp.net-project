<%@ Page Title="הקניה הושלמה בהצלחה" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="purchase-complete.aspx.cs" Inherits="Nave_Project2.Pages.shop.purchase_complete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            background-color:gray;
        }
        .div1 {
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="div1">
        <h1>הקנייה הושלמה בהצלחה</h1>
        <img src="../../images/success.gif" />
    </div>
</asp:Content>