<%@ Page Title="טבלת עובדים" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="workers.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Data.workers" %>
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
    <h1>עובדים</h1>
    <div id="TableDiv" runat="server"></div>
    <form action="" method="post" runat="server">
        <label>הקלד חיפוש</label>
        <input type="text" id="SearchQuery" name="SearchQuery" />
        <label>חפש לפי</label>
        <select name="search">
            <option value="id">תז עובד</option>
            <option value="name">שם עובד</option>
            <option value="bdate">תאריך הולדת עובד</option>
            <option value="gender">מין עובד</option>
            <option value="StartDate">תאריך התחלת עבודה</option>
            <option value="address">כתובת עובד</option>
            <option value="phone">מספר טלפון</option>
            <option value="code">קוד סניף</option>
            <option value="role">תפקיד</option>
        </select>
        <asp:Button runat="server" CssClass="button" Text="חפש"/>
    </form>
</asp:Content>