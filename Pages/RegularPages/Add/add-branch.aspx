<%@ Page Title="הוסף סניף חדש" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="add-branch.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Add.add_branch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <style type="text/css">
        form {
            padding:10px;
            border: 1px solid black;
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fullscreen">
        <form id="form1" action="" runat="server" onsubmit="return isValid()" method="post">
            <label for="branchCode">קוד סניף</label>
            <input type="text" id="branchCode" name="branchCode" />
            <div class="div-errors" id="branchCodeError"></div>
            <br />
            <label for="branchName">שם הסניף</label>
            <input type="text" id="branchName" name="branchName" />
            <div class="div-errors" id="branchNameError"></div>
            <br />
            <label for="branchAddress">כתובת סניף</label>
            <input type="text" id="branchAddress" name="branchAddress" />
            <div class="div-errors" id="branchAddressError"></div>
            <br />
            <label for="branchPhone">מספר טלפון</label>
            <input type="tel" id="branchPhone" name="branchPhone" />
            <div class="div-errors" id="branchPhoneError"></div>
            <br />
            <div class="buttons">
                <input type="reset" value="נקה" />
                <input type="submit" value="הוסף סניף חדש"/>
            </div>
        </form>
    </div>
    <script src="validation/add-branch.js"></script>
</asp:Content>