<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee</title>

    <link href="images/apple-icon.png" rel="icon" type="image/png" />
    <link href="images/favicon.png" rel="shortcut icon" type="image/png" />
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/style.css" />
    <!-- Responsive stylesheet -->
    <link rel="stylesheet" href="css/responsive.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-md-offset-4">
                    <table style="width: 69%; align-self: center; height: 167px;">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Label">Name</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                            <br />
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Label">Mobile</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtMobile" CssClass="form-control" runat="server"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Label">Email</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>

                            </td>
                        </tr>
                        <br />
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Label">Age</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtAge" CssClass="form-control" runat="server"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Label">Department</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDepartment" CssClass="form-control" runat="server"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Label">Salery</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSalery" CssClass="form-control" runat="server"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="Label">Address</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtAddress" CssClass="form-control" runat="server"></asp:TextBox>

                            </td>
                        </tr>

                        <tr>
                            <td class="glyphicon">



                                <asp:Label ID="lblMsg" runat="server" Style="color: green"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" OnClick="Button1_Click" Text="Button" />
                    <asp:Button ID="update" CssClass="btn btn-success" runat="server" Text="update" OnClick="update_Click" />
                </div>
            </div>
        </div>


        <!----------- Reapter start ------------>
        <div class="row">
            <div class="col-lg-10 col-md-offset-1">
                <section class="panel">
                    <table class="table table-striped table-advance table-hover">
                        <tbody>
                            <tr>
                                <th><i></i>ID</th>
                                <th><i></i>Name</th>
                                <th><i></i>Mobile</th>
                                <th><i></i>Email</th>
                                <th><i></i>Age</th>
                                <th><i></i>Department</th>
                                <th><i></i>Salery</th>
                                <th><i></i>Address</th>
                                <th><i></i>Action</th>
                            </tr>
                            <asp:Repeater ID="rpEmployee" runat="server"  onitemcommand="rpEmployee_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("id") %></td>
                                        <td><%#Eval("name") %></td>
                                        <td><%#Eval("mobile") %></td>
                                        <td><%#Eval("email") %></td>
                                         <td><%#Eval("age") %></td>
                                         <td><%#Eval("department") %></td>
                                         <td><%#Eval("salery") %></td>
                                         <td><%#Eval("address") %></td>
                                        <td>
                                            <div class="btn-group">
                                                <asp:LinkButton class="btn btn-success" runat="server" ID="btnEdit" CommandArgument='<%#Eval("id") %>' CommandName="edit"><i class="icon_check_alt2">Edit</i></asp:LinkButton>
                                                <asp:LinkButton ID="btnDelete" runat="server" CommandArgument='<%#Eval("id") %>' CommandName="delete" class="btn btn-danger"><i class="icon_close_alt2">Delete</i></asp:LinkButton>
                                            </div>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                        </tbody>
                    </table>
                </section>
            </div>
        </div>
    </form>
</body>
</html>
