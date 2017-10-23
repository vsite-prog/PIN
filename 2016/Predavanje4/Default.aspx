<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Predavanje 4</title>
  </head>
<body>
   <form id="form1" runat="server">
         <div>
       <p id="p1" runat="server"> Početni tekst</p>
       <asp:Label ID="Label1" runat="server" Text="Unesi broj 1: "
AssociatedControlID="tb_broj1"></asp:Label><asp:TextBox ID="tb_broj1"
runat="server"></asp:TextBox>
       <br />
       <br />
       <asp:Label ID="lb2" runat="server" Text="Unesi broj 2: "
/><asp:TextBox ID="tb_broj2" runat="server"></asp:TextBox>
       <br /><br />
               <asp:DropDownList ID="DropDownList1" runat="server"
OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
AutoPostBack="true">
                   <asp:ListItem>+</asp:ListItem>
                   <asp:ListItem>-</asp:ListItem>
                   <asp:ListItem>*</asp:ListItem>
                   <asp:ListItem>/</asp:ListItem>
       </asp:DropDownList> &nbsp;&nbsp;&nbsp;<asp:Literal ID="lt_rezultat"
runat="server"></asp:Literal>
       <br /><br />
        <asp:Label ID="lb_rezultat" runat="server" Text="" /><br />
       <br />
           <asp:Button ID="Button4" runat="server" Text="Izračunaj
rezultat" Height="23px" Width="93px" OnClick="Button4_Click" />
       <br />
      <asp:Button ID="Button3" runat="server" Text="Ispiši broj"
Height="23px" Width="93px" OnClick="Button3_Click" />
       <br />
       <asp:Button ID="Button1" runat="server" Text="Klikni me"
Height="23px" Width="93px" OnClick="Button1_Click" />
       <asp:Button ID="Button2" runat="server" Text="Promijeni boju"
Height="23px" Width="93px" OnClick="Button2_Click"  />
   </div>
   </form>
</body>
</html>