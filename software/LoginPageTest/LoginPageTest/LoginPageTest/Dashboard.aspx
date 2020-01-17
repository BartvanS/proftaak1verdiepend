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
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
        </div>       
        <br />
        <div>
          <h3>Trucjes:  <asp:Label ID="lblCredditError" runat="server" Text="You need more credits for this trick!" Forecolor="Red"></asp:Label>
            </h3>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnTrucA" runat="server" Text="TrucA" OnClick="Truc_click" /></td>
                       <td> <asp:Button ID="btnTrucB" runat="server" Text="TrucB" OnClick="Truc_click" /></td>                    
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnTrucC" runat="server" Text="TrucC" Width="64px" OnClick="Truc_click" /></td>
                       <td> <asp:Button ID="btnTrucD" runat="server" Text="TrucD" Width="64px" OnClick="Truc_click" /></td>                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
