<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterFinancas.aspx.cs" Inherits="SGS.View.Financas.ManterFinancas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style8
        {
            width: 171px;
            text-align: right;
            font-size: small;
        }
        .style9
        {
            width: 243px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<span class="style4"><strong> 
        <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label>
    </strong> &nbsp;</span><br />
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; <asp:Label ID="lblDescricao" runat="server" Text=""></asp:Label> 
        
        <br /><br />
</span>

<table class="style6">
            <tr>
                <td class="style8" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Casa Lar</td>
                <td class="style9">
                    <asp:DropDownList ID="ddlCasaLar" runat="server" Height="22px" Width="148px" 
                        Enabled="False">
                        <asp:ListItem Selected="True">Reviver ONG</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Tipo Lançamento</td>
                <td class="style9">
                    <asp:DropDownList ID="ddlTipoLancamento" runat="server" Height="22px" 
                        Width="148px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Receita</asp:ListItem>
                        <asp:ListItem>Despesa</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data Lançamento</td>
                <td class="style9">
                    <asp:TextBox ID="txtDataLancamento" runat="server" Height="22px" Width="148px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data de Criação</td>
                <td class="style9">
                    <asp:TextBox ID="txtDataCriacao" runat="server" Height="22px" Width="148px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Valor</td>
                <td class="style9">
                    <asp:TextBox ID="txtValor" runat="server" Height="22px" Width="148px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Lançado Por</td>
                <td class="style9">
                    <asp:TextBox ID="txtLancadoPor" runat="server" Height="22px" Width="148px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Observação</td>
                <td class="style9">
                    <asp:TextBox ID="txtObservacao" runat="server" Height="102px" TextMode="MultiLine" 
                        Width="300px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>
            <br />

            <table width="100%">
                <tr align="center">
                    <td> 
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" /> &nbsp; 
                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" /> &nbsp;
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" CausesValidation="False" />
                    </td>
                </tr>
                <tr align="center">
                    <td> 
                        &nbsp;
                    </td>
                </tr>
            </table>
</asp:Content>
