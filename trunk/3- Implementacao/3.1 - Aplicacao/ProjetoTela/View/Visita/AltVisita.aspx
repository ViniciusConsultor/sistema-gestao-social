<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="AltVisita.aspx.cs" Inherits="ProjetoTela.Telas.Visita.AltVisita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .style6
        {
            width: 85%;
        }
        .style7
        {
            width: 79px;
        }
        .style8
        {
            width: 73px;
        }
        .style9
        {
            width: 111px;
        }
        .style10
        {
            width: 124px;
        }
        .style11
        {
            width: 68px;
        }
        .style12
        {
            text-align: center;
            font-size: small;
        }
        .style13
        {
            text-align: center;
            font-size: small;
            font-weight: bold;
        }
     .style14
     {
         width: 108px;
     }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <strong><span class="style4">Alterar Alimentação</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; Descrição: Permite cadastrar o plano alimentar dos assistidos da Casa Lar.
        <br />
        <br />
    <table class="style6" align="center">
        <tr>
            <td class="style7">
                <strong>Filtro</strong></td>
            <td class="style8">
                &nbsp;</td>
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
            <td class="style7">
                Período</td>
            <td class="style8">
                Data Início:</td>
            <td class="style9">
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </span>

            </td>
            <td class="style11">
                Data Fim:</td>
            <td class="style10">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Localizar" Width="91px" />
            </td>
        </tr>
    </table>
    <br />
    &nbsp;&nbsp;&nbsp; <strong>Resultado:</strong>
        

    <br />
    <br />
    <table class="style6" border="1" cellpadding="0" cellspacing="0" align="center">
        <tr>
            <td class="style13">
                Data</td>
            <td class="style13">
                Hora</td>
            <td class="style13">
                Visitante</td>
            <td class="style13">
                Visitado</td>
        </tr>
        <tr>
            <td class="style12">
                10/06/2010</td>
            <td class="style12">
                15:00h</td>
            <td class="style4">
                Aroldo Ferreira</td>
            <td class="style4">
                Luis Gonzaga</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

    <br />

         <table class="style6">
            <tr>
                <td class="style14">
                    Visitante</td>
                <td >
                    <span>
                    <asp:TextBox ID="TextBox6" runat="server" Width="250px">Aroldo Ferreira</asp:TextBox>
                    *</span></td>
                <td >
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14" >
                    Assistido</td>
                <td class="style9">
                    <span>
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="260px" Height="18px">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem Selected="True" >Luis Gonzaga</asp:ListItem>
                        <asp:ListItem>Junior Ferraz</asp:ListItem>
                    </asp:DropDownList>
                    *</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14" >
                    Data</td>
                <td >
                    <asp:TextBox ID="TextBox7" runat="server">10/06/2010</asp:TextBox>
                    <span>*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14">
                    Hoário Início</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server">15:00h</asp:TextBox>
                    <span>*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14">
                    Horário Fim</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <span>*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14">
                    Motivo da Visita</td>
                <td >
                    <span>
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
                <td>
                     Os campos que possuem * são obrigatórios.
                </td>
            </tr>
            <tr align="center"> 
                <td class="style11">
                     &nbsp;</td>
            </tr>
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" /> &nbsp;<span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    <asp:Button ID="btnSalvar0" runat="server" Text="Excluir" Width="110px" /> 
                    </span>&nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" />
                </td>
            </tr>
        </table>
        <br />


</asp:Content>
