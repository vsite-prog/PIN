<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h4> Studenti na faksu </h4>
    Kolegij: 
        <asp:DropDownList ID="DropDownList1" runat="server" onselectedindexchanged="DropDownList1_SelectedIndexChanged" AutoPostBack=true
            >
        </asp:DropDownList> <br /><br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <h5> Novi student</h5>
        Ime:&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 
        <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox><br />
                Prezime: 
        <asp:TextBox ID="tb_prezime" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Spremi" onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
