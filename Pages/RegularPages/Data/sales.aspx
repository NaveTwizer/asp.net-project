<%@ Page Title="מכירות" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="sales.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Data.sales" %>
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
    <h1>מכירות</h1>
    <div runat="server" id="TableDiv"></div>

    <form runat="server" method="post" action="">
        <label>הקלד חיפוש</label>
        <input type="text" id="SearchQuery" name="SearchQuery" />
        <label>חפש לפי</label>
        <select name="search">
            <option value="code">קוד מכירה</option>
            <option value="date">תאריך מכירה</option>
            <option value="BranchCode">קוד סניפים</option>
            <option value="WorkerId">תז עובד</option>
        </select>
        <asp:Button Text="חפש" runat="server" CssClass="button"/>
    </form>
</asp:Content>