<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <h4> Lista studenata</h4>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br /><br />
        Ime: <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox><br />
        Prezime:<asp:TextBox ID="tb_prezime" runat="server"></asp:TextBox><br />
        Faks: <asp:TextBox ID="tb_faks" runat="server"></asp:TextBox><br />
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Spremi studenta</asp:LinkButton>
    </div>
    </form>
</body>
</html>
