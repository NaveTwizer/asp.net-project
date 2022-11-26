<%@ Page Title="הזמנת מוצר" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage2.Master" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <style type="text/css">
        form {
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            border:1px solid black;
            text-align:center;
            padding:5px;
        }
        label {
            font-size:20px;
        }
        input, select {
            width:90%;
            height:30px;
            font-size:20px;
        }
        .inline {
            display:inline;
        }
        .inline input {
            width:45%;
        }
        input[type="submit"], input[type="reset"] {
            background-color:darkseagreen;
        }
        input[type="submit"]:hover, input[type="reset"]:hover {
            background-color:green;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>טופס הזמנה</h1>
    <form action="" method="post" runat="server">
        <div>
            <label>המוצר אותו תרצה להזמין</label>
            <div>
                <select runat="server" id="SelectProduct" name="product"></select>
            </div>
        </div>
        <br />
        <div>
            <label>כמות</label>
            <input type="number" id="amount" name="amount" />
        </div>
        <br />
        <div>
            <div class="inline">
                <input type="submit" value="הזמן"/>
            </div>
            <div class="inline">
                <input type="reset" value="נקה"/>
            </div>
        </div>
        <div id="GoodFeedback" runat="server" style="color:lightseagreen; font-size:25px;"></div>
        <div id="BadFeedback" runat="server" style="color:red; font-size:25px;"></div>
    </form>
</asp:Content>