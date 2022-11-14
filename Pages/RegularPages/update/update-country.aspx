<%@ Page Title="עדכון מדינה" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="update-country.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.update.update_country" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <style type="text/css">
        form {
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            border:1px solid black;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>עדכון מדינה</h1>
    <div class="container">
        <form runat="server" method="post" action="" onsubmit="return isValid()">
            <div>
                <label for="countryName">שם מדינה לעדכון</label>
                <input type="text" id="countryName" name="countryName" />
                <div id="countryNumError" class="errors"></div>
            </div>
            <div>
                <label for="branchesNum">מספר סניפים</label>
                <input type="number" id="branchesNum" name="branchesNum" />
                <div id="branchesNumError" class="errors"></div>
            </div>
            <div id="feedback" runat="server" class="feedback"></div>
            <div>
                <input type="reset" value="נקה" />
                <input type="submit" value="עדכן" runat="server" />
                <asp:Button ID="Create_Button" runat="server" Text="צור חדש" OnClick="Create_Button_Click" />
            </div>
        </form>
    </div>
    <script src="../../../Scripts/update-country.js"></script>
</asp:Content>