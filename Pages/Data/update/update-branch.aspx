<%@ Page Title="עדכן סניף" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="update-branch.aspx.cs" Inherits="Nave_Project2.Pages.data.update.update_branch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/UpdatePagesStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <form runat="server" method="post" action="update-branch.aspx" id="form1" onsubmit="return isAllValid()">
            <div>
                <label for="name">קוד סניף</label>
                <input type="text" name="code" id="code" />
                <div id="codeError" class="errors" runat="server"></div>
            </div>
            <div>
                <label>אימות קוד סניף</label>
                <input type="text" id="code2" name="code2" />
                <div id="code2Error" class="errors" runat="server"></div>
            </div>
            <div>
                <label>שם סניף</label>
                <input type="text" id="name" name="name" />
                <div id="nameError" class="errors" runat="server"></div>
            </div>
            <div>
                <label for="address">כתובת סניף</label>
                <input id="address" type="text" name="address" />
                <div id="addressError" class="errors" runat="server"></div>
            </div>
            <div>
                <label for="phone">מספר טלפון</label>
                <input id="phone" name="phone" type="text" />
                <div id="phoneError" class="errors" runat="server"></div>
            </div>
            <div id="feedback" runat="server"></div>
            <br />
            <div>
                <input type="reset" class="actionButtons" value="נקה" />
                <asp:Button runat="server" ID="CreateButton" Text="צור" CssClass="actionButtons" OnClick="CreateButton_Click" />
                <asp:Button runat="server" ID="UpdateButton" Text="עדכן" CssClass="actionButtons" OnClick="UpdateButton_Click" />
                <asp:Button runat="server" ID="DeleteButton" Text="מחק" CssClass="actionButtons" OnClick="DeleteButton_Click" />
            </div>
        </form>
    </div>
    <script src="../../../Scripts/update/update-branch.js"></script>
</asp:Content>
