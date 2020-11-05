<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Predavanje 5</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2> Predavanje 5</h2>
        <asp:Label ID="labela1" runat="server" Text="Label"></asp:Label><br />
        <div>
            <asp:Button ID="dugme1" runat="server" Text="Button" OnClick="dugme1_Click"/>
            <br />
            <br />
            <br />
            <asp:TextBox ID="tb_unos" runat="server"></asp:TextBox>         
            <asp:Button ID="Button1" runat="server" Text="Pošalji tekst" OnClick="dugme2_Click"/>

        </div>
        
    </form>
</body>
</html>
