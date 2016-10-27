<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prva</title>
    <script runat="server">
        /*
        protected void Button1_Click(object sender, EventArgs e)
        {
            lb_nesto.Text = "POslali ste text: " + txt1.Value;
        }
        */
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lb_nesto" runat="server" Text=""></asp:Label><br />

        <p id="p1"> Evo nas u prvoj ASP-NET stranici!</p>
        Unesi tekst: <input type="text" name="txt1" id="txt1" runat="server"/><br />
        <br />
&nbsp;
        <!--<input type="submit" value="Pošalji" />-->
        <asp:Button ID="Button1" runat="server" Text="Pošalji" OnClick="Button1_Click" ToolTip="POšalji" />
    </div>
    </form>
</body>
</html>
