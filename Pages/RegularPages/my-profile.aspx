<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="my-profile.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.my_profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>הפרופיל שלי</title>
    <style type="text/css">
        * {
            margin:0;
            padding:0;
        }
        body {
            background-color:slategray;
        }
        .title {
            color:black;
            text-align:center;
            font-size:40px;
        }
        .ProfileDetailsContainer {
            border:1px solid black;
            width:35%;
            height:35%;
            padding:20px 0 20px 20px;
        }
        .ProfileDetailsP {
            font-size:30px;
        }
        .values {
            font-size:25px;
        }
        #showPasswordImg {
            width:70px;
            height:70px;
            display:inline;
        }
    </style>
</head>
<body dir="rtl">
    <div class="fullscreen">
        <h1 class="title">הפרופיל שלי</h1>
        <br />
        <div class="ProfileDetailsContainer">
            <div class="ProfileDetails">
                <p class="ProfileDetailsP">הפרטים שלי</p>
                <br /> <br />
                <div>
                    <p class="ProfileDetailsP">שם משתמש</p>
                    <p id="username" class="values" runat="server"></p>
                </div>
                
                <div>
                    <p class="ProfileDetailsP">סיסמה</p>
                    <p id="password" class="values" runat="server"></p>
                </div>
                <div>
                    <p class="ProfileDetailsP">שם פרטי</p>
                    <p id="name" class="values" runat="server"></p>
                </div>
                <div>
                    <p class="ProfileDetailsP">שם משפחה</p>
                    <p id="lastname" class="values" runat="server"></p>
                </div>
                <div>
                    <p class="ProfileDetailsP">כתובת</p>
                    <p class="values" runat="server" id="address"></p>
                </div>
                <div>
                    <p class="ProfileDetailsP">מגדר</p>
                    <p class="values" id="gender" runat="server"></p>
                </div>
                <div>
                    <p class="ProfileDetailsP">כתובת דואל</p>
                    <p class="values" id="email" runat="server"></p>
                </div>
                <div>
                    <p class="ProfileDetailsP">תאריך לידה</p>
                    <p class="values" id="birthday" runat="server"></p>
                </div>
            </div>
        </div>
    </div>
</body>
</html>