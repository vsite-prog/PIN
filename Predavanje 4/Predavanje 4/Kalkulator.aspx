<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Kalkulator.aspx.cs" Inherits="Kalkulator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
                        <h1> Kalkulator </h1>
                        <p> 
                            <asp:TextBox ID="broj_1" runat="server"></asp:TextBox>
                            <asp:DropDownList ID="ddl_operand" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                                <asp:ListItem>+</asp:ListItem>
                                <asp:ListItem>-</asp:ListItem>
                                <asp:ListItem>*</asp:ListItem>
                                <asp:ListItem>/</asp:ListItem>
                            </asp:DropDownList>
                            <asp:TextBox ID="broj_2" runat="server"></asp:TextBox>
                            <asp:Label ID="labela_rezultata" runat="server" Text="=0"></asp:Label>
                        </p>

        </div>
    </form>
</body>
</html>
