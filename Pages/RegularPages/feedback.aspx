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
                <label for="date">תאריך</label>
                <input type="date" id="date" name="date" />
                <br />
                <label>עיצוב האתר</label>
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
                    <input type="radio" name="accessibility" />
                    5
                </label>
                <br />
                <label>נגישות באתר</label>
                <br />
                <label class="radio-buttons">
                    <input type="radio" name="accessibility" />
                    1
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="accessibility" />
                    2
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="accessibility" />
                    3
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="accessibility" />
                    4
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="accessibility" />
                    5
                </label>
                <br />
                <label>היית ממליץ עלינו לחבריך?</label>
                <br />
                <label class="radio-buttons">
                    <input type="radio" name="suggest" />
                    1
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="suggest" />
                    2
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="suggest" />
                    3
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="suggest" />
                    4
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="suggest" />
                    5
                </label>
                <br />
                <label>חוות דעת כללית על האתר</label>
                <br />
                <label class="radio-buttons">
                    <input type="radio" name="overall" />
                    1
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="overall" />
                    2
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="overall" />
                    3
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="overall" />
                    4
                </label>
                <label class="radio-buttons">
                    <input type="radio" name="overall" />
                    5
                </label>
            </form>
        </div>
    </div>
</asp:Content>