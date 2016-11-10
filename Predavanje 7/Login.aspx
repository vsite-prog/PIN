<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          
        <asp:Label ID="lb_otvaranje" runat="server" Text=""></asp:Label><br />  
    <asp:Label ID="lb_greska" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="tb_uname" runat="server"></asp:TextBox>
        <br />
            
        <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="tb_psw" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Prijava</asp:LinkButton>
        <br /><br />
         <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Boom</asp:LinkButton>
            
    
    </div>
    </form>
</body>
</html>
