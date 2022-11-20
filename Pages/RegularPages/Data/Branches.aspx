<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="Branches.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Data.Branches" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../../Styles/DataFilesStyle.css" rel="stylesheet" />
    <style type="text/css">
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
    <h1>סניפים</h1>
    <div id="TableDiv" runat="server"></div>
    <form runat="server">
        <label>הקלד חיפוש</label>
        <input type="text" id="searchQuery" name="searchQuery" />
        <label>חפש לפי</label>
        <select id="search" name="search">
            <option value="code">קוד סניף</option>
            <option value="name">שם סניף</option>
            <option value="address">כתובת סניף</option>
            <option value="phone">מספר טלפון</option>
        </select>
        <div></div>
        <asp:Button ID="Search" Text="חפש" OnClick="Search_Click" runat="server" CssClass="button" />
    </form>
    <p style="font-size:40px;">לעדכון סניפים, 
        <a href="../update/update-branch.aspx" target="_blank">לחץ כאן</a>
    </p>
</asp:Content>