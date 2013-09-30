<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zad2.aspx.cs" Inherits="Zad2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Literal ID="Literal1" Text="Odaberi grad: " runat="server"></asp:Literal>
        <asp:TextBox ID="tb_grad" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Odi tamo" 
            onclick="Button1_Click" />

    </div>
    </form>
</body>
</html>
