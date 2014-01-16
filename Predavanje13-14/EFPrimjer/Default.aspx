<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Entity Framework and LINQ</title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <h4> Životinje</h4>
        <asp:DropDownList ID="ddl_zoo" runat="server" 
            onselectedindexchanged="ddl_zoo_SelectedIndexChanged" AutoPostBack=true>
        </asp:DropDownList><br /><br />

    <asp:gridview id="gv_zivotinje" runat="server" ></asp:gridview><br /><br />
    <h5>Nova životinja:</h5>
    Ime: 
        <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox><br />
    Vrsta: 
        <asp:TextBox ID="tb_vrsta" runat="server"></asp:TextBox><br /><br />
   <asp:Button ID="Button1" runat="server" Text="Spremi" onclick="Button1_Click" /> </div>
    </form>
    
</body>
</html>
