<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MasterPage3.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .div1 {
            width:300px;
            height:250px;
            border:1px solid red;
            background:url("../../images/add-new-icon.png");
            background-size:cover;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="div1"></div>
</asp:Content>
