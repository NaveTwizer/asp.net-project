<%@ Page Title="הוסף הנחות יומיות" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="add-discounts.aspx.cs" Inherits="Nave_Project2.Pages.admin.add_discounts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            background-color:gray;
        }
        form {
            border:1px solid black;
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            text-align:center;
            padding:0 10% 10% 10%;
        }
        label, select {
            font-size:2rem;
            padding:10px;
            text-align:center;
        }
        input {
            width:100%;
            padding:10px 0 10px 0;
        }
        input::placeholder {
            text-align:right;
        }
        .confirm-button {
            background-color:aqua;
            cursor:pointer;
            text-shadow:none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" method="post" action="add-discounts.aspx">
        <label>המוצר הראשון</label><br />
        <select id="product1" runat="server"></select>
        <br />
        <input placeholder="הקלד אחוז הנחה" name="discount1" />
        <br />

        <label>המוצר השני</label><br />
        <select id="product2" runat="server"></select><br />
        <input placeholder="הקלד אחוז הנחה" name="discount2" />

        <br />
        <label>המוצר השלישי</label><br />
        <select id="product3" runat="server"></select>
        <br />
        <input name="discount3" placeholder="הקלד אחוז הנחה" />

        <br />
        <asp:Button runat="server" ID="ConfirmButton" Text="הוסף הנחות" OnClick="ConfirmButton_Click" CssClass="confirm-button" />
        <div runat="server" id="feedback"></div>
    </form>
</asp:Content>