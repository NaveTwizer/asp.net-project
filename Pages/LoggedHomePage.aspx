<%@ Page Title="דף הבית" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="LoggedHomePage.aspx.cs" Inherits="Nave_Project2.Pages.LoggedHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/Styles/LoggedHomePage.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--
        להתכונן ליום סיירות
        https://www.mitgaisim.idf.il/%D7%9B%D7%AA%D7%91%D7%95%D7%AA/%D7%A8%D7%90%D7%A9%D7%99/%D7%98%D7%99%D7%A4%D7%99%D7%9D-%D7%90%D7%95%D7%A8%D7%97-%D7%97%D7%99%D7%99%D7%9D-%D7%95%D7%A1%D7%9C%D7%A0%D7%92/%D7%94%D7%9B%D7%9F-%D7%90%D7%AA-%D7%92%D7%95%D7%A4%D7%9A-%D7%9C%D7%99%D7%95%D7%9D-%D7%94%D7%A1%D7%99%D7%99%D7%A8%D7%95%D7%AA/#/
    --%>
    <div>
        <h1 id="title" runat="server"></h1>
        <div class="dropdown2">
            <div class="dropbtn">
                <%--<div class="bars bar1"></div>
                <div class="bars bar2"></div>
                <div class="bars bar3"></div>--%>
                <img id="pfp" runat="server" height="80" width="80" style="border-radius:40px;" />
            </div>
            <div class="dropdown2-content">
                <a href="/Pages/profiles/my.aspx">הפרופיל שלי</a>
                <a href="/Pages/profiles/my-purchases.aspx">הרכישות שלי</a>
                <a href="/Pages/profiles/update-profile.aspx">שינוי פרטים</a>
                <a href="/Pages/shop/order.aspx">הזמן מוצרים</a>
            </div>
        </div>
        <br /><br />
        <h1 style="float:right; font-size:35px;">ההנחות של היום</h1>
        <div class="NewsDiv">
            <h1 class="moving-headers" id="discount1" runat="server"></h1>
            <h1 class="moving-headers" id="discount2" runat="server"></h1>
            <h1 class="moving-headers" id="discount3" runat="server"></h1>
    </div>
    </div>
    <a href="shop/product.aspx?ProductId=18">click here</a>
</asp:Content>