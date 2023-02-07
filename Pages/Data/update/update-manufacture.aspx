<%@ Page Title="עדכן יצרן" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="update-manufacture.aspx.cs" Inherits="Nave_Project2.Pages.data.update.update_manufacture" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/UpdatePagesStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" method="post" action="update-manufacture.aspx" onsubmit="return isValid();">
        <div>
            <label for="name">שם יצרן</label>
            <input id="name" name="name" type="text" />
            <div id="nameError" class="errors"></div>
        </div>
        <div>
            <label for="name2">אימות שם יצרן</label>
            <input id="name2" name="name2" type="text" />
            <div id="name2Error" class="errors"></div>
        </div>
        <div>
            <label for="country">שם מדינה</label>
            <input id="country" name="country" type="text" />
            <div id="countryError" class="errors"></div>
        </div>
        <div id="feedback" runat="server"></div>
        <br />
        <div>
            <input type="reset" class="actionButtons" value="נקה" />
            <asp:Button runat="server" ID="CreateButton" Text="צור" CssClass="actionButtons" OnClick="CreateButton_Click" />
            <asp:Button runat="server" ID="UpdateButton" Text="עדכן" CssClass="actionButtons" OnClick="UpdateButton_Click" />
            <asp:Button runat="server" ID="DeleteButton" Text="מחק" CssClass="actionButtons" OnClick="DeleteButton_Click"/>
        </div>
    </form>
    <script src="../../../Scripts/update/update-manu.js"></script>
</asp:Content>