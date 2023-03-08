<%@ Page Title="משוב" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="feedback.aspx.cs" Inherits="Nave_Project2.Pages.feedbacl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/Styles/feedback.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 class="_title">טופס משוב</h1>
        <form runat="server" method="post" action="feedback.aspx" class="border-1px-black form" onsubmit="return IsValid()">
            <div>
                <label>מה דעתך על האתר שלנו?</label>
                <br />
                <input id="opinion" name="opinion" class="inputs" type="number" min="1" max="5" />
                <div id="opinionError" class="errors"></div>
            </div>
            <div>
                <label>מה דעתך על הנגישות באתר?</label>
                <br />
                <input id="access" name="access" class="inputs" type="number" min="1" max="5" />
                <div class="errors" id="accessError"></div>
            </div>
            <div>
                <label>מה דעתך על איכות המוצרים שלנו?</label>
                <br />
                <input id="quality" name="quality" class="inputs" type="number" min="1" max="5" />
                <div class="errors" id="qualityError"></div>
            </div>
            <div>
                <label>מה דעתך על עיצוב האתר?</label>
                <br />
                <input id="design" name="design" class="inputs" type="number" min="1" max="5" />
                <%--סך רכישות למשתמש--%>
                <div class="errors" id="designError"></div>
            </div>
            <div>
                <label>האם יש לך משהו נוסף לומר לנו?</label>
                <br />
                <textarea id="feedback" name="feedback" style="resize:none; width:100%;font-size:25px;" class="border-1px-black" rows="4"></textarea>
            </div>
            <div id="output" runat="server"></div>
            <div>
                <asp:Button runat="server" ID="SendButton" Text="שלח" OnClick="SendButton_Click" CssClass="buttons" />
            </div>
        </form>
    </div>
    <script src="../Scripts/feedback.js"></script>
</asp:Content>