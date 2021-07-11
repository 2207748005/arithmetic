<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>用户信息管理</h1>
            <h3>欢迎<%=Session["name"] %></h3>
            <a href="AddWebForm.aspx">添加用户</a>
            <br/>
            <asp:Label ID="Label1" runat="server" Text="模糊查询"></asp:Label>
            <asp:TextBox ID="TextBox1" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged"  runat="server"></asp:TextBox>
            <table border="1">
                <tr>
                    <td>用户昵称</td>
                    <td>状态</td>
                    <td>删除</td>
                    <td>查看状态</td>
                </tr>

                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("name").ToString() %></td>
                            <td><%# Eval("state").ToString() %></td>
                            <td> 
                                <asp:LinkButton ID="LinkButton1" OnClientClick="return confirm('确认删除吗？')"  OnCommand="LinkButton1_Command" CommandArgument='<%# Eval("id").ToString() %>' runat="server">删除</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="LinkButton2"  OnCommand="LinkButton2_Command" CommandArgument='<%# Eval("id").ToString() %>' runat="server">详情</asp:LinkButton>   
                            </td>
                            <tr />
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>
