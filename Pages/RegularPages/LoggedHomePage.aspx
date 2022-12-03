<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage2.Master" AutoEventWireup="true" CodeBehind="LoggedHomePage.aspx.cs" Inherits="Nave_Project2.Pages.LoggedHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/LoggedHomePageMenu.css" rel="stylesheet" />
    <link href="../../Styles/NavbarStyle1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 class="title">דף הבית</h1>
        <div runat="server" id="WelcomeDiv"></div>
        
        <div class="dropdown2">
          
            <div class="dropbtn">
                <div class="bars bar1"></div>
                <div class="bars bar2"></div>
                <div class="bars bar3"></div>
            </div>
            <div class="dropdown2-content">
                <a href="my-profile.aspx" target="_blank">הפרופיל שלי</a>
                <a href="my-purchases.aspx" taret="_blank">הרכישות שלי</a>
                <a href="TODO.aspx">שינוי פרטים</a>
            </div>
        </div>
        <br />
        <br />
        <a href="order.aspx">להזמנת מוצרים אונליין</a>
    </div>
</asp:Content>