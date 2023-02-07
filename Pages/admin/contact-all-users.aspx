<%@ Page Title="הכרזות" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="contact-all-users.aspx.cs" Inherits="Nave_Project2.Pages.admin.contact_all_users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        * {
            box-sizing:border-box;
            border-collapse:collapse;
        }
        form {
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            text-align:center;
            border-collapse:collapse;
            border:1px solid black;
            width:100%;

        }
        .right, .left {
            display:inline-block;
            border:1px solid black;
            border-collapse:collapse;
            width:45%;
        }
        textarea {
            resize:none;
            border:1px solid black;
            text-align:right;
            font-size:2rem;
            width:100%;
        }
        textarea::placeholder {
            text-align:right;
        }
        .sendButtons {
            width:100%;
            padding:10px 0 10px 0;
            background-color:royalblue;
            font-size:25px;
            text-align:center !important;
        }
        .subjectInput {
            border:1px solid black;
            padding: 10px 0 10px 0;
            text-align:right;
            width:100%;
            font-size:1.5rem;
        }
        .subjectInput::placeholder {
            text-align:right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form action="contact-all-users.aspx" method="post" runat="server">
        <div class="right">
            <h1>שלח מייל לכל המשתמשים</h1>
            <input placeholder="נושא ההודעה" name="UsersSubject" class="subjectInput"/>
            <textarea placeholder="תוכן ההודעה" id="UsersContent" name="UsersContent" rows="10" cols="40"></textarea>
            <br />
            <asp:Button runat="server" ID="SendMailToUsers" OnClick="SendMailToUsers_Click" Text="שלח" CssClass="sendButtons" />
        </div>
        <div class="left">
            <h1>שלח מייל לכל העובדים</h1>
            <input placeholder="נושא ההודעה" name="WorkersSubject" class="subjectInput" />
            <textarea placeholder="תוכן ההודעה" id="WorkersContent" name="WorkersContent" rows="10" cols="40"></textarea>
            <br />
            <asp:Button runat="server" ID="SendMailToWorkers" OnClick="SendMailToWorkers_Click" Text="שלח" CssClass="sendButtons" />
        </div>
    </form>
</asp:Content>