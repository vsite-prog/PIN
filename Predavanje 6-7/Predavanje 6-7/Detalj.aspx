<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Detalj.aspx.cs" Inherits="Detalj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4> 
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BazicaConnectionString %>" SelectCommand="Select * from Korisnik where id = 1"></asp:SqlDataSource>
                Korisnik</h4>
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                <Fields>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="ime" HeaderText="ime" SortExpression="ime" />
                    <asp:BoundField DataField="lozinka" HeaderText="lozinka" SortExpression="lozinka" />
                    <asp:BoundField DataField="faks" HeaderText="faks" SortExpression="faks" />
                </Fields>
            </asp:DetailsView>
        </div>
    </form>
</body>
</html>
