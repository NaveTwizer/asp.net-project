<%@ Page Title="ספקים" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="providers.aspx.cs" Inherits="Nave_Project2.Pages.data.providers" %>
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
    <form runat="server" action="providers.aspx" method="post">
        <input type="text" placeholder="חפש ספק לפי שם" name="provider" />
        <asp:Button CssClass="SearchButton" runat="server" ID="SearchProviderByName" OnClick="SearchProviderByName_Click" Text="חפש" />
        <br /><br /><br />
        <a href="/Pages/data/update/update-provider.aspx" class="btn btn-large">לעדכון ספקים לחץ כאן</a>
    </form>
</asp:Content>