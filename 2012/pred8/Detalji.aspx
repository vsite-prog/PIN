<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Detalji.aspx.cs" Inherits="Detalji" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:testConnectionString %>" DeleteCommand="DELETE FROM [student]
WHERE stud_id = @stud_id" SelectCommand="SELECT * FROM student 
WHERE [stud_id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="stud_id" />
            </DeleteParameters>
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="1" Name="id" QueryStringField="id" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
            AutoGenerateRows="False" DataKeyNames="stud_id" DataSourceID="SqlDataSource1">
            <Fields>
                <asp:BoundField DataField="stud_id" HeaderText="stud_id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="stud_id" />
                <asp:BoundField DataField="ime" HeaderText="ime" SortExpression="ime" />
                <asp:BoundField DataField="prezime" HeaderText="prezime" 
                    SortExpression="prezime" />
                <asp:BoundField DataField="datrod" HeaderText="datrod" 
                    SortExpression="datrod" />
                <asp:BoundField DataField="pbrrod" HeaderText="pbrrod" 
                    SortExpression="pbrrod" />
                <asp:BoundField DataField="prosjek" HeaderText="prosjek" 
                    SortExpression="prosjek" />
                <asp:CommandField ShowDeleteButton="True" />
            </Fields>
        </asp:DetailsView>
    </div>
    </form>
</body>
</html>
