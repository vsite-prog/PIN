<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Shop.aspx.cs" Inherits="Shop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h4>Kupovina</h4>
        <asp:GridView ID="gv_kupovina" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gv_kupovina_RowCancelingEdit" OnRowEditing="gv_kupovina_RowEditing" OnRowUpdating="gv_kupovina_RowUpdating" OnRowCommand="gv_kupovina_RowCommand">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="True" />
                 <asp:BoundField DataField="naziv" HeaderText="NAZIV" ReadOnly="True" />
                <asp:BoundField DataField="cijena" HeaderText="CIJENA" ReadOnly="True" DataFormatString="{0:c}" />
                <asp:BoundField DataField="kolicina" HeaderText="KOLIČINA" />

                <asp:CommandField ShowEditButton="True" />

                <asp:ButtonField CommandName="dodaj" InsertVisible="False" Text=" + 1 " />

            </Columns>

        </asp:GridView>
        <br />
        <h4>Unos nove stavke</h4>
        <asp:Label ID="Label1" runat="server" Text="Naziv :"></asp:Label>
        <asp:TextBox ID="tb_naziv" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Cijena : "></asp:Label>
        <asp:TextBox ID="tb_cijena" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Količina : "></asp:Label>
        <asp:TextBox ID="tb_kolicina" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Spremi u košaricu" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
