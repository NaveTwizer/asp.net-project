<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="update-sale.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.update.update_sale" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../../Styles/update-pages-style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>עדכן מכירה</h1>
    <form runat="server" action="" method="post">
        <div>
            <label>קוד מכירה</label>
            <input type="text" id="code" name="code" />
        </div>
        <div>
            <label>תאריך מכירה</label>
            <input type="date" id="date" name="date" />
        </div>
        <div>
            <label>קוד סניף</label>
            <input type="text" id="BranchCode" name="BranchCode" />
        </div>
        <div>
            <label>תז עובד</label>
            <input type="text" id="WorkerId" name="WorkerId" />
        </div>
        <div>
            <input type="reset" value="נקה" />
            <asp:Button ID="Update_Button" runat="server" Text="עדכן" OnClick="Update_Button_Click"` />
            <asp:Button ID="Create_Button" runat="server" Text="צור" OnClick="Create_Button_Click"/>
            <asp:Button ID="Delete_Button" runat="server" Text="מחק" OnClick="Delete_Button_Click" />
        </div>
        <!-- להמשיך כאן -->
    </form>
</asp:Content>
