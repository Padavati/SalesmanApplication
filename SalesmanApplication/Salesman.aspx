<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salesman.aspx.cs" Inherits="SalesmanApplication.Salesman" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Salesman Registration</title>
    <script>
        function validate() {
            var flag = false;
            var salesman_id = document.getElementById("<%=txtSalesmanID.ClientID%>").value;
            var name = document.getElementById("<%=txtSalesmanName.ClientID%>").value;
            var city = document.getElementById("<%=txtSalesmanCity.ClientID%>").value;
            var commision = document.getElementById("<%=txtCommission.ClientID%>").value;
            var pwd = document.getElementById("<%=txtNewPassword.ClientID%>").value;
            if (salesman_id == '')
                alert('Salesman ID can not be empty');
            else if (name == '')
                alert('Salesman Name can not be empty');
            else if (city == '')
                alert('Salesman City can not be empty');
            else if (commission == "")
                alert('Salesman Commission can not be empty');
            else if (pwd == '')
                alert('New Password can not be empty');
            else
                flag = true;
            return flag;
        }
    </script>
      <style >
        body{background-image:url(SalesPics/Salesman.png);
             background-size:100% 100%;
              background-attachment:fixed;
             background-repeat:no-repeat;
        }
        #lblResult{color:darkblue;}
    </style>
    <link rel="stylesheet" href="Content/MyStyleSheet.css" />
    
    
    
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h1>Salesman Registration</h1>
            <table>
                <tr>                    
                  <td>Salesman ID</td>
                    <td><asp:TextBox ID="txtSalesmanID" runat="server" Width="292px"></asp:TextBox></td>                                  
                </tr>
                <tr>
                    <td>Salesman Name</td>
                    <td><asp:TextBox ID="txtSalesmanName" runat="server" Width="291px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman City</td>
                    <td><asp:TextBox ID="txtSalesmanCity" runat="server" Width="291px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman Commission</td>
                    <td><asp:TextBox ID="txtCommission" runat="server" Width="290px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>New Password</td>
                    <td>
                        <asp:TextBox ID="txtNewPassword" TextMode="Password" runat="server" Width="291px"></asp:TextBox>

                    </td>
                </tr>
                
                <tr>
                    <td></td>
                    <td class="auto-style1">
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnclientClick="return validate()" OnClick="btnSave_Click" />
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                    </td>
                </tr>
            </table>
            <hr />
            <asp:Label Text="" ID="lblResult" runat="server"></asp:Label>
            <hr />
            <h1>Salesman Details</h1>
            <asp:GridView ID="gvSalesmanInfo" runat="server" ></asp:GridView>
        </div>
            
    </form>
    
</body>
</html>
