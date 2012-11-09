<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewState.aspx.cs" Inherits="ViewState" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tb_ime"        runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Prezime: "></asp:Label>
    <asp:TextBox ID="tb_prezime"        runat="server"></asp:TextBox><br /><br />

    <asp:Button ID="Button1" runat="server" Text="Pogodi" onclick="Button1_Click" /><br />
    <asp:Label ID="lb_pogodak" runat="server" Text=""></asp:Label>
    </div>
    
    </form>
</body>
</html>
