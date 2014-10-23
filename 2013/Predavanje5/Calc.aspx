<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calc.aspx.cs" Inherits="Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kalkulator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="lb_greska" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <asp:TextBox ID="tb_oper1" runat="server"></asp:TextBox>&nbsp;
        <asp:DropDownList ID="ddl_oper" runat="server">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
        </asp:DropDownList>&nbsp;
        <asp:TextBox ID="tb_oper2" runat="server"></asp:TextBox> &nbsp;&nbsp;
        =  &nbsp;&nbsp;
        <asp:TextBox ID="tb_rez" runat="server"></asp:TextBox><br /><br /><asp:Button ID="bt_izracun" runat="server" Text="Izračunaj" OnClick="bt_izracun_Click" />
    
    </div>
    </form>
</body>
</html>
