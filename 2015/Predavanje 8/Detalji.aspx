<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Detalji.aspx.cs" Inherits="Detalji" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BazaConnectionString %>" DeleteCommand="DELETE FROM stabla
WHERE id=@id" InsertCommand="INSERT INTO stabla VALUES(@naziv, @vrsta)" SelectCommand="SELECT * FROM stabla WHERE id=@id" UpdateCommand="UPDATE stabla 
SET naziv = @naziv,
vrsta = @vrsta
WHERE id=@id">
            <DeleteParameters>
                <asp:Parameter Name="id" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="naziv" />
                <asp:Parameter Name="vrsta" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="id" QueryStringField="id" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="naziv" />
                <asp:Parameter Name="vrsta" />
                <asp:Parameter Name="id" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    <asp:detailsview runat="server" height="50px" width="125px" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
        <Fields>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="naziv" HeaderText="naziv" SortExpression="naziv" />
            <asp:BoundField DataField="vrsta" HeaderText="vrsta" SortExpression="vrsta" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
        </asp:detailsview>
    </div>
    </form>
</body>
</html>
