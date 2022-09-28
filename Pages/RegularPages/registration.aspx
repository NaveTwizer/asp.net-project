<%@ Page Title="הרשמה" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage2.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../Styles/register.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../../Scripts/registration.js" type="text/javascript"></script>
    <div class="fullscreen" dir="rtl">
        <h1 class="title">הרשמה</h1>
        <button id="btn1">Fucking retarded SHIT</button>
        <div class="form-div">
            <form method="post" action="" id="form1" onsubmit="alert('fucking shit')">
                <table>
                    <tr>
                        <td>
                            <label for="username">שם משתמש</label>
                        </td>
                        <td>
                            <input id="username" name="username" type="text" />
                        </td>
                        <td class="error-td" id="username-error">

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="pswd">סיסמה</label>
                        </td>
                        <td>
                            <input id="pswd" name="pswd" type="password"  class="inputs"/>
                        </td>
                        <td class="error-td" id="password-error">

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="name">שם פרטי</label>
                        </td>
                        <td>
                            <input id="name" name="name" type="text" />
                        </td>
                        <td class="error-td" id="name-error">

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="lastname">שם משפחה</label>
                        </td>
                        <td>
                            <input id="lastname" name="lastname" type="text" />
                        </td>
                        <td class="error-td" id="lastname-error">

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="address">כתובת</label>
                        </td>
                        <td>
                            <input type="text" id="address" name="address" />
                        </td>
                        <td class="error-td" id="address-error">

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>מין</label>
                        </td>
                        <td>
                            <label>
                                זכר
                                <input type="radio" id="male" name="gender" />
                            </label>
                            <label>
                                נקבה
                                <input type="radio" id="female" name="gender" />
                            </label>
                            <label>
                                אחר
                                <input type="radio" onclick="this.checked = false;" />
                            </label>
                        </td>
                        <td class="error-td" id="gender-error">

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="mail">כתובת מייל</label>
                        </td>
                        <td>
                            <input type="email" placeholder="someone@gmail.com" id="email" name="email" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="birthday">תאריך לידה</label>
                        </td>
                        <td>
                            <input type="date" name="birthday" id="birthday"  />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="reset" value="נקה" />
                            <input type="submit" id="submit" name="submit" value="הירשם" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>כבר רשום? <a href="login.aspx">התחבר</a></p>
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>
</asp:Content>