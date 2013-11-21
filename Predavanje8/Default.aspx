<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Brodovi prikaz</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cs_brodovi %>" ProviderName="<%$ ConnectionStrings:cs_brodovi.ProviderName %>" SelectCommand="SELECT * FROM [brod]"></asp:SqlDataSource>
        <h3>Brodovi</h3>
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="naziv" HeaderText="naziv" SortExpression="naziv" />
                <asp:BoundField DataField="registracija" HeaderText="registracija" SortExpression="registracija" />
                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="Default2.aspx?id={0}" HeaderText="Detalji" Text="Idi na detalje" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
