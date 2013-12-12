<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Artikli.aspx.cs" Inherits="Artikli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Artikli</title>
</head>
<body>
    <form id="form1" runat="server">
<div>
    <h4> Vaša košarica </h4>
        <asp:GridView ID="gv_artikli" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gv_artikli_RowCancelingEdit" OnRowEditing="gv_artikli_RowEditing" OnRowUpdating="gv_artikli_RowUpdating" OnRowCommand="gv_artikli_RowCommand" OnRowDeleting="gv_artikli_RowDeleting" >
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="Naziv" HeaderText="Naziv" ReadOnly="True"/>
                <asp:BoundField DataField="Cijena" DataFormatString="{0:c}" HeaderText="Cijena" ReadOnly="True"/>
                <asp:BoundField DataField="Kolicina" HeaderText="Količina" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:ButtonField Text="Povecaj za 1" ButtonType="Button" CommandName="Dodaj" />
            </Columns>
    </asp:GridView>
        <br /><br />
        ID: <asp:TextBox ID="tb_id" runat="server"></asp:TextBox><br />
        Naziv: <asp:TextBox ID="tb_naziv" runat="server"></asp:TextBox><br />
        Cijena: <asp:TextBox ID="tb_cijena" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="bt_artikl" runat="server" Text="Kreiraj artikl" OnClick="bt_artikl_Click"  />
    </div>
    </form>
</body>
</html>
