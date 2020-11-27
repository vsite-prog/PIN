<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Studenti.aspx.cs" Inherits="Studenti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4> Lista studenata </h4>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Ime" HeaderText="Ime" SortExpression="Ime" />
                <asp:BoundField DataField="Prezime" HeaderText="Prezime" SortExpression="Prezime" />
                <asp:BoundField DataField="Grad" HeaderText="Grad" SortExpression="Grad" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <hr />
        <asp:GridView ID="gv_studenti" runat="server" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KonekcijskiTekst %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
    </form>
</body>
</html>
