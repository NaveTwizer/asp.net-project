﻿<%@ Page Title="שינוי סיסמה" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="change-password.aspx.cs" Inherits="Nave_Project2.Pages.profile.change_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            background-color: #0085e2;
            direction: rtl;
        }
        form {
            background-color:white;
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            padding:50px;
            width:25%;
        }
        .title {
            font-weight: bold;
            color: white;
            text-align: center;
            font-size: 55px;
        }
        .errors {
            color: red;
            text-align: right;
            font-size: 25px;
        }
        label {
            font-size:25px;
        }
        .inputs {
            width:100%;
            border:1px solid gray;
            height:2.5rem;
            font-size:1rem;
        }
        .button {
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
            background-color: #0087e6;
            color: white;
            border: none;
            padding: 15px 10px 15px 10px;
            font-size: 20px;
            border-radius:10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    <h1 class="title">שנה סיסמה</h1>
    <form runat="server" method="post" action="change-password.aspx" onsubmit="return isValid();">
        <div>
            <label>סיסמה נוכחית*</label>
            <br />
            <input class="inputs" id="CurrentPassword" name="CurrentPassword" type="password" />
            <div id="CurrentPasswordError" class="errors"></div>
        </div>
        <div>
            <label>סיסמה חדשה*</label>
            <br />
            <input class="inputs" id="NewPassword" name="NewPassword" type="password" />
            <div id="NewPasswordError" class="errors"></div>
        </div>
        <div>
            <label>אימות סיסמה חדשה*</label>
            <br />
            <input class="inputs" id="NewPassword2" name="NewPassword2" type="password" />
            <div id="NewPassword2Error" class="errors"></div>
        </div>
        <br />
        <div id="GoodFeedback" runat="server"></div>
        <div id="BadFeedback" runat="server"></div>
        <asp:Button runat="server" ID="ChangePasswordButton" CssClass="button" OnClick="ChangePasswordButton_Click" Text="שנה סיסמה" />
    </form>
    <script type="text/javascript">
        const password1 = document.getElementById('CurrentPassword');
        const password2 = document.getElementById('NewPassword');
        const password3 = document.getElementById('NewPassword2');

        const password1Error = document.getElementById('CurrentPasswordError');
        const password2Error = document.getElementById('NewPasswordError');
        const password3Error = document.getElementById('NewPassword2Error');
        const isValid = () => {
            resetErrorMessages();
            let b1 = isValidPassword1();
            let b2 = isValidPassword2();
            let b3 = isValidPassword3();
            return (b1 && b2 && b3);
        }
        const isValidPassword1 = () => {
            let p1 = password1.value;
            if (!p1) {
                password1Error.innerText = "הכנס סיסמה נוכחית";
                return false;
            }
            return true;
        }
        const isValidPassword2 = () => {
            let p2 = password2.value;
            if (!p2) {
                password2Error.innerText = "הכנס סיסמה חדשה";
                return false;
            }
            return true;
        }
        const isValidPassword3 = () => {
            let p3 = password3.value;
            if (!p3) {
                password3Error.innerText = "הכנס סיסמה חדשה מחדש";
                return false;
            }
            let p2 = password2.value;
            if (p2 !== p3) {
                password2Error.innerText = "הסיסמאות אינן תואמות";
                password3Error.innerText = "הסיסמאות אינן תואמות";
                return false;
            }
            return true;
        }
        const resetErrorMessages = () => {
            password1Error.innerText = "";
            password2Error.innerText = "";
            password3Error.innerText = "";
        }
    </script>
</asp:Content>