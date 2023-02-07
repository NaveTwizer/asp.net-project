<%@ Page Title="טבלת מוצרים" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="Nave_Project2.Pages.data.products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/TablesStyle.css" rel="stylesheet" />
    <style type="text/css">
        .btn {
            text-decoration:none;
            text-align:center;
            background-color:aqua;
            border:1px solid aqua;
        }
        .btn-large {
            padding:15px 40px 15px 40px;
            font-size:1rem;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="TableDiv" runat="server"></div>
    <form runat="server" method="post" action="products.aspx">
        <input type="text" name="product" placeholder="חפש מוצר לפי שם" />
        <asp:Button runat="server" ID="SearchProductByName" OnClick="SearchProductByName_Click" Text="חפש" />

        <br /><br /><br />
        <a href="/Pages/data/update/update-products.aspx" class="btn btn-large">לעדכון מוצרים לחץ כאן</a>
    </form>
</asp:Content>