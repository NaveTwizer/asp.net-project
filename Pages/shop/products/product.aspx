<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Master1.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="Nave_Project2.Pages.shop.products.product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
      /* Add your styles here */
      body {
          direction:rtl;
          background-color:gray;
      }
      img {
          border:1px solid black;
      }
      .product-desc {
          font-size:25px;
          list-style-type: disc !important;
      }
      .buttons {
          padding: 30px;
          font-size: 30px;
      }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 id="title" runat="server"></h1>
    <div id="multiple-products-found">
        <h2 id="MultipleProductsTitle" runat="server"></h2>
        <h3 id="CurrentProduct" runat="server"></h3>
        <form runat="server">
            <asp:Button CssClass="buttons backward" ID="GoBackButton" Text="אחורה" runat="server" OnClick="GoBackButton_Click" />
            <asp:Button CssClass="buttons forward" ID="GoForwardButton" Text="קדימה" runat="server" OnClick="GoForwardButton_Click" />
        </form>
    </div>
    <img runat="server" id="ProductImg" height="400" width="400" />
    <h1 id="title2" runat="server">תיאור המוצר</h1>
    <ul class="product-desc">
        <li runat="server" id="ProductDep"></li>
        <li runat="server" id="ProductorName"></li>
        <li runat="server" id="ProductDesc"></li>
        <li runat="server" id="PricePerUnit"></li>
        <li runat="server" id="AmountInStock"></li>
    </ul>
</asp:Content>