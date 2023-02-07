<%@ Page Title="עדכן ספק" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="update-provider.aspx.cs" Inherits="Nave_Project2.Pages.data.update.update_provider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/UpdatePagesStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" action="update-provider.aspx" method="post">
        <div>
            <label>קוד ספק</label>
            <input id="code" name="code" type="text" />
        </div>
        <div>
            <label>שם ספק</label>
            <input type="text" id="name" name="name" />
            <div id="nameError" class="errors"></div>
        </div>
        <div>
            <label>כתובת ספק</label>
            <input type="text" id="addr" name="addr" />
            <div id="addrError" class="errors"></div>
        </div>
        <div>
            <label>טלפון</label>
            <input type="text" id="phone" name="phone" />
            <div id="phoneError" class="errors"></div>
        </div>
        <div>
            <label>כתובת מייל</label>
            <input type="text" name="email" id="email" />
            <div id="emailError" class="errors"></div>
        </div>
        <div id="feedback" runat="server"></div>

        <div>
            <input type="reset" value="נקה" class="actionButtons" />
            <asp:Button runat="server" ID="CreateButton" Text="צור" CssClass="actionButtons" OnClick="CreateButton_Click" />
            <asp:Button runat="server" ID="UpdateButton" Text="עדכן" CssClass="actionButtons" OnClick="UpdateButton_Click" />
            <asp:Button runat="server" ID="DeleteButton" Text="מחק" CssClass="actionButtons" OnClick="DeleteButton_Click" />
        </div>
    </form>
</asp:Content>