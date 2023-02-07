<%@ Page Title="טבלת סניפים" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="branches.aspx.cs" Inherits="Nave_Project2.Pages.data.branches" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            direction:rtl;
            background-color:gray;
        }
        table {
            text-align:center;
            border-collapse:collapse;
        }
        td {
            padding:5px;
            border:1px solid black;
        }
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
    <p id="BranchesDiv" runat="server"></p>
    <br /><br />
    <a href="/Pages/data/update/update-branch.aspx" class="btn btn-large">לעדכון סניפים, לחץ כאן</a>
</asp:Content>