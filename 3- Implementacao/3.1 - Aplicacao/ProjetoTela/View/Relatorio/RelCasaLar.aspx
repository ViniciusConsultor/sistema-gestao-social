<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="RelCasaLar.aspx.cs" Inherits="ProjetoTela.Telas.Relatorio.RelCasaLar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <strong><span class="style4">Relatório Casa Lar</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; Descrição: Permite a emissão de relatórios com dados estatísticos da Casa Lar por período.<br />
    <br />
    <br />
 
 <table class="style6" align="center">
        <tr>
            <td class="style8">
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                <strong>Período do Relatório</strong></td>
            <td class="style9">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Data Início:</td>
            <td class="style9">
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                <asp:TextBox ID="TextBox2" runat="server">01/01/2010</asp:TextBox>
        </span>

            </td>
            <td class="style11">
                Data Fim:</td>
            <td class="style10">
                <asp:TextBox ID="TextBox1" runat="server">01/06/2010</asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Emitir" Width="91px" />
            </td>
        </tr>
    </table>
    <p align="center" >

        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagens/Tela_Saida.JPG" align="center"/>
        
        </span>
        </p>
    <p align="center" >
    <asp:Button ID="Button2" runat="server" Text="Exportar p/ PDF" />
        &nbsp;</p>

</asp:Content>
