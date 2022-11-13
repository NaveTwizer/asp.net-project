<%@ Page Title="הכנס מוצר חדש" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="add-product.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.Add.add_product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/dropdown.css" rel="stylesheet" />
    <link href="../../../Styles/add-product.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fullscreen">

        <form id="form1" runat="server" action="" method="post" onsubmit="return isValid()">
            <div class="form-div">
                <div class="right-div">
                    <h3>הוסף מוצר חדש</h3>
                    <table>
                        <tr>
                            <td>
                                <label for="productCode">קוד מוצר</label>
                            </td>
                            <td>
                                <input type="text" id="productCode" name="productCode" />
                            </td>
                        </tr>
                        <tr><td class="errors" id="productCodeError"></td></tr>
                        <tr>
                            <td>
                                <label for="productName">שם מוצר</label>
                            </td>
                            <td>
                                <input type="text" name="productName" id="productName" />
                            </td>
                        </tr>
                        <tr><td class="errors" id="productNameError"></td></tr>
                        <tr>
                            <td>
                                <label for="depName">מחלקה</label>
                            </td>
                            <td>
                                <input type="text" id="depName" name="depName" />
                            </td>
                        </tr>
                        <tr><td class="errors" id="depNameError"></td></tr>
                        <tr>
                            <td>
                                <label for="productorName">שם יצרן</label>
                            </td>
                            <td>
                                <input type="text" id="productorName" name="productorName" />
                            </td>
                        </tr>
                        <tr><td class="errors" id="productorNameError"></td></tr>
                        <tr>
                            <td>
                                <label for="providerCode">קוד ספק</label>
                            </td>
                            <td>
                                <input type="text" id="providerCode" name="providerCode" />
                            </td>
                        </tr>
                        <tr><td class="errors" id="providerCodeError"></td></tr>
                        <tr>
                            <td>
                                <label for="productDesc">תיאור מוצר</label>
                            </td>
                            <td>
                                <textarea id="productDesc" name="productDesc"></textarea>
                            </td>
                        </tr>
                        <tr><td class="errors" id="productDescError"></td></tr>
                        <tr>
                            <td>
                                <label for="price">מחיר מוצר</label>
                            </td>
                            <td>
                                <input type="text" name="price" id="price" />
                            </td>
                        </tr>
                        <tr><td class="errors" id="priceError"></td></tr>
                        <tr>
                            <td>
                                <label for="amount">כמות מוצר</label>
                            </td>
                            <td>
                                <input type="text" id="amount" name="amount" />
                            </td>
                        </tr>
                        <tr><td class="errors" id="amountError"></td></tr>
                        <tr>
                            <td>
                                <input type="reset" value="נקה" />
                                <input type="submit" value="הוסף מוצר" />
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="left-div">
                    <img src="../../../images/add-new-icon.png" alt="Add new icon" />
                </div>
            </div>
        </form>
    </div>
    <script src="validation/add-product.js"></script>
</asp:Content>