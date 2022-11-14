<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="add-provider.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Add.add_provider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <style type="text/css">
        form {
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            border:1px solid black;
            padding:10%;
        }
        form input {
            text-align:right;
        }
        form label {
            text-align:right;
            font-size:30px;
        }
        .errors {
            color:red;
            text-decoration:none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-container">
            <form id="form1" action="" method="post" runat="server" onsubmit="return isValid()">
                <div class="fields">
                    <label for="providerCode">קוד ספק</label>
                    <input id="providerCode" name="providerCode" />
                    <div class="errors" id="providerCodeError"></div>
                </div>
                <div class="fields">
                    <label for="providerName">שם ספק</label>
                    <input id="providerName" name="providerName" />
                    <div class="errors" id="providerNameError"></div>
                </div>
                <div class="fields">
                    <label for="providerAddress">כתובת ספק</label>
                    <input id="providerAddress" name="providerAddress" />
                    <div class="errors" id="providerAddressError"></div>
                </div>
                 <div class="fields">
                    <label for="providerPhone">טלפון ספק</label>
                    <input id="providerPhone" name="providerPhone" />
                    <div class="errors" id="providerPhoneError"></div>
                </div>
                 <div class="fields">
                    <label for="providerMail">מייל ספק</label>
                    <input id="providerMail" name="providerMail" />
                    <div class="errors" id="providerMailError"></div>
                </div>
                <div>
                    <input type="reset" value="נקה" />
                    <input type="submit" value="הוסף ספק חדש" />
                </div>
            </form>
        </div>
    </div>
    <script src="validation/add-provider.js"></script>
</asp:Content>
