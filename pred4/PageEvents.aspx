<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PageEvents.aspx.cs" Inherits="PageEvents" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>Opcija1</asp:ListItem>
        <asp:ListItem>Opcija2</asp:ListItem> 
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Pritisni" 
        onclick="Button1_Click" />

    <br /> <br />
    <asp:TextBox ID="txtEvents" runat="server" TextMode="MultiLine" Height=300px Width=200px></asp:TextBox>
    <div>
    
    </div>
    </form>
</body>
</html>
