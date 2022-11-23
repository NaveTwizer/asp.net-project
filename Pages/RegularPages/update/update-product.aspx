<%@ Page Title="עדכן מוצר" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="update-product.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.update.update_product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../../Styles/update-pages-style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>עדכן מוצר</h1>
    <form runat="server" method="post" action="">
        <div>
            <label>קוד מוצר</label>
            <input type="text" id="code" name="code" required="required" />
        </div>
        <div>
            <label>שם מוצר</label>
            <input type="text" id="name" name="name" required="required" />
        </div>
        <div>
            <label>מחלקת מוצר</label>
            <input type="text" id="dep" name="dep" required="required" />
            <!-- <select name="dep" id="DepSelect" runat="server"></select> -->
        </div>
        <div>
            <label>שם יצרן</label>
            <input type="text" id="productor" name="productor" required="required" />
        </div>
        <div>
            <label>תיאור מוצר</label>
            <input type="text" id="desc" name="desc" required="required" />
        </div>
        <div>
            <label>קוד ספק</label>
            <input type="text" id="ProviderCode" name="ProviderCode" required="required" />
        </div>
        <div>
            <label>מחיר מוצר</label>
            <input type="text" id="price" name="price" required="required" />
        </div>
        <div>
            <label>כמות במלאי</label>
            <input type="text" id="amount" name="amount" required="required" />
        </div>
        <div runat="server" style="color:green;" id="GoodFeedback"></div>
        <div runat="server" style="color:red;" id="BadFeedback"></div>
        <div>
             <input type="reset" value="נקה" />
             <asp:Button ID="CreateButton" runat="server" Text="צור" OnClick="CreateButton_Click"  />
             <asp:Button ID="UpdateButton" runat="server" Text="עדכן" OnClick="UpdateButton_Click" />
             <asp:Button ID="DeleteButton" runat="server" Text="מחק" OnClick="DeleteButton_Click" />
         </div>
    </form>
</asp:Content>
