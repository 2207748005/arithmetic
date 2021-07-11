<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adit.aspx.cs" Inherits="WebApplication2.adit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <h1>修改用户</h1>
                <input type="hidden" id="iid" name="name" value=""  runat="server"/>
            <table>
                <tr>
                    <td>用户昵称</td>
                    <td>
                        <input type="text" id="name" name="name" runat="server" required="required" value="" />
                    </td>
                </tr>
                <tr>
                    <td>真实姓名</td>
                    <td>
                        <input type="text" id="trueName" name="trueName" runat="server" required="required" value="" />
                    </td>
                </tr>
                 <tr>
                    <td>身份证号码</td>
                    <td>
                        <input type="text" id="cardId" name="cardId" runat="server" required="required" value="" />
                    </td>
                </tr>
                <tr>
                    <td>电子邮箱</td>
                    <td>
                        <input type="text" id="email" name="email" runat="server" required="required" value="" />
                    </td>
                </tr>
                 <tr>
                    <td>联系电话</td>
                    <td>
                        <input type="text" id="telephone" name="telephone" runat="server" required="required" value="" />
                    </td>
                </tr>
                <tr>
                    <td>QQ号码</td>
                    <td>
                        <input type="text" id="qqId" name="qqId" runat="server" required="required" value="" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:LinkButton ID="LinkButton1" OnCommand="LinkButton1_Command" CommandArgument='<%# Eval("id").ToString() %>' runat="server">确认修改</asp:LinkButton>   
                    </td>
                </tr>
            </table>
        </div>
        </div>
    </form>
</body>
</html>
