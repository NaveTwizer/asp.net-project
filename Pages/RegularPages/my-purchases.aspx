<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="my-purchases.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.my_purchases" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>הקניות שלי</title>
    <style type="text/css">
        body {
            background-color:gray;
        }
        table {
            border:1px solid black;
            position:absolute;
            top:50%;
            left:50%;
            transform:translate(-50%, -50%);
            text-align:center;
            border-collapse: collapse;
        }
        td {
            border:1px solid black;
            border-collapse:collapse;
            font-size:30px;
            padding:5px;
        }
        .title {
            text-align:center;
            position:absolute;
            top:32%;
            left:50%;
            transform:translate(-50%, -50%);
            font-size:50px;
        }
    </style>
</head>
<body>
    <h1 class="title">הקניות שלי</h1>
    <div id="TableDiv" runat="server"></div>
</body>
</html>
