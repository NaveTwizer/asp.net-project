<%@ Page Title="סטטיסטיקה" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="statistics.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Data.statistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>סטטיסטיקה</h1>
    <form runat="server">
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    </form>
</asp:Content>