<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Kupovina.aspx.cs" Inherits="Kupovina" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h4> Kupljeni artikli </h4>
        <asp:GridView ID="gv_kupovina" runat="server" AutoGenerateColumns="False" 
            onrowcommand="gv_kupovina_RowCommand" onrowdeleting="gv_kupovina_RowDeleting">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Broj" />
                <asp:BoundField DataField="Naziv" HeaderText="Naziv" />
                <asp:BoundField DataField="Cijena" DataFormatString="{0:C}" 
                    HeaderText="Cijena" />
                <asp:BoundField DataField="Kolicina" HeaderText="Količina" />
                <asp:BoundField DataField="Ukupno" DataFormatString="{0:C}" 
                    HeaderText="Ukupno" />
                <asp:ButtonField CommandName="Dodaj" Text="Povecaj +1" />
                <asp:CommandField DeleteText="Brisi" ShowDeleteButton="True" />
            </Columns>
            <HeaderStyle BackColor="#FF66CC" />
        </asp:GridView>
        <br /><br />
        <asp:Button ID="bt_knjiga" runat="server" Text="Kupi knjigu" 
            onclick="bt_knjiga_Click" />&nbsp;&nbsp;&nbsp;
        <asp:Button ID="br_cd" runat="server" Text="Kupi CD" onclick="br_cd_Click" />

        <br />
        <br />
        Količina: <asp:TextBox ID="tb_kolicina" runat="server" 
            Text="1" Width="30px"></asp:TextBox>

    </div>
    
    </form>
</body>
</html>
