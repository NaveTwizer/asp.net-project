<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminTest.aspx.cs" Inherits="Nave_Project2.Pages.RegularPages.AdminTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>דף הבית</title>
    <style type="text/css">
        a {
            padding-left:10px;
        }
        a:hover {
            text-decoration:underline;
            text-decoration-color:green;
            text-decoration-style:solid;
            text-decoration-thickness:3px;
        }
    </style>
</head>
<body dir="rtl">
    <div class="container">
        <div class="navbar-div">
            <table>
                <tr>
                    <td>
                        <a href="../Data/sales.aspx">רכישות</a>
                    </td>
                    <td>
                        <a href="../data-pages/about-us.html">אודות</a>
                    </td>
                    <td>
                        <a href="exit.aspx">התנתק</a>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</body>
</html>
