<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="Cad_Visita.aspx.cs" Inherits="ProjetoTela.Telas.Cad_Visita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style7
        {
            width: 259px;
            text-align: right;
            font-size: small;
        }
        .style8
        {
            font-size: small;
            text-align: right;
        }
        .style9
        {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <strong><span class="style4">Cadastrar Visita</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; Descrição: Possibilita cadastrar as Visitas que acontecem 
        na Casa Lar.<br />
        <br />
        </span>
        <table class="style6">
            <tr>
                <td class="style7">
                    Casa Lar</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="140px">
                    </asp:DropDownList>
                </td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Pessoa visitante</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="style9">
                    <span class="style4">RG</span><span style="mso-fareast-font-family:&quot;Lucida Sans Unicode&quot;;mso-bidi-font-family:Arial;
mso-font-kerning:.5pt;mso-ansi-language:PT-BR;mso-fareast-language:AR-SA;
mso-bidi-language:AR-SA" class="style4"> visitante</span></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Assistido Visitado</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="140px">
                    </asp:DropDownList>
                </td>
                <td class="style8">
                    <span style="mso-fareast-font-family:&quot;Lucida Sans Unicode&quot;;mso-bidi-font-family:Arial;
mso-font-kerning:.5pt;mso-ansi-language:PT-BR;mso-fareast-language:AR-SA;
mso-bidi-language:AR-SA"><span style="mso-spacerun:yes" class="style4">&nbsp;</span></span><span style="mso-fareast-font-family:&quot;Lucida Sans Unicode&quot;;mso-bidi-font-family:Arial;
mso-font-kerning:.5pt;mso-ansi-language:PT-BR;mso-fareast-language:AR-SA;
mso-bidi-language:AR-SA" class="style4">Data Visita</span></td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Hora Início</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="style8" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Hora Fim 
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Motivo Visita</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td align="right">
                    <asp:Button ID="Button2" runat="server" style="text-align: right" 
                        Text="Cadastrar" BackColor="#A6B4C6" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Cancelar" BackColor="#A6B4C6" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
</asp:Content>
