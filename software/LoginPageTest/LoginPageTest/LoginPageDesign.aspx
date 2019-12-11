<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPageDesign.aspx.cs" Inherits="LoginPageTest.LoginPageDesign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
                    <td>
                        <asp:Button ID="btnCreateNew" runat="server" Text="Register" OnClick="btnCreateNew_Click" />
                        <asp:Label ID="lblErrorMessage" runat="server" Text=" Foute inloggegevens!" Forecolor="Red"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
