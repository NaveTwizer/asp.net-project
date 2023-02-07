<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="payment.aspx.cs" Inherits="Nave_Project2.Pages.payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>דף תשלום</title>
    <link rel="stylesheet" href="/Styles/payment.css" />
</head>
<body>
    <div class="fullscreen">
        <form action="payment.aspx" method="post" runat="server" id="form1">
            <p id="EnterCard">הכנס פרטי כרטיס</p>
            <div class="CardDetailsContainer">
                <div id="div1" class="inline">
                    <input name="one" placeholder="xxxx" type="text" maxlength="4" id="one" />
                </div>
                <div id="div2" class="inline">
                    <input name="two" placeholder="xxxx" type="text" maxlength="4" id="two" />
                </div>
                <div id="div3" class="inline">
                    <input name="three" placeholder="xxxx" type="text" maxlength="4" id="three"/>
                </div>
                <div id="div4" class="inline">
                    <input name="four" placeholder="xxxx" type="text" maxlength="4" id="four" />
                </div>
                <br /> <br />
                <br /> <br />

                <div>
                    <div id="MonthDiv" class="inline BigSelect">
                        <select id="YearSelect" name="year" runat="server"></select>                        
                        <label>חודש</label>
                    </div>
                    <div id="YearDiv" class="inline BigSelect">
                        <select name="month" id="MonthSelect">
                            <option value="one">1</option>
                            <option value="two">2</option>
                            <option value="three">3</option>
                            <option value="four">4</option>
                            <option value="five">5</option>
                            <option value="six">6</option>
                            <option value="seven">7</option>
                            <option value="eight">8</option>
                            <option value="nine">9</option>
                            <option value="ten">10</option>
                            <option value="eleven">11</option>
                            <option value="twelve">12</option>
                        </select>
                        <label>שנה</label>
                    </div>
                </div>
                <div>
                    <label>cvv - שלוש ספרות בגב הכרטיס</label>
                    <br />
                    <input name="cvv" type="text" maxlength="3" id="cvv"/>
                </div>
                <div>
                    <p id="toPay" runat="server"></p>
                </div>
                <div id="GoodFeedback" runat="server"></div>
                <div>
                    <asp:Button runat="server" ID="Pay_Button" Text="שלם" OnClick="Pay_Button_Click" CausesValidation="false" />
                </div>
            </div>
        </form>
    </div>
    <script src="../../Scripts/payment.js"></script>
</body>
</html>