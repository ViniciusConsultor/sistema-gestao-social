<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterCasaLar.aspx.cs" Inherits="ProjetoTela.View.CasaLar.ManterCasaLar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="lblCasaLar" runat="server" Text="Casa Lar:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Width="243px"></asp:ListBox>
        <asp:TextBox ID="TextBox2" runat="server" ontextchanged="TextBox2_TextChanged" 
            TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="Selecione"></asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:RadioButtonList>
        <br />
    </p>
</asp:Content>
