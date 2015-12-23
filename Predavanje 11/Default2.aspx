<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4> Kupovina</h4>
        <asp:GridView ID="gv_kupovina" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gv_kupovina_RowCancelingEdit" OnRowCommand="gv_kupovina_RowCommand" OnRowDeleting="gv_kupovina_RowDeleting" OnRowEditing="gv_kupovina_RowEditing" OnRowUpdating="gv_kupovina_RowUpdating">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="Naziv" HeaderText="Naziv" ReadOnly="True" />
                <asp:BoundField DataField="Kolicina" HeaderText="Količina" />
                <asp:BoundField DataField="Cijena" HeaderText="Cijena" ReadOnly="True" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:ButtonField Text="Količina++"  CommandName="plusplus"/>
            </Columns>
        </asp:GridView>
    <h4>Unesi artikal</h4>
         <asp:Label ID="lb_greska" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Label1" runat="server" Text="Naziv: "></asp:Label>
        <asp:TextBox ID="tb_naziv" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="KOličina: "></asp:Label>
        <asp:TextBox ID="tb_kolicina" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Cijena: "></asp:Label>
        <asp:TextBox ID="tb_cijena" runat="server"></asp:TextBox><br /><br />
        <asp:LinkButton ID="lb_spremi" runat="server" OnClick="lb_spremi_Click">Spremi me</asp:LinkButton>
    </div>
    </form>
</body>
</html>
