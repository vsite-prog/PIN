<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Kalkulator.aspx.cs" Inherits="Kalkulator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
    <form id="form1" runat="server">
    <div>
     <asp:TextBox ID="txtBroj1" runat="server"></asp:TextBox> &nbsp;&nbsp;
        <asp:DropDownList ID="DDLOper" runat="server">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
        </asp:DropDownList>&nbsp;&nbsp;
      <asp:TextBox ID="txtBroj2" runat="server"></asp:TextBox>
      &nbsp;&nbsp; =  &nbsp;&nbsp;
    <asp:Label ID="lblRezultat" runat="server" Text="0"></asp:Label><br /><br />
    <asp:Button ID="btnRacunaj" runat="server" Text="Računaj" 
            onclick="btnRacunaj_Click" />
    </div>
    
    </form>
    
</body>
</html>
