<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="CadVisita.aspx.cs" Inherits="ProjetoTela.Telas.Visita.CadVisita" %>
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
            text-align: left;
            width: 365px;
        }
        .style9
        {
            width: 365px;
        }
        .style10
        {
            color: #FF0000;
        }
        .style11
        {
            font-size: small;
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <strong><span class="style4">Cadastrar Visita</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; Descrição: Permite cadastrar visitas aos assistidos da Casa Lar. 
        <br />
        <br />
        </span>
        <table class="style6">
            <tr>
                <td class="style7">
                    Visitante</td>
                <td class="style9">
                    <span class="style10">
                    <asp:TextBox ID="TextBox6" runat="server" Width="250px"></asp:TextBox>
                    *</span></td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Assistido</td>
                <td class="style9">
                    <span class="style10">
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="260px" Height="18px">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem >Tiago Pereira</asp:ListItem>
                        <asp:ListItem>Junior Ferraz</asp:ListItem>
                    </asp:DropDownList>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Data</td>
                <td class="style8">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Hoário Início</td>
                <td class="style8">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Horário Fim</td>
                <td class="style8">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Motivo da Visita</td>
                <td class="style8">
                    <span class="style10">
                    <asp:TextBox ID="TextBox9" runat="server" Height="86px" TextMode="MultiLine" 
                        Width="285px"></asp:TextBox>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>
         <br />
        <table width="100%">
            <tr align="center"> 
                <td class="style11">
                     Os campos que possuem * são obrigatórios.
                </td>
            </tr>
            <tr align="center"> 
                <td class="style11">
                     &nbsp;</td>
            </tr>
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" /> &nbsp;&nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" />
                </td>
            </tr>
        </table>
        <br />

</asp:Content>
