<%@ Page Title="הוסף מכירה" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="add-sale.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Add.add_sale" %>
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
            font-size:20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-container">
            <form action="" method="post" onsubmit="return isValid()" runat="server">
                <div>
                    <label for="saleCode">קוד מכירה</label>
                    <input type="text" id="saleCode" name="saleCode" />
                    <div id="saleCodeError" class="errors"></div>
                </div>
                <div>
                    <label for="saleDate">תאריך מכירה</label>
                    <input type="date" id="saleDate" name="saleDate" />
                    <div id="saleDateError" class="errors"></div>
                </div>
                <div>
                    <label for="branchCode">קוד סניף</label>
                    <input type="text" id="branchCode" name="branchCode" />
                    <div id="branchCodeError" class="errors"></div>
                </div>
                <div>
                    <label for="workerId">תז עובד</label>
                    <input type="text" id="workerId" name="workerId" />
                    <div id="workerIdError" class="errors"></div>
                </div>
                <div>
                    <input type="reset" value="נקה" />
                    <input type="submit" value="הוסף מכירה" />
                </div>
            </form>
        </div>
    </div>
    <script src="validation/add-sale.js"></script>
</asp:Content>