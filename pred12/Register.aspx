<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h4> Registracijska forma</h4>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="Korisničko ime:"></asp:Label>
        <asp:TextBox ID="tb_kime" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Kor. ime mora biti uneseno!" ControlToValidate="tb_kime">*</asp:RequiredFieldValidator><br />
        <asp:Label ID="Label2" runat="server" Text="Lozinka: "></asp:Label>
        <asp:TextBox ID="tb_lozinka" runat="server"></asp:TextBox><asp:RequiredFieldValidator
            ID="RequiredFieldValidator2" runat="server" ErrorMessage="Lozinka nije unesena!" ControlToValidate="tb_lozinka">*</asp:RequiredFieldValidator><br />
        <asp:Label ID="Label3" runat="server" Text="Ponovite lozinku:"></asp:Label>
        <asp:TextBox ID="tb_lozinka2" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="Lozinke moraju biti iste!" ControlToCompare="tb_lozinka" ControlToValidate="tb_lozinka2">*</asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Registriraj se" 
            onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
