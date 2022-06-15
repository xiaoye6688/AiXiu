<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="AiXiu.WebSite.aixiu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td>手机号</td>
                <td><asp:TextBox ID="txtTel" runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>密码</td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnReg" runat="server" Text="注册" OnClick="btnReg_Click" /></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
