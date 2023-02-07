<%@ Page Title="רשימת משתמשים" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="Nave_Project2.Pages.data.users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/TablesStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" action="users.aspx" method="post">
        <div class="container">
            <div id="UsersDiv" runat="server"></div>
            <div id="search">
                <input type="text" placeholder="חפש לפי שם משתמש" id="username" name="username" />
                <asp:Button runat="server" Text="חפש" ID="UsernameByNameSearch" OnClick="UsernameByNameSearch_Click" />
            </div>
            <div id="sortdiv">
                <label>מיין לפי</label>
                <asp:DropDownList runat="server" ID="Sort" AutoPostBack="true" OnSelectedIndexChanged="Sort_SelectedIndexChanged">
                    <asp:ListItem Value="username">שם משתמש</asp:ListItem>
                    <asp:ListItem Value="pswd">סיסמה</asp:ListItem>
                    <asp:ListItem Value="firstname">שם פרטי</asp:ListItem>
                    <asp:ListItem Value="lastname">שם משפחה</asp:ListItem>
                    <asp:ListItem Value="address">כתובת</asp:ListItem>
                    <asp:ListItem Value="gender">מין</asp:ListItem>
                    <asp:ListItem Value="mail">כתובת דואל</asp:ListItem>
                    <asp:ListItem Value="birthday">תאריך לידה</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div id="CountQueryDiv">
                <label>חשב סך משתמשים לפי מגדר</label>
                <select name="gender">
                    <option value="male">זכר</option>
                    <option value="female">נקבה</option>
                </select>
                <asp:Button runat="server" ID="CountUsersByGender" Text="חשב" OnClick="CountUsersByGender_Click" />
                <input runat="server" id="Result" disabled />
            </div>
        </div>
    </form>
</asp:Content>