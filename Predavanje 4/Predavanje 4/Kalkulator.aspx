<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Kalkulator.aspx.cs" Inherits="Kalkulator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Broj A:"></asp:Label>
            <asp:TextBox ID="tb_a" runat="server"></asp:TextBox> &nbsp;&nbsp;
            <asp:DropDownList ID="ddl_operator" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_operator_SelectedIndexChanged">
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>  &nbsp;&nbsp;
          <asp:Label ID="Label2" runat="server" Text="Broj B:" AssociatedControlID="tb_b"></asp:Label>
            <asp:TextBox ID="tb_b" runat="server"></asp:TextBox> &nbsp;&nbsp;
            <span> = </span> &nbsp;&nbsp;
          <asp:TextBox ID="tb_rezultat" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
