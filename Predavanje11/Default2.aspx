<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv_kosarica" runat="server" AutoGenerateColumns="False" OnRowEditing="gv_kosarica_RowEditing" OnRowCancelingEdit="gv_kosarica_RowCancelingEdit" OnRowUpdating="gv_kosarica_RowUpdating" OnRowCommand="gv_kosarica_RowCommand">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="true" />
                <asp:BoundField DataField="Naziv" HeaderText="Naziv" ReadOnly="true" />
                <asp:BoundField DataField="Cijena" DataFormatString="{0:c}" HeaderText="Cijena" ReadOnly="true"/>
                <asp:BoundField DataField="Kolicina" HeaderText="Količina" HtmlEncodeFormatString="False" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:ButtonField CommandName="Uvecaj" Text="+ 1" />
            </Columns>
        </asp:GridView>
        <br />
    <h4> Novi artikal </h4>
        <asp:Label ID="lb_greska" runat="server" ForeColor="Red" Text=""></asp:Label><br />
        <asp:Label ID="Label1" runat="server" Text="Naziv:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="tb_naziv" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Cijena:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="tb_cijena" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Količina"></asp:Label>
        &nbsp;
        <asp:TextBox ID="tb_kolicina" runat="server"></asp:TextBox><br /><br />

        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Spremi</asp:LinkButton>
    </div>
    </form>
</body>
</html>
