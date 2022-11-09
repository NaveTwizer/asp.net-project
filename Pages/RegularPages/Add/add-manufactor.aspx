<%@ Page Title="יצרן חדש" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="add-manufactor.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Add.add_manufactor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <style type="text/css">
        .errors {
            color:red;
        }
        #form1 {
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            border:1px solid black;
        }
        tr {
            border:1px solid black;
            border-collapse:collapse;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fullscreen">
        <form id="form1" action="" method="post" runat="server" onsubmit="return isValid()">
            <table>
                <tr>
                    <td>
                        <label for="manufactorName">שם היצרן</label>
                    </td>
                    <td>
                        <input id="manufactorName" name="manufactorName" />
                    </td>
                    <td class="errors" id="manufactorNameError"></td>
                </tr>
                <tr>
                    <td>
                        <label for="countryName">מדינת יצרן</label>
                    </td>
                    <td>
                        <input id="countryName" name="countryName" />
                    </td>
                    <td class="errors" id="countryNameError"></td>
                </tr>
                <tr>
                    <td>
                        <input type="reset" value="נקה" />
                        <input type="submit" value="הוסף יצרן חדש" />
                    </td>
                </tr>
            </table>
        </form>
    </div>
    <script src="validation/add-manufactor.js"></script>
</asp:Content>
