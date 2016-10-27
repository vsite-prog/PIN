<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lb_poruka" runat="server" Text=""></asp:Label><br /><br />
     <asp:Label ID="lb_greska" runat="server" Text=""></asp:Label><br />
    <p> POgodi broj</p>
    <asp:Label ID="Label1" runat="server" Text="Unesi broj: "></asp:Label>
    <asp:TextBox ID="tb_broj" runat="server"></asp:TextBox><br />
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Provjeri</asp:LinkButton>
</asp:Content>

