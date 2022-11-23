<%@ Page Title="ספקים" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="suppliers.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Data.suppliers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../../Styles/DataFilesStyle.css" rel="stylesheet" />
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
    <h1>ספקים</h1>
    <div id="TableDiv" runat="server"></div>

    <form runat="server" method="post" action="">
        <label>הקלד חיפוש</label>
        <input type="text" id="SearchQuery" name="SearchQuery" />
        <label>חפש לפי</label>
        <select name="search">
            <option value="code">קוד ספק</option>
            <option value="name">שם ספק</option>
            <option value="address">כתובת ספק</option>
            <option value="phone">מספר טלפון</option>
            <option value="mail">מייל ספק</option>
        </select>
        <asp:Button Text="חפש" CssClass="button" runat="server" />
    </form>
</asp:Content>