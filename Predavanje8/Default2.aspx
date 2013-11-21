<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalji Broda</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cs_brodovi %>" InsertCommand="INSERT INTO brod
VALUES(@id, @naziv, @registracija)" ProviderName="<%$ ConnectionStrings:cs_brodovi.ProviderName %>" SelectCommand="SELECT * FROM brod
WHERE id = @id" UpdateCommand="UPDATE  brod
SET naziv = @naziv, registracija = @registracija
WHERE id = @id">
            <InsertParameters>
                <asp:Parameter Name="id" />
                <asp:Parameter Name="naziv" />
                <asp:Parameter Name="registracija" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="0" Name="id" QueryStringField="id" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="naziv" />
                <asp:Parameter Name="registracija" />
                <asp:Parameter Name="id" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <h3>Brod</h3>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="naziv" HeaderText="naziv" SortExpression="naziv" />
                <asp:BoundField DataField="registracija" HeaderText="registracija" SortExpression="registracija" />
                <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
    
    </div>
    </form>
</body>
</html>
