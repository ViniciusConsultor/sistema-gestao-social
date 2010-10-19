<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="Codificacao.aspx.cs" Inherits="SGS.View.Codificacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Criptografar" />
&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Decriptografar" />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblDecriptografado" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    Página para teste de codigo
</asp:Content>
