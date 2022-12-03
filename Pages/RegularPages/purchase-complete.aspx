<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="purchase-complete.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.purchase_complete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>הקנייה הושלמה בהצלחה</title>
    <style type="text/css">
        body {
            background-color:gray;
        }
        .div1 {
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            text-align:center;
        }
    </style>
</head>
<body>
    <div class="div1">
        <h1>הקנייה הושלמה בהצלחה</h1>
        <img src="../../images/success.gif" id="img1" />
    </div>
</body>
</html>
