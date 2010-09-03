<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="Cad_Financas.aspx.cs" Inherits="ProjetoTela.Telas.Cad_Financas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style7
        {
            width: 171px;
        text-align: right;
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
    
        <strong><span class="style4">Cadastar Finanças</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">&nbsp;&nbsp; Descrição: 
Permite ao gestor efetuar o lançamento das receitas e despesas da Casa Lar.<br />
        <br />
        </span>
        <table class="style6">
            <tr>
                <td class="style8" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Casa Lar</td>
                <td class="style9">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="140px" 
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
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="17px" Width="140px">
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
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="TextBox4" runat="server" Height="102px" TextMode="MultiLine" 
                        Width="300px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td align="left" style="text-align: center" colspan="2">
                    <asp:Button ID="Button1" runat="server" BackColor="#A6B4C6" Text="Salvar" 
                        Width="90px" />
                &nbsp;<asp:Button ID="Button2" runat="server" BackColor="#A6B4C6" Text="Cancelar" 
                        Width="100px" CssClass="style8" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>


</asp:Content>
