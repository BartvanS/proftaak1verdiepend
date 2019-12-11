<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="LoginPageTest.Dashboard" %>

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
                    <td><asp:Label ID="lblUserName" runat="server" Text=""></asp:Label></td>
                    </tr>
                <tr>
                    <td>
        <asp:Label ID="lblCredits" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
                        <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
    </form>
</body>
</html>
