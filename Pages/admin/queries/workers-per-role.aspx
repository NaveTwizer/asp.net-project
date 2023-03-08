<%@ Page Title="סך עובדים לפי תפקיד" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="workers-per-role.aspx.cs" Inherits="Nave_Project2.Pages.admin.queries.workers_per_role" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/queries.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>סך עובדים לפי תפקיד</h1>
    <div id="TableDiv" runat="server"></div>
</asp:Content>