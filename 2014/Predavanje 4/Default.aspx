<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p id="p_txt" runat="server">Evo...</p>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>Zagreb</asp:ListItem>
            <asp:ListItem>Rijeka</asp:ListItem>
            <asp:ListItem>Osijek</asp:ListItem>
        </asp:DropDownList><br /><br />
        <asp:Label ID="lbl_txt" runat="server" Text="Nšta" ForeColor="#6699FF"></asp:Label><asp:TextBox ID="tb_txt" runat="server" EnableViewState="false"></asp:TextBox><br />
        <asp:Button ID="bt_nest" runat="server" Text="Pritsni me" OnClick="bt_nest_Click" />
    <br /> <br />

        <textarea id="TextArea1" cols="20" rows="10" runat="server"></textarea>
        <div>
    
    </div>
    </form>
</body>
</html>
