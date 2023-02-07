<%@ Page Title="סטטיסטיקה" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="statistics.aspx.cs" Inherits="Nave_Project2.Pages.statistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            direction:rtl;
            background-color:gray;
        }
        .top, .middle {
            border:1px solid black;
            display:flex;
            justify-content:space-evenly;
            padding-bottom:50px;
            width:100%;
            text-align:center;
        }
        .circle-wrapper {
            display:inline-block;
            width:150px;
            text-align:right;
            height:100px;
        }
        .circle {
            width: 120px;
            line-height: 120px;
            border-radius: 50%;
            text-align: center;
            font-size: 32px;
            border: 3px solid #000;
        }
        .title {
            text-align:center;
            font-size:35px;
        }
        p {
            font-size:20px;
            padding-right:25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <h1 class="title">סטטיסטיקה</h1>
    <div class="top">
        <div class="circle-wrapper">
            <div class="circle" id="UsersDiv" runat="server"></div>
            <p>משתמשים</p>
        </div>
        <div class="circle-wrapper">
            <div class="circle" id="ProductsDiv" runat="server"></div>
            <p>מוצרים</p>
        </div>
        <div class="circle-wrapper">
            <div class="circle" id="SalesDiv" runat="server"></div>
            <p>מכירות</p>
        </div>
    </div>
    <div class="middle">
        <div class="circle-wrapper">
            <div class="circle" id="BranchesDiv" runat="server"></div>
            <p>סניפים</p>
        </div>
        <div class="circle-wrapper">
            <div class="circle" id="WorkersDiv" runat="server"></div>
            <p>עובדים</p>
        </div>
    </div>
    <div class="views-chart-wrapper">
        <p>מספר כניסות לאתר בשבוע האחרון</p>
        <asp:Chart ID="Chart1" runat="server">
            <Series>
                <asp:Series Name="Series1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </div>
    </form>
</asp:Content>