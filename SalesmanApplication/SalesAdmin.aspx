<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesAdmin.aspx.cs" Inherits="SalesmanApplication.SalesAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/MySteelSheet.css" />
    <style >
        body{background-image:url(SalesPics/Salesman.png);
             background-size:100% 100%;
              background-attachment:fixed;
             background-repeat:no-repeat;

        }
        #lblResult{color:red;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Admin Page</h1>
            <table>
                <tr>
                    <td>User ID</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td class="auto-style1">
                        <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" Width="186px" />
                    </td>
                </tr>
            </table>
            <hr />
                <asp:Label Text="" ID="lblResult" runat="server"></asp:Label>
                <hr />
        </div>
    </form>
</body>
</html>
