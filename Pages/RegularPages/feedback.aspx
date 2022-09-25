<%@ Page Title="משוב" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage2.Master" AutoEventWireup="true" CodeBehind="feedback.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/NavbarStyle1.css" rel="stylesheet" />
    <link href="../../Styles/feedback.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fullscreen">
        <h1 class="title">משוב</h1>
        <div class="form-div">
            <form action="" method="post" runat="server">
                <label for="username">שם משתמש</label>
                <input name="username" id="username" />
                <br />
                <label class="label-questions">עיצוב האתר</label>
                <br />
                <label class="radio-buttons">
                    <input type="radio" name="design" />
                    1
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="design" />
                    2
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="design" />
                    3
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="design" />
                    4
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="design" />
                    5
                </label>
                <br />
            </form>
        </div>
    </div>
</asp:Content>
