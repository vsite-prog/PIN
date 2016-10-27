<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lb1" runat="server" Text=""></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BazaConnectionString %>" SelectCommand="SELECT * FROM [stabla]" DeleteCommand="DELETE FROM [stabla] WHERE [id] = @id" InsertCommand="INSERT INTO [stabla] ([naziv], [vrsta]) VALUES (@naziv, @vrsta)" UpdateCommand="UPDATE [stabla] SET [naziv] = @naziv, [vrsta] = @vrsta WHERE [id] = @id">
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
        </asp:SqlDataSource>
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Šifra" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="naziv" HeaderText="Naziv" SortExpression="naziv" />
                <asp:BoundField DataField="vrsta" HeaderText="Vrsta" SortExpression="vrsta" />
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="Detalji.aspx?id={0}" Text="Detalji" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
