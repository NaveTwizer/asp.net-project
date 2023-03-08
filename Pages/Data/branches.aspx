<%@ Page Title="טבלת סניפים" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="branches.aspx.cs" Inherits="Nave_Project2.Pages.data.branches" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/branches.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p id="BranchesDiv" runat="server"></p>
    <br /><br />
    <a href="/Pages/data/update/update-branch.aspx" class="btn btn-large">לעדכון סניפים, לחץ כאן</a>
</asp:Content>