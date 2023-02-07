<%@ Page Title="עדכן עובד" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="update-workers.aspx.cs" Inherits="Nave_Project2.Pages.data.update.update_users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Styles/UpdatePagesStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" action="update-workers.aspx" method="post">
        <div>
            <label>תז עובד</label>
            <input type="text" id="ID" name="ID" />
            <div id="idError" class="errors"></div>
        </div>
        <div>
            <label>שם עובד</label>
            <input type="text" id="name" name="name" />
            <div id="nameError" class="errors"></div>
        </div>
        <div>
            <label>תאריך לידה</label>
            <input type="date" id="birthday" name="birthday" />
            <div id="birthdayError" class="errors"></div>
        </div>
        <div>
            <label>מין</label>
            <select id="gender" name="gender" runat="server">
                <option value="זכר">זכר</option>
                <option value="נקבה">נקבה</option>
            </select>
        </div>
        <div>
            <label>תאריך התחלת עבודה</label>
            <input type="date" id="start" name="start" />
            <div id="startError" class="errors"></div>
        </div>
        <div>
            <label>כתובת</label>
            <input type="text" name="addr" id="addr" />
            <div id="addrError" class="errors"></div>
        </div>
        <div>
            <label>מספר טלפון</label>
            <input type="text" id="phone" name="phone" />
            <div id="phoneError" class="errors"></div>
        </div>
        <div>
            <label>קוד סניף</label>
            <input type="text" id="code" name="code" />
            <div id="codeError" class="errors"></div>
        </div>
        <div>
            <label>שם תפקיד</label>
            <select id="roles" name="roles" runat="server"></select>
        </div>

        <div id="feedback" runat="server"></div>
        
        <div>
            <input type="reset" value="נקה" class="actionButtons" />
            <asp:Button runat="server" ID="CreateButton" Text="צור" CssClass="actionButtons" OnClick="CreateButton_Click" />
            <asp:Button runat="server" ID="UpdateButton" Text="עדכן" CssClass="actionButtons" OnClick="UpdateButton_Click" />
            <asp:Button runat="server" ID="DeleteButton" Text="מחק" CssClass="actionButtons" OnClick="DeleteButton_Click" />
        </div>
    </form>
</asp:Content>