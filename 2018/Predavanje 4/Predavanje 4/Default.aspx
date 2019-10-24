<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div1">
            <asp:Label ID="Label2" AssociatedControlID="tb_unos" runat="server" Text="Unesi text!"></asp:Label>
            <asp:TextBox ID="tb_unos" runat="server"></asp:TextBox>
            <asp:Literal ID="Literal1" runat="server" Text="<strong>Hi</strong>"></asp:Literal>
            <asp:Button ID="B2" runat="server" Text="Unesi" OnClick="B2_Click" />
            <br />
            <p id="par1" runat="server">POčetni tekst</p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <h4>Kalkulator</h4>
            <p>
            <asp:TextBox ID="tb_a" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
                <asp:DropDownList  AutoPostBack="true" ID ="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>+</asp:ListItem>
                    <asp:ListItem>-</asp:ListItem>
                    <asp:ListItem>*</asp:ListItem>
                    <asp:ListItem>/</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;
            <asp:TextBox ID="tb_b" runat="server"></asp:TextBox>
            &nbsp;=
            <asp:TextBox ID="tb_rez" runat="server" ReadOnly="True"></asp:TextBox>
            </p>
        </div>
    </form>
</body>
</html>
