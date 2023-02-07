<%@ Page Title="שכחתי סיסמה" Language="C#" MasterPageFile="~/Master Pages/Master1.Master" AutoEventWireup="true" CodeBehind="forgot-password.aspx.cs" Inherits="Nave_Project2.Pages.profile.forgot_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/forgot-password.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br /><br /><br />
    <h1 class="title">טופס איפוס סיסמה</h1>
    <form runat="server" action="forgot-password.aspx" method="post" onsubmit="return isValid();">
        <div class="inner-div">
            <h1 class="forgot-password-header">שכחתי סיסמה</h1>
            <br />
            <h2 style="color:gray;">שכחת את סיסמתך? אל דאגה! הכנס כתובת מייל ונשלח לך אחת חדשה</h2>
            <br />
            <input id="mail" name="mail" class="mail-input" placeholder="כתובת המייל שלך" />
            <div id="feedback" class="error-div" runat="server"></div>
            <div id="GoodFeedback" runat="server" class="good-feedback"></div>
            <br /><br />
            <asp:Button runat="server" ID="ForgotPasswordButton" Text="שלחו לי סיסמה חדשה" CssClass="forgot-password-button" OnClick="SendPasswordButton_Click" />
        </div>
    </form>
    <script src="../../Scripts/forgot-password.js"></script>
</asp:Content>