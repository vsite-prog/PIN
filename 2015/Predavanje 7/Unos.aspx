<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Unos.aspx.cs" Inherits="Unos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lb_greska" runat="server" Text=""></asp:Label><br />
     <asp:Label ID="Label1" runat="server" Text="Unesi tajni broj: "></asp:Label>
    <asp:TextBox ID="tb_broj" runat="server" TextMode="Password"></asp:TextBox><br />
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Spremi novi broj</asp:LinkButton>
</asp:Content>

