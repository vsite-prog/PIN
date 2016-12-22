<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Vlasnik:         <asp:DropDownList ID="ddl_vlasnici" runat="server" AutoPostBack="true"></asp:DropDownList>
        <br />
        <h4> Unesi novog psa</h4>
        <asp:Label ID="Label1" runat="server" Text="UNesi ime psa: "></asp:Label>
        <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Spremi</asp:LinkButton>
        <h4> Lista pasa</h4>
        <p> &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    
    </div>
    </form>
</body>
</html>
