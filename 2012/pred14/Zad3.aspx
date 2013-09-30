<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zad3.aspx.cs" Inherits="Zad3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddl_vrste" runat="server"  AutoPostBack=true
            onselectedindexchanged="ddl_vrste_SelectedIndexChanged">
        </asp:DropDownList>
        <br />

        <asp:GridView ID="gv_zivotinje" runat="server">
    </asp:GridView>
    </div>
    </form>
</body>
</html>
