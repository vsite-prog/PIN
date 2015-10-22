<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>prva</title>
</head>
<body>
    <h4> Prva stranica </h4>
    <form id="form1" runat="server">
    <div>
        <p id="p1" runat="server">Dobar dan!</p><br />
        <asp:label ID="Label1" runat="server" text="Unesi nešto: "></asp:label>
        <asp:TextBox ID="tb_nesto" runat="server"></asp:TextBox><br />
        <asp:Button ID="bt_promijeni" runat="server" Text="Vidi što je upisano" OnClick="bt_promijeni_Click" />
    </div>
    </form>
</body>

</html>
