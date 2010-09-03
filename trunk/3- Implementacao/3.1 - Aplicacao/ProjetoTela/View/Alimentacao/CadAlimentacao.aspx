<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true"
    CodeBehind="CadAlimentacao.aspx.cs" Inherits="ProjetoTela.Telas.Alimentacao.CadAlimentacao" %>

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

    <strong><span class="style4">Cadastrar Alimentação</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; Descrição: Permite cadastrar o plano alimentar dos assistidos da Casa Lar.
        <br />
        <br />
        </span>
        <table class="style6">
            <tr>
                <td class="style7">
                    Dia da semana</td>
                <td class="style9">
                    <span class="style10">
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="126px" Height="18px">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem Text="Domingo" Value="Domingo" ></asp:ListItem>
                        <asp:ListItem Text="Segunda-Feira" Value="Segunda-Feira"></asp:ListItem>
                        <asp:ListItem>Terça-Feira</asp:ListItem>
                    </asp:DropDownList>
                    *</span></td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Período</td>
                <td class="style9">
                    <span class="style10">
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="126px" Height="18px">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem >Desjejum</asp:ListItem>
                        <asp:ListItem>Colação</asp:ListItem>
                        <asp:ListItem>Almoço</asp:ListItem>
                        <asp:ListItem>Lanche</asp:ListItem>
                        <asp:ListItem>Jantar</asp:ListItem>
                        <asp:ListItem>Ceia</asp:ListItem>
                    </asp:DropDownList>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Horário</td>
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
                    Alimentos</td>
                <td class="style8">
                    <asp:ListBox ID="ListBox1" runat="server" Height="105px" Width="288px">
                        <asp:ListItem>Café</asp:ListItem>
                        <asp:ListItem>Pão</asp:ListItem>
                        <asp:ListItem>Arroz</asp:ListItem>
                        <asp:ListItem>Feijão</asp:ListItem>
                        <asp:ListItem>Salada</asp:ListItem>
                        <asp:ListItem>Gelatina</asp:ListItem>
                    </asp:ListBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Porção do Alimento</td>
                <td align="right" class="style9" style="text-align: left">
                    <span class="style10">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Diretiva</td>
                <td align="right" class="style9" style="text-align: left">
                    <span class="style10">
                    <asp:TextBox ID="TextBox5" runat="server" Height="86px" TextMode="MultiLine" 
                        Width="285px"></asp:TextBox>
                    </span></td>
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
