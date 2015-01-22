<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      
         <asp:Label ID="Label2" runat="server" Text="Država: "></asp:Label>
        <asp:DropDownList ID="ddl_drzava" runat="server" OnSelectedIndexChanged="ddl_drzava_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        <br />  <h4> Gradovi</h4><br />
        <asp:GridView ID="gv_gradovi" runat="server"></asp:GridView>
        <h4> Novi grad</h4>
        <asp:Label ID="Label1" runat="server" Text="Grad: "></asp:Label>
        <asp:TextBox ID="tb_grad" runat="server"></asp:TextBox>
        <br />
       <br />
        <asp:Button ID="Button1" runat="server" Text="Spremi" OnClick="Button1_Click" />
    <div>
    
    </div>
    </form>
</body>
</html>
