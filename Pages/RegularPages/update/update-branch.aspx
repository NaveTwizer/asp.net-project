<%@ Page Title="עדכון סניף" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="update-branch.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.update.update_branch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../../Styles/update-pages-style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fullscreen">
        <h1 class="title">עדכון סניפים</h1>
        <div class="form-container">
            <form runat="server" method="post" action="" onsubmit="return isValid()" id="form1">
                <div>
                    <label>שם סניף לעדכון</label>
                    <input type="text" id="branchName" name="branchName" />
                    <div id="branchNameError" class="errors"></div>
                </div>

                <div>
                    <label for="branchCode">קוד סניף</label>
                    <input type="text" id="branchCode" name="branchCode" />
                    <div id="branchCodeError" class="errors" ></div>
                </div>

                <div>
                    <label for="branchAddress">כתובת סניף</label>
                    <input type="text" id="branchAddress" name="branchAddress" />
                    <div id="branchAddressError" class="errors"></div>
                </div>

                <div>
                    <label for="branchPhone">מספר טלפון</label>
                    <input type="tel" id="branchPhone" name="branchPhone" />
                    <div id="branchPhoneError" class="errors"></div>
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
    </div>
    <script src="../../../Scripts/update-branch.js"></script>
</asp:Content>