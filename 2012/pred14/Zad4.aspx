<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zad4.aspx.cs" Inherits="Zad4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Ime: 
        <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox><br />
            lozinka: 
        <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="prijava" 
            onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
