<%@ Page Title="כניסה" Language="C#" MasterPageFile="~/Master Pages/Master1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Nave_Project2.Pages.auth.login2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fullscreen" style="height:91.1vh;">
        <div class="form-container">
            <h1 class="form-title">התחבר לחשבון שלך</h1>
            <br /><br />
            <form runat="server" action="login.aspx" method="post">
                <div class="error" id="error" runat="server">
                    הפרטים אינם נכונים
                    <br />
                </div>
                <div>
                    <input type="text" name="username" id="username" placeholder="שם משתמש" class="inputs" />
                </div>
                <br />
                <div>
                    <input type="password" name="pswd" id="pswd" placeholder="סיסמה" class="inputs" />
                </div>
                <br />
                <div class="forgot-password-wrapper">
                    <a href="forgot-password.aspx" class="forgot-password">שכחת סיסמה?</a>
                </div>
                <br />
                <div class="submit-wrapper">
                    <asp:Button ID="SubmitButton" runat="server" Text="היכנס" OnClick="SubmitButton_Click" CssClass="btn" />
                </div>
            </form>
        </div>
    </div>
</asp:Content>