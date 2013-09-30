<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cookie.aspx.cs" Inherits="Cookie" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title> Kolaciii</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Odaberi jezik: "></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" 
    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Value="HR">Hrvatski</asp:ListItem>
        <asp:ListItem Value="EN">Engleski</asp:ListItem>
        <asp:ListItem Value="DE">Njemački</asp:ListItem>
    </asp:DropDownList>
</asp:Content>

