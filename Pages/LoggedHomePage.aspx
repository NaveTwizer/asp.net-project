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
        <div style="margin-left:auto; margin-right:0;">
            <br />
            <h1 id="title" runat="server"></h1>
            <div class="dropdown2">
                <div class="dropbtn">
                    <img id="pfp" runat="server" height="100" width="100" style="border-radius:40px;" />
                </div>
                <div class="dropdown2-content">
                    <a href="/Pages/profile/my-profile">הפרופיל שלי</a>
                    <a href="/Pages/shop/my-purchases.aspx">הרכישות שלי</a>
                    <a href="/Pages/profile/update-profile.aspx">שינוי פרטים</a>
                    <a href="/Pages/shop/order">הזמן מוצרים</a>
                    <a href="/Pages/shop/Invoices/search-invoice.aspx">חפש קבלה</a>
                    <a href="/Pages/auth/logout.aspx"">התנתק</a>
                </div>
            </div>
        </div>

        <br /><br />
        <div>
            <h2 class="moving-header">ברוכים הבאים לאתר הקניות הבא של ישראל</h2>
            <center>
                <div class="changing-images-div">
                    <div id="img1" class="changing-images"></div>
                    <div id="img2" class="changing-images"></div>
                    <div id="img3" class="changing-images"></div>
                    <div id="img4" class="changing-images"></div>
                </div>
            </center>
            <br />
            <center>
                <h2 style="color:blue;font-size:45px;">לקנות מכל מקום, בשיא הנוחות והקלילות</h2>
                <br />
                <h1 style="color:yellow; font-size:60px;">קניות שעושות לך טוב...</h1>
            </center>
        </div>
    </div>
</asp:Content>