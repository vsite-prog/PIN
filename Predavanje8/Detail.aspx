<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZivotinjeConnectionString %>" DeleteCommand="DELETE FROM [zivotinje] WHERE [id] = @id" InsertCommand="INSERT INTO [zivotinje] ([naziv], [vrsta]) VALUES (@naziv, @vrsta)" ProviderName="<%$ ConnectionStrings:ZivotinjeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [zivotinje] WHERE ([id] = @id)" UpdateCommand="UPDATE [zivotinje] SET [naziv] = @naziv, [vrsta] = @vrsta WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="naziv" Type="String" />
                <asp:Parameter Name="vrsta" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="1" Name="id" QueryStringField="id" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="naziv" Type="String" />
                <asp:Parameter Name="vrsta" Type="String" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="naziv" HeaderText="naziv" SortExpression="naziv" />
                <asp:BoundField DataField="vrsta" HeaderText="vrsta" SortExpression="vrsta" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowInsertButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Fields>
        </asp:DetailsView>
    </form>
</body>
</html>
