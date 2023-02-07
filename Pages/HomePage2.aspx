<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage2.aspx.cs" Inherits="Nave_Project2.Pages.HomePage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Supermarket</title>
    <style type="text/css">
      /* General styles */
      body {
        font-family: Arial, sans-serif;
        margin: 0;
        padding: 0;
        background-image: url("../images/HomePageBackground.png");
        background-size: cover;
        background-repeat:no-repeat;
      }
      header {
        background-color: rgba(242, 242, 242, 0.8);
        padding: 20px;
        text-align: center;
      }
      h1 {
        margin-top: 0;
      }
      nav ul {
        display: flex;
        justify-content: center;
        list-style: none;
        margin: 0;
        padding: 0;
      }
      nav a {
        display: block;
        padding: 10px 20px;
        text-decoration: none;
      }
      main {
        padding: 20px;
        background-color: rgba(255, 255, 255, 0.8);
        max-width: 800px;
        margin: 0 auto;
      }
      h2 {
        margin-top: 0;
      }
      section {
        margin-bottom: 40px;
      }
      footer {
        /*background-color: rgba(242, 242, 242, 0.8);*/
        padding: 20px;
        text-align: center;
      }
    </style>
</head>
<body>
    <header>
      <h1>Welcome to Our Supermarket</h1>
      <nav>
        <ul>
          <li><a href="#about">About Us</a></li>
          <li><a href="#products">Products</a></li>
          <li><a href="#contact">Contact Us</a></li>
        </ul>
      </nav>
    </header>
    <main>
      <section id="about">
        <h2>About Us</h2>
        <p>We are a local supermarket providing fresh produce and household essentials to our community. Visit us today to see what we have to offer!</p>
      </section>
      <section id="products">
        <h2>Products</h2>
        <ul>
          <li>Fresh Fruits and Vegetables</li>
          <li>Bakery</li>
          <li>Dairy and Cheese</li>
          <li>Meat and Seafood</li>
        </ul>
      </section>
      <section id="contact">
        <h2>Contact Us</h2>
        <p>Address: 123 Main St, Anytown USA 12345</p>
        <p>Phone: (555) 555-5555</p>
        <p>Email: info@oursupermarket.com</p>
      </section>
    </main>
    <footer>
      <p>Copyright © 2023 Our Supermarket</p>
    </footer>
</body>
</html>
