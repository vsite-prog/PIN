<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    
    <form id="form1" runat="server">
    <div><asp:label runat="server" id= "lb_postback" text=""></asp:label><asp:Literal ID="Literal1" runat="server" Text=".otvaranje stranice"></asp:Literal><br /><br />
    <a href="#" id="a1" runat="server"> Link</a>
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click"  />
    </div>
    </form>
</body>
</html>
