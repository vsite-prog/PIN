<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Studenti.aspx.cs" Inherits="Studenti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:gridview runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="ime" HeaderText="ime" SortExpression="ime" />
                    <asp:BoundField DataField="FAKS" HeaderText="FAKS" SortExpression="FAKS" />
                </Columns>
            </asp:gridview>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Napuni GridView, spoji se</asp:LinkButton>
            <br />
            <asp:GridView ID="gv_studenti" runat="server">
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentiConnectionString %>" SelectCommand="SELECT * FROM [student]"></asp:SqlDataSource>
    </form>
</body>
</html>

