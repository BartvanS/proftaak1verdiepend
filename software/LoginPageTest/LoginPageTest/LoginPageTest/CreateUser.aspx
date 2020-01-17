<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="LoginPageTest.CreateUser" %>

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
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                        <asp:Label ID="lblUsernameTaken" runat="server" Text="Deze username is al bezet" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:Label ID="lblPasswordError" runat="server" Text="Het wachtwoord moet minimaal 4 characters hebben" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCreate" runat="server" Text="Create account" OnClick="btnCreate_Click" /></td>
                    <td>
                        <asp:Label ID="lblErrorMessage" runat="server" Text="Vul alle velden in alstublieft!" Forecolor="Red"></asp:Label></td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnLoginPage" runat="server" Text="Back to login page" OnClick="btnLoginPage_Click" />
    </form>
</body>
</html>
