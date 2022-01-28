<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesLogin.aspx.cs" Inherits="SalesmanApplication.SalesLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Salesman Login Page</title>
    <link rel="stylesheet" href="Content/MyStyleSheet.css" />
    <style>
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
            <h1>Salesman Login</h1> 
            <table>
                <tr>
                    <td>Salesman ID</td>
                    <td>
                        <asp:TextBox ID="txtSalesmanID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnLogin"  Text="Login" runat="server" OnClick="btnLogin_Click" Width="185px"/>
                   </td>
                </tr>
            </table>
            <hr />
            <asp:Label Text="" ID="lblResult" runat="server"></asp:Label>
            <hr />
        </div>
        <h2>Salesman Details</h2>
        <asp:GridView ID="gvSalesmanInfo" runat="server"></asp:GridView>
    </form> 
</body>
</html>
