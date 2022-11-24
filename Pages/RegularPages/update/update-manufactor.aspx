<%@ Page Title="עדכן יצרן" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="update-manufactor.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.update.update_manufactor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../../Styles/update-pages-style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>עדכן יצרן</h1>
     <form runat="server" method="post" action="" onsubmit="return isValid()" >
         <div>
             <label for="name">שם יצרן</label>
             <input type="text" name="name" id="name" />
             <div class="errors" id="nameError"></div>
         </div>
         <div>
             <label for="country">שם מדינה</label>
             <input type="text" name="country" id="country" />
             <div class="errors" id="countryError"></div>
         </div>
         <div runat="server" style="color:red;" id="BadFeedback"></div>
         <div runat="server" style="color:green;" id="GoodFeedback"></div>
         <div>
             <input type="reset" value="נקה" />
             <asp:Button ID="CreateButton" runat="server" Text="צור" OnClick="CreateButton_Click"  />
             <asp:Button ID="UpdateButton" runat="server" Text="עדכן" OnClick="UpdateButton_Click" />
             <asp:Button ID="DeleteButton" runat="server" Text="מחק" OnClick="DeleteButton_Click" />
         </div>
     </form>
    <script src="../../../Scripts/update-validation/update-manufactor.js"></script>
</asp:Content>