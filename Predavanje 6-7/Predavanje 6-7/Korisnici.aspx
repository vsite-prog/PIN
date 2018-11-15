<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Korisnici.aspx.cs" Inherits="Korisnici" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BazicaConnectionString %>" SelectCommand="SELECT * FROM [Korisnik]"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="ime" HeaderText="ime" SortExpression="ime" />
                    <asp:BoundField DataField="lozinka" HeaderText="lozinka" SortExpression="lozinka" />
                    <asp:BoundField DataField="faks" HeaderText="faks" SortExpression="faks" />
                    <asp:HyperLinkField Text="Vidi detalje" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
