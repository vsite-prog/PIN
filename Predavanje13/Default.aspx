<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h4>Skijališta</h4>
        <p>
        <asp:Label ID="Label2" runat="server" Text="Država: "></asp:Label>
        <asp:DropDownList ID="ddl_drzave" runat="server" OnSelectedIndexChanged="ddl_drzave_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </p>
        <p>&nbsp;</p>
        <asp:GridView ID="gv_ski" runat="server"></asp:GridView>
        <<h4> Novo skijalište</h4>
        <asp:Label ID="Label1" runat="server" Text="Naziv: "></asp:Label>
        <asp:TextBox ID="tb_naziv" runat="server"></asp:TextBox><br />
        <br />
        <br />
        <asp:Button ID="Unesi" runat="server" Text="Unesi" OnClick="Unesi_Click" />
    </div>
    </form>
</body>
</html>
