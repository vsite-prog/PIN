<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title> Idemo kolacici</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lb_appCnt" runat="server" Text="Label"></asp:Label>. otvaranje ove stranice!!!
    <br /><br />
    
    
    <asp:Label ID="Label1" runat="server" Text="Odaberi jezik: "></asp:Label>
    <asp:DropDownList runat="server" id="DDLJezik" AutoPostBack=true
        onselectedindexchanged="DDLJezik_SelectedIndexChanged" style="height: 22px">
        <asp:ListItem Value="HR">Hrvatski</asp:ListItem>
        <asp:ListItem Value="EN">Engleski</asp:ListItem>
        <asp:ListItem Value="DE">Njemački</asp:ListItem>
    </asp:DropDownList>
    <br /><br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Cookie.aspx">Stranica sa kolacima...</asp:HyperLink>
    
</asp:Content>

