<%@ Page Title="התחברות" Language="C#" MasterPageFile="~/Master Pages/Master1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Nave_Project2.Pages.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/Styles/login.css" rel="stylesheet" />
    <style type="text/css">
        body {
            background:url(/images/login.jpg) no-repeat;
            background-size:cover;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-div">
            <form runat="server" id="form1" onsubmit="return onSubmit()" method="post" action="login.aspx">
                <label>שם משתמש</label>
                <div>
                    <input type="text" name="username" id="username"/>
                    <span id="username-error-span" style="display:none;">⚠</span>
                    <div class="div-error" id="username-error-div"></div>
                </div>
                <br />
                <label>סיסמה</label>
                <div>
                    <input type="password" name="pswd" id="pswd" size="25"/>
                    <span id="password-error-span" style="display:none;">⚠</span>
                    <div class="div-error" id="password-error-div"></div>
                </div>
                <br />
                <div>
                    <a href="/Pages/profile/forgot-password.aspx">שכחתי סיסמה</a>
                </div>
                <input type="submit" value="היכנס" />
                <input type="reset" value="נקה" />
                <div id="BadFeedback" runat="server" style="color:red;"></div>
                <div id="GoodFeedback" runat="server" style="color:green;"></div>
            </form>
        </div>
    </div>
    <script src="../../Scripts/login.js"></script>
</asp:Content>