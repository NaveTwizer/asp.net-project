<%@ Page Title="התחברות" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../Styles/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="title">כניסה</h1>
    <div class="fullscreen">
        <div class="form-div">
            <form action="" method="post" runat="server">
                <label for="username">שם משתמש</label>
                <br />
                <input type="text" id="username" name="username" size="25" height="200"/>
                <div class="div-error" id="username-error-div">retard</div>

                <label for="password">סיסמה</label>
                <br />
                <input type="password" name="pswd" id="pswd" size="25"/>
                <div class="div-error" id="password-error-div"></div>
                
                <br /> <br />
                <button class="button" id="btn" type="submit"><span>התחבר</span></button>
            </form>
        </div>
    </div>
</asp:Content>