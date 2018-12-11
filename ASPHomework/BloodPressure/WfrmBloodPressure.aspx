<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfrmBloodPressure.aspx.cs" Inherits="ASPHomework.BloodPressure.WfrmBloodPressure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-family: 微軟正黑體;
            font-size: xx-large;
        }
        .auto-style3 {
            height: 20px;
        }
    </style>
</head>
<body style="font-family: 微軟正黑體">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2"><strong>高血壓檢測系統</strong></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">請輸入收縮壓與舒張壓</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>收縮壓 : </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="tb收縮壓" runat="server" style="font-size: medium"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>舒張壓 : </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="tb舒張壓" runat="server" style="font-size: medium"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMsg" runat="server" style="color: #3333FF" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn送出資料" runat="server" OnClick="btn送出資料_Click" style="font-family: 微軟正黑體; font-size: medium" Text="送出資料" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
