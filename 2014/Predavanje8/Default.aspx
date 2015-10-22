<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <div>
    <asp:sqldatasource ID="ds1" runat="server" ConnectionString="<%$ ConnectionStrings:ZivotinjeConnectionString %>" ProviderName="<%$ ConnectionStrings:ZivotinjeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [zivotinje]" DeleteCommand="DELETE FROM [zivotinje] WHERE [id] = @id" InsertCommand="INSERT INTO [zivotinje] ([naziv], [vrsta]) VALUES (@naziv, @vrsta)" UpdateCommand="UPDATE [zivotinje] SET [naziv] = @naziv, [vrsta] = @vrsta WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="naziv" Type="String" />
            <asp:Parameter Name="vrsta" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="naziv" Type="String" />
            <asp:Parameter Name="vrsta" Type="String" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
        </asp:sqldatasource>
        <asp:GridView ID="gv_zivotinje" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ds1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#CC99FF" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Šifra" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="naziv" HeaderText="Naziv" SortExpression="naziv" />
                <asp:BoundField DataField="vrsta" HeaderText="Živ. Vrsta" SortExpression="vrsta" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField SelectText="Odaberi" ShowSelectButton="True" />
                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="Detail.aspx?id={0}" Text="Detalji" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
