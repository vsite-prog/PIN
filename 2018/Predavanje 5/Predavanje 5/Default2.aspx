<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="GlavniDio" Runat="Server">
<br />
    <asp:label runat="server" text="Unesi neki broj:"></asp:label>
    <asp:textbox ID="tb_broj" runat="server"></asp:textbox>
    <br />
    <asp:button runat="server" text="Prenesi me dalje" OnClick="But_Click" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Zaglavlje" Runat="Server">
    <strong> Kraj moje trsanice</strong>
</asp:Content>

