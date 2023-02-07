<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="Nave_Project2.Pages.order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>הזמן מוצרים</title>
    <style type="text/css">
        body {
            background-color:royalblue;
        }
        form {
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            border:1px solid black;
            text-align:center;
            padding:50px;
        }
        p {
            font-size:25px;
        }
        #product {
            border:1px solid black;
            text-align:center;
            font-size:20px;
        }
        .inline {
            display:flex;
            justify-content:space-evenly;
        }

        .buttons {
            display:inline;
            width:50%;
            padding:10px 0 10px 0;
        }
        #amount {
            padding:10px 0 10px 0;
            text-align:center;
        }
        .btn {
            text-decoration:none;
            text-align:center;
            background-color:aqua;
            border:1px solid aqua;
        }
        .btn-large {
            padding:15px 40px 15px 40px;
            font-size:1rem;
        }
    </style>
</head>
<body>
    <form runat="server" action="order.aspx" method="post">
        <div>
            <p>המוצר אותו תרצה להזמין</p>
            <select name="product" id="product" runat="server"></select>
        </div>
        <div>
            <p>כמות</p>
            <input name="amount" id="amount" type="text" />
        </div>
        <br /><br />
        <div id="feedback" runat="server" style="color:green;"></div>
        <div id="BadFeedback" runat="server" style="color:red;"></div>
        <hr />
        <div class="inline">
            <input type="reset" value="נקה" class="buttons" />
            <asp:Button runat="server" ID="OrderButton" Text="הזמן" CssClass="buttons" />
        </div>
        <div>
            <a href="my-cart.aspx">לעגלת הקניות שלי</a>
        </div>
    </form>
</body>
</html>