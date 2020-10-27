<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body >
    <form id="form1" runat="server"> 
        <div runat="server" id="div1">
            <p runat="server" id="p1"> POčetni tekst</p>
            <asp:Literal ID="Literal1" runat="server" Text="Lteral tekst"></asp:Literal><br />
            <asp:Label runat="server" Text="Labela za promjenu" ID="mojaLabela" ForeColor="Red" /><br />
             <asp:Label runat="server" Text="Unos teksta: "   AssociatedControlID="tb_uneseni_text"/>
            <asp:TextBox ID="tb_uneseni_text" runat="server"></asp:TextBox> &nbsp;&nbsp;&nbsp;

            <asp:Button ID="Button1" runat="server" Text="Promijeni labelu"  OnClick="Button1_Click"  />
            <br />
            <br />
            
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Button2_Click" >Odi na kalkulator</asp:LinkButton>
            <asp:Label ID="lb_za_igru" runat="server" Text=""></asp:Label>
        </div>
        
    </form>
</body>
</html>
