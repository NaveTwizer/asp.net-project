<%@ Page Title="עדכן מוצר" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="update-products.aspx.cs" Inherits="Nave_Project2.Pages.data.update.update_products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/UpdatePagesStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" action="update-products.aspx" method="post">
        <div>
            <label>שם מוצר</label>
            <input type="text" name="product" id="product" />
            <div id="nameError" class="errors"></div>
        </div>
        <div>
            <label>מחלקת מוצר</label>
            <select id="dep" runat="server" name="dep"></select>
        </div>
        <div>
            <label>שם יצרן</label>
            <select id="productor" name="productor" runat="server"></select>
        </div>
        <div>
            <label>קוד ספק</label>
            <select id="provider" name="provider" runat="server"></select>
        </div>
        <div>
            <label>תיאור מוצר</label>
            <div></div>
            <textarea id="desc" name="desc" rows="5" cols="50"></textarea>
            <div id="descError" class="errors"></div>
        </div>
        <div>
            <label>מחיר בשקלים</label>
            <input type="text" id="price" name="price" />
            <div id="priceError" class="errors"></div>
        </div>
        <div>
            <label>כמות</label>
            <input type="text" id="amount" name="amount" />
            <div id="amountError" class="errors"></div>
        </div>
        <div>
            <label>תמונת מוצר</label>
            <asp:FileUpload runat="server" ID="FileUpload" AllowMultiple="false" accept="image/*" />
        </div>
        <div id="feedback" runat="server"></div>
        <div>
            <input type="reset" value="נקה" class="actionButtons"/>
            <asp:Button runat="server" ID="CreateButton" Text="צור" OnClick="CreateButton_Click" CssClass="actionButtons" />
            <asp:Button runat="server" ID="UpdateButton" Text="עדכן" OnClick="UpdateButton_Click" CssClass="actionButtons" />
            <asp:Button runat="server" ID="DeleteButton" Text="מחק" OnClick="DeleteButton_Click" CssClass="actionButtons" />
        </div>
    </form>
</asp:Content>