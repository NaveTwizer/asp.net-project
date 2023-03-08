<%@ Page Title="סטטיסטיקה" Language="C#" MasterPageFile="~/Master Pages/Master3.Master" AutoEventWireup="true" CodeBehind="statistics.aspx.cs" Inherits="Nave_Project2.Pages.statistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/statistics.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" method="post">
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
        <div class="bottom">
            <div class="circle-wrapper">
                <div class="circle" id="TotalVisitsDiv" runat="server">123</div>
                <p>סך כניסות לאתר</p>
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
        <hr style="border-color:black;" />
        <%--<div id="search-div">
            <h2>חפש סך מכירות לפי חודש</h2>
            <select class="select" id="month" name="month">
                <option value="1">ינואר</option>
                <option value="2">פברואר</option>
                <option value="3">מרץ</option>
                <option value="4">אפריל</option>
                <option value="5">מאי</option>
                <option value="6">יוני</option>
                <option value="7">יולי</option>
                <option value="8">אוגוסט</option>
                <option value="9">ספטמבר</option>
                <option value="10">אוקטובר</option>
                <option value="11">נובמבר</option>
                <option value="12">דצמבר</option>
            </select>

            <asp:Button runat="server" ID="SearchMonthlySalesButton" OnClick="SearchMonthlySalesButton_Click" Text="חפש" CssClass="buttons" />
            <div class="results" runat="server">
                <p id="SalesPerMonthResult" runat="server" style="font-size:25px;">123</p>
            </div>
        </div>--%>
        <div id="average-div">
            <h1 id="avg-header">ממוצע חוות דעת המשתמשים</h1>
            <h2 id="OpinionAverage" runat="server"></h2>
            <h2 id="AccessAverage" runat="server"></h2>
            <h2 id="QualityAverage" runat="server"></h2>
            <h2 id="DesignAverage" runat="server"></h2>
            <h3 id="Total" runat="server"></h3>
        </div>

        <div id="queries-section" style="border:1px solid black;">
            <h1 id="queries-header">שאילתות מורכבות</h1>
            <ul id="queries">
                <li>
                    <a href="/Pages/admin/queries/productors-per-country.aspx" target="_blank">סך יצרנים מכל מדינה</a>
                </li>
                <li>
                    <a href="/Pages/admin/queries/products-per-country.aspx" target="_blank">סך מוצרים מכל מדינה</a>
                </li>
                <li>
                    <a href="/Pages/admin/queries/products-per-dep.aspx" target="_blank">סך מוצרים מכל מחלקה</a>
                </li>
                <li>
                    <a href="/Pages/admin/queries/products-per-productor.aspx" target="_blank">סך מוצרים מכל יצרן</a>
                </li>
                <li>
                    <a href="/Pages/admin/queries/products-per-provider.aspx" target="_blank">סך מוצרים מכל ספק</a>
                </li>
                <li>
                    <a href="/Pages/admin/queries/sales-per-user.aspx" target="_blank">סך מכירות מכל משתמש</a>
                </li>
                <li>
                    <a href="/Pages/admin/queries/workers-per-branch.aspx" target="_blank">סך עובדים בכל סניף</a>
                </li>
                <li>
                    <a href="/Pages/admin/queries/workers-per-role.aspx" target="_blank">סך עובדים בכל תפקיד</a>
                </li>
            </ul>
        </div>
    </form>
</asp:Content>