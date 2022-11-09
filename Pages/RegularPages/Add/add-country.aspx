<%@ Page Title="מדינה חדשה" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="add-country.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Add.add_country" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <style type="text/css">
        form {
            padding: 10px;
            border: 1px solid black;
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fullscreen">

        <form id="form1" runat="server" onsubmit="return isValid()" action="" method="post">
            <table id="table1">
                <tr>
                    <td>
                        <label for="countryName">שם מדינה</label>
                    </td>
                    <td>
                        <input type="text" name="countryName" id="countryName" />
                    </td>
                    <td class="errors" id="countryNameError"></td>
                </tr>
                <tr>
                    <td>
                        <label for="countryNum">מספר סניפים במדינה</label>
                    </td>
                    <td>
                        <input type="text" name="countryNum" id="countryNum" />
                    </td>
                    <td class="errors" id="countryNumError"></td>
                </tr>
                <tr>
                    <td>
                        <div class="buttons">
                            <input type="reset" value="נקה"/>
                            <input type="submit" value="הוסף מדינה חדשה" />
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div id="feedback"></div>
                    </td>
                </tr>
            </table>
            <br />
        </form>
    </div>
    <script src="validation/add-country.js"></script>
</asp:Content>