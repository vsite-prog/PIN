<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:testConnectionString %>" 
            SelectCommand="SELECT * FROM [student]" 
            UpdateCommand="UPDATE [student] SET [ime] = @ime, [prezime] = @prezime, [pbrRod] = @pbrRod WHERE [stud_id] = @stud_id" DeleteCommand="DELETE FROM [student]
WHERE [stud_id]=@stud_id">
            <DeleteParameters>
                <asp:Parameter Name="stud_id" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="ime" />
                <asp:Parameter Name="prezime" />
                <asp:Parameter Name="pbrRod" />
                <asp:Parameter Name="stud_id" />
            </UpdateParameters>
        </asp:SqlDataSource>
    <h4> Podaci o studentima</h4><br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="stud_id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="stud_id" HeaderText="ID" InsertVisible="False" 
                    ReadOnly="True" SortExpression="stud_id" />
                <asp:BoundField DataField="ime" HeaderText="Ime" SortExpression="ime" />
                <asp:BoundField DataField="prezime" HeaderText="Prezime" 
                    SortExpression="prezime" />
                <asp:BoundField DataField="datrod" HeaderText="Datum rodj." 
                    SortExpression="datrod" />
                <asp:BoundField DataField="pbrrod" HeaderText="Pbr" SortExpression="pbrrod" />
                <asp:BoundField DataField="prosjek" HeaderText="Prosjek" 
                    SortExpression="prosjek" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                <asp:HyperLinkField DataNavigateUrlFields="stud_id" 
                    DataNavigateUrlFormatString="detalji.aspx?id={0}" DataTextField="ime" 
                    DataTextFormatString="Detalji o {0}" HeaderText="Detalji" />
            </Columns>
            <HeaderStyle BackColor="#CCCCCC" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
