<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="my.aspx.cs" Inherits="Nave_Project2.Pages.profiles.my" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>הפרופיל שלי</title>
    <link href="../../Styles/my-profile.css" rel="stylesheet" />
    <style type="text/css">
        body {
            background-color:gray !important;
        }
    </style>
</head>
<body dir="rtl">
    <!--  https://i.pinimg.com/564x/95/2b/4b/952b4b5b937d9d8a18cf225034e263f6.jpg  -->
    <div id="fullscreen">
        <%--<div class="upper-navbar">
            <!-- upper navbar here. TODO-->
        </div>--%>
        <div class="right-div inline">
            <div class="right-content">
                <h2 class="right-title">הפרופיל שלי</h2>
                <img id="pfp" runat="server" width="250" height="250" />
                <form runat="server" method="post" action="my.aspx" id="form1">
                    <p class="choose-pfp-p">בחר תמונת פרופיל</p>
                    <asp:FileUpload runat="server" ID="ProfilePictureFileUpload" accept=".png" />
                    <asp:Button runat="server" ID="UploadProfilePictureButton" Text="שמור תמונה" OnClick="UploadProfilePictureButton_Click" />
                </form>
                <br /><br />
                <div class="account-info-div">
                    <div class="account-info-div-inner">
                        <h3 class="account-info-h">פרטי החשבון</h3>
                        <br />
                        <table>
                            <tr>
                                <td>
                                    <label class="account-info-labels">שם פרטי ומשפחה</label>
                                </td>
                                <td class="account-info-col">
                                    <input readonly="readonly" class="account-info-inputs" id="NameField" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="account-info-labels">כתובת דואל</label>
                                </td>
                                <td class="account-info-col">
                                    <input readonly="readonly" class="account-info-inputs" id="MailField" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="account-info-labels">כתובת</label>
                                </td>
                                <td class="account-info-col">
                                    <input readonly="readonly" class="account-info-inputs" id="AddressField" runat="server" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <br />
                </div>
            </div>
        </div>
    </div>
    <audio id="bgMusic" src="/images/hahahaha.mp3" runat="server"></audio>
    <script src="../../Scripts/change-password.js"></script>
</body>
</html>