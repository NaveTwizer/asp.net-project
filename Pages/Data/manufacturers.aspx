<%@ Page Title="טבלת יצרנים" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="manufacturers.aspx.cs" Inherits="Nave_Project2.Pages.data.manufacturers" %>
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
    <form action="manufacturers.aspx" method="post" runat="server">
        <input type="text" name="manu" id="manu" placeholder="חפש יצרן לפי שם" />
        <asp:Button runat="server" ID="SearchManuByName" OnClick="SearchManuByName_Click" Text="חפש" />
        <br /><br /><br />
        <a class="btn btn-large" href="/Pages/data/update/update-manufacture.aspx">לעדכון יצרנים לחץ כאן</a>
    </form>
</asp:Content>