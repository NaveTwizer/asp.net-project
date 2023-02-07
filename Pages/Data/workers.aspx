<%@ Page Title="טבלת עובדים" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="workers.aspx.cs" Inherits="Nave_Project2.Pages.data.workers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">\
    <link href="../../Styles/TablesStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="TableDiv" runat="server"></div>
    <form action="workers.aspx" method="post" runat="server">
        <input placeholder="חפש עובד לפי שם או תז" id="worker" name="worker" />
        <asp:Button runat="server" Text="חפש" ID="SearchWorker" OnClick="SearchWorker_Click" />
        <br /><br /><br />
        <a href="/Pages/data/update/update-workers.aspx" class="btn btn-large">לעדכון עובדים לחץ כאן</a>
    </form>
</asp:Content>