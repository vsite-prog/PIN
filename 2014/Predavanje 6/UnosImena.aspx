<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UnosImena.aspx.cs" Inherits="UnosImena" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:Label ID="Label2" runat="server" Text="Unesi skriveno ime:" ></asp:Label>
        <asp:TextBox ID="tb_ime" runat="server" TextMode="Password" ></asp:TextBox><br /><br />
        <asp:LinkButton ID="bt_provjeri" runat="server" OnClick="bt_provjeri_Click">Spremi</asp:LinkButton>
        <br /><br />
         <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" >Poništi</asp:LinkButton>
    </div>
    </form>
</body>
</html>
