<%@ Page Title="מוצרים" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.DataTables.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <style type="text/css">
        table {
            margin-left: auto;
            margin-right: auto;
            text-align:center;
            border-collapse:collapse;
        }
        table td {
            border:1px solid black;
            padding:4px;
        }
        input[type="text"] {
            width:400px;
            height:40px;
            font-size:25px;
        }
        label {
            font-size:20px;
        }
        .button {
            width:150px;
            height:40px;
            font-size:25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>מוצרים</h1>
    <div id="TableDiv" runat="server"></div>
    <form runat="server" method="post">
        <label>חפש</label>
        <input type="text" id="SearchQuery" name="SearchQuery" />
        <label>חפש לפי</label>
        <select name="search">
            <option value="code">קוד מוצר</option>
            <option value="name">שם מוצר</option>
            <option value="dep">מחלקת מוצר</option>
            <option value="productor">שם יצרן</option>
            <option value="ProviderCode">קוד יצרן</option>
            <option value="description">תיאור מוצר</option>
            <option value="price">מחיר</option>
            <option value="amount">כמות במלאי</option>
        </select>
        <asp:Button ID="Search" Text="חפש" runat="server" CssClass="button"/>
        <asp:Button Text="הראה טבלה מלאה" runat="server" CssClass="button" OnClick="Unnamed_Click" />
    </form>
</asp:Content>