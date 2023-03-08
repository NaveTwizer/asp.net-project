<%@ Page Title="שינוי סיסמה" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="change-password.aspx.cs" Inherits="Nave_Project2.Pages.profile.change_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/change-password.css" rel="stylesheet" />
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