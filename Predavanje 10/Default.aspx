<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Filmovi</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lb_greska" runat="server" ForeColor="Red"></asp:Label>
        <h4>Filmovi</h4>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Osvježi filmove</asp:LinkButton>

        <div id="filmovi" runat="server">&nbsp;</div> 
       </div>
        <div>
            <h4>Novi film</h4> 
        <asp:Label ID="Label1" runat="server" Text="Naziv: "></asp:Label>
        <asp:TextBox ID="tb_naziv" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Država: "></asp:Label>
        <asp:TextBox ID="tb_drzava" runat="server"></asp:TextBox><br />
         <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Spremi film</asp:LinkButton>
        </div>

        


    </form>
    </body>
</html>
