<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zvijezde</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4> Lista zvijezda</h4>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="#FF6666" />
            <Columns>
                                <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="naziv" HeaderText="Naziv" SortExpression="naziv" />
                <asp:BoundField DataField="galaksija" HeaderText="Galaksija" SortExpression="galaksija" />
                                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="Detail.aspx?id={0}" Text="KLikni me" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SvemirConnectionString %>" SelectCommand="SELECT * FROM [zvijezde]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
