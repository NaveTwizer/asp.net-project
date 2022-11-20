<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="manufactures.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Data.manufactures" %>
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
    <h1>יצרנים</h1>
    <div runat="server" id="TableDiv"></div>
    <form runat="server" action="" method="post">
        <label>הקלד חיפוש</label>
        <input type="text" id="searchQuery" name="searchQuery" />
        <label>חפש לפי</label>
        <select id="search" name="search">
            <option value="name">שם יצרן</option>
            <option value="country">מדינת יצרן</option>
        </select>
        <div></div>
        <asp:Button ID="Search" Text="חפש" runat="server" CssClass="button"/>
    </form>
    <p style="font-size:40px">
        לעדכון יצרנים,
        <a href="../update/update-manufactor.aspx">לחץ כאן</a>
    </p>
</asp:Content>