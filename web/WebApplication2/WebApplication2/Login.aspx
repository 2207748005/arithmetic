<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form  id="form1" runat="server">
        <div>
            <p>用户名 <input type="text" id="name"  value=""  runat="server"/></p>
            <p>用户名 <input type="text" id="password"  value=""  runat="server" /></p>
            <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="提交" />
        </div>
    </form>
</body>
</html>
