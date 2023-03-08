<%@ Page Title="דף הבית" Language="C#" MasterPageFile="~/Master Pages/Master1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Nave_Project2.Pages.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center; font-size:50px;">דף הבית</h1>
    <br />
    <br />
    <div>
        <h2 class="moving-header">ברוכים הבאים לאתר הקניות הבא של ישראל</h2>
        <br /><br /><br /><br />
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
            <h1 style="color:darkgoldenrod;font-size:60px;">קניות שעושות לך טוב...</h1>
        </center>
    </div>
</asp:Content>