<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body id="PageBody" runat="server">
    <form id="form1" runat="server">
      
    <div>
          <asp:Label ID="Label1" runat="server" Text="Boja:" ></asp:Label>
            <asp:dropdownlist ID="ddl_boja" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_boja_SelectedIndexChanged">
                <asp:ListItem>Standardna</asp:ListItem>
                <asp:ListItem>Žuta</asp:ListItem>
                <asp:ListItem>Zelena</asp:ListItem>
            </asp:dropdownlist>
        <br /> <br />
            
        <asp:Label ID="Label2" runat="server" Text="POgodi ime:" ></asp:Label>
        <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox><br /><br />
        <asp:LinkButton ID="bt_provjeri" runat="server" OnClick="bt_provjeri_Click">Provjeri</asp:LinkButton>
    </div>
    </form>
</body>
</html>
