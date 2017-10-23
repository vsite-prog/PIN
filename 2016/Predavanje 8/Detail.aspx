<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4> Zvijezda</h4>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="naziv" HeaderText="naziv" SortExpression="naziv" />
                <asp:BoundField DataField="galaksija" HeaderText="galaksija" SortExpression="galaksija" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SvemirConnectionString %>" DeleteCommand="DELETE FROM zvijezde
WHERE ID=@id" InsertCommand="INSERT INTO zvijezde
VALUES(@naziv, @galaksija)" SelectCommand="SELECT * FROM zvijezde WHERE id = @id" UpdateCommand="UPDATE zvijezde
SET naziv = @naziv,
galaksija = @galaksija
WHERE ID=@id">
            <DeleteParameters>
                <asp:Parameter Name="id" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="naziv" />
                <asp:Parameter Name="galaksija" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="1" Name="id" QueryStringField="id" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="naziv" />
                <asp:Parameter Name="galaksija" />
                <asp:Parameter Name="id" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
