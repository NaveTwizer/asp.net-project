<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage2.Master" AutoEventWireup="true" CodeBehind="LoggedHomePage.aspx.cs" Inherits="Nave_Project2.Pages.LoggedHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/NavbarStyle1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 class="title">דף הבית</h1>
        <div runat="server" id="WelcomeDiv"></div>
        <div class="my-profile">
            <a href="my-profile.aspx" target="_blank">
                <img src="../../images/profile.png" 
                    alt="הפרופיל שלי" height="70" width="70" title="הפרופיל שלי" />
            </a>
        </div>
    </div>
</asp:Content>