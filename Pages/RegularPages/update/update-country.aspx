<%@ Page Title="עדכן מדינה" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="update-country.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.update.update_country_new" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../../Styles/update-pages-style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>עדכון מדינה</h1>
    <div class="container">
        <form runat="server" method="post" action="" onsubmit="return isValid()">
            <div>
                <label for="countryName">שם מדינה לעדכון</label>
                <input type="text" id="countryName" name="countryName" />
                <div id="countryNameError" class="errors"></div>
            </div>
            <div>
                <label for="branchesNum">מספר סניפים</label>
                <input type="number" id="branchesNum" name="branchesNum" />
                <div id="branchesNumError" class="errors"></div>
            </div>
            <div id="badFeedback" runat="server" class="errors"></div>
            <div id="goodFeedback" runat="server"></div>
            <div>
                <input type="reset" value="נקה" />
                <asp:Button ID="Update_Button" runat="server" Text="עדכן" OnClick="Update_Button_Click" />
                <asp:Button ID="Create_Button" runat="server" Text="צור" OnClick="Create_Button_Click" />
                <asp:Button ID="Delete_Button" runat="server" Text="מחק" OnClick="Delete_Button_Click" />
            </div>
        </form>
    </div>
    <script src="../../../Scripts/update-validation/update-country.js"></script>
</asp:Content>