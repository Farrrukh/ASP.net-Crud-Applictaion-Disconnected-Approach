<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView CssClass="table table-bordered table-light table-hover" ID="GridView1" runat="server">
        </asp:GridView>
        <table  class="table table-danger table-hover">
            <tr>
                <td rowspan="4">
                    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
                </td>
                <td>
                    Student Name
                </td>
                <td>
                    <asp:TextBox CssClass="form-control" ID="txtStudName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Student Email
                </td>
                <td>
                    <asp:TextBox CssClass="form-control" TextMode="Email" ID="txtStudEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Student Contact No
                </td>
                <td>
                    <asp:TextBox CssClass="form-control" ID="txtContactNo" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Student Address
                </td>
                <td>
                    <asp:TextBox CssClass="form-control" TextMode="MultiLine" ID="txtStudAddress" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button CssClass="btn badge-dark" ID="btnDelete" runat="server" Text="Delete Record" OnClick="btnDelete_Click" />
                </td>
                <td></td>
                <td>
                    <asp:Button CssClass="btn badge-dark" ID="btnAdd" runat="server" Text="Add Student" OnClick="btnAdd_Click" /></td>
                <td>
                    <asp:Button CssClass="btn badge-dark" ID="btnUpdate" runat="server" Text="Update Student" OnClick="btnUpdate_Click" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
