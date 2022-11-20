<%@ Page Title="מדינות" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="countries.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Data.countries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <style type="text/css">
        table {
            margin-left: auto;
            margin-right: auto;
            text-align:center;
            border-collapse:collapse;
            font-size:120%;
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
    <h1>מדינות</h1>
    <div runat="server" id="TableDiv"></div>
    <form runat="server">
        <label>הקלד חיפוש</label>
        <input type="text" id="searchQuery" name="searchQuery" />
        <label>חפש לפי</label>
        <select id="search" name="search">
            <option value="country">שם מדינה</option>
            <option value="branchesNum">מספר סניפים</option>
        </select>
        <div></div>
        <asp:Button ID="Search" Text="חפש" runat="server" CssClass="button"/>
    </form>
    <p style="font-size:40px">
        לעדכון מדינות,
        <a href="../update/update-country.aspx">לחץ כאן</a>
    </p>
</asp:Content>