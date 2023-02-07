<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Master2.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="Nave_Project2.Pages.shop.product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    /* Add some basic styling */
    body {
      font-family: Arial, sans-serif;
      text-align: center;
    }

    h1 {
      font-size: 36px;
      margin-bottom: 40px;
    }

    img {
      width: 500px;
      margin: 20px 0;
    }

    p {
      font-size: 18px;
      line-height: 1.5;
      text-align: left;
      width: 80%;
      margin: 0 auto;
    }

    h2 {
      font-size: 24px;
      color: green;
      margin-bottom: 20px;
    }

    button {
      background-color: green;
      color: white;
      padding: 10px 20px;
      border-radius: 5px;
      font-size: 18px;
      cursor: pointer;
      margin-top: 20px;
    }

    .product-info {
      display: flex;
      justify-content: space-between;
      align-items: center;
      width: 80%;
      margin: 40px auto;
    }

    .product-details {
      text-align: left;
    }

    .product-price {
      text-align: right;
    }
  </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
  <h1>Product Name</h1>
  <div class="product-info">
    <img runat="server" id="ProductImage" alt="Product Image">
    <div class="product-details">
      <h2>תיאור מוצר</h2>
      <p id="Description" runat="server"></p>
      <h2>פרטים נוספים</h2>
      <table>
        <tr>
          <td id="DepName" runat="server"></td>
          <th>מחלקה</th>
        </tr>
        <tr>
          <td id="ProductorName" runat="server"></td>
          <th>יצרן</th>
        </tr>
          <tr>
              <td runat="server" id="Pricee"></td>
              <td>מחיר בשקלים</td>
          </tr>
      </table>
      <button>הוסף לסל קניות</button>
    </div>
  </div>
</main>
</asp:Content>