<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<script runat="server">
    protected void btnPromijeni_Click(object sender, EventArgs e)
    {
        if (lbl1.ForeColor == System.Drawing.Color.Red)
            lbl1.ForeColor = System.Drawing.Color.Black;
        else
            lbl1.ForeColor = System.Drawing.Color.Red;

        ltPunoIme.Text = tbIme.Text + " " + tbPrezime.Text;



    }

</script>
    <form id="form1" runat="server">
    <div>
    <span id="span1" runat="server"> Ovo je moj text
        </span><br /><br />
        <asp:label runat="server" text="Ime:" ID="lbl1"></asp:label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbIme" runat="server"></asp:TextBox>
        <br /><br /><asp:label runat="server" text="Prezime:" ID="Label1"></asp:label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbPrezime" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnPromijeni"
            runat="server" Text="Promijeni" onclick="btnPromijeni_Click" /><br /> <br />
            <asp:Literal ID="ltPunoIme" 
                runat="server" Mode=Encode></asp:Literal>
    
    </div>
    </form>
</body>
</html>
