<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterDesenvolvimento.aspx.cs" Inherits="SGS.View.Profissional.ManterProfissional" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style9
    {
        text-align: right;
        font-size: small;
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
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Assistido </td>
                <td>
                    <asp:DropDownList ID="ddlAssistido" runat="server" Width="148px" Height="22px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>João</asp:ListItem>
                        <asp:ListItem>Pedro</asp:ListItem>
                        <asp:ListItem>Maria</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridAssistido" runat="server" 
                        ControlToValidate="ddlAssistido" ErrorMessage="Escolha o Assistido" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Atividade </td>
                <td>
                    <asp:TextBox ID="txtAtividade" runat="server" Height="22px" Width="148px" 
                        MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridAtividade" runat="server" 
                        ControlToValidate="txtAtividade" ErrorMessage="Preencha o campo Atividade " 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Tipo de Atividade</td>
                <td>
                    <asp:DropDownList ID="ddlTipoAtividade" runat="server" Width="148px" 
                        Height="22px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Curso</asp:ListItem>
                        <asp:ListItem>Palestra</asp:ListItem>
                        <asp:ListItem>Seminário</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridTipoAtividade" runat="server" 
                        ControlToValidate="ddlTipoAtividade" ErrorMessage="Escolha o Tipo de Atividade" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Descrição </td>
                <td>
                    <asp:TextBox ID="txtDescricao" runat="server" Height="136px" Width="315px" 
                        MaxLength="500"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridDescricao" runat="server" 
                        ControlToValidate="txtDescricao" ErrorMessage="Preencha o campo Descrição" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Valor</td>
                <td>
                    <asp:TextBox ID="txtValor" runat="server" Height="22px" Width="148px" 
                        MaxLength="16"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridValor" runat="server" 
                        ControlToValidate="txtValor" ErrorMessage="Preencha o campo Valor" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Status </td>
                <td>
                    <asp:DropDownList ID="ddlStatus" runat="server" Width="148px" Height="22px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Criado</asp:ListItem>
                        <asp:ListItem>Parado</asp:ListItem>
                        <asp:ListItem>Iniciado</asp:ListItem>
                        <asp:ListItem>Cancelado</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridStatus" runat="server" 
                        ControlToValidate="ddlStatus" ErrorMessage="Escolha o Status" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data Inicio</td>
                <td>
                    <asp:TextBox ID="txtDataInicio" runat="server" Height="22px" MaxLength="10" 
                        Width="148px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data Fim</td>
                <td>
                    <asp:TextBox ID="txtDataFim" runat="server" Height="22px" MaxLength="10" 
                        Width="148px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Carga Horária</td>
                <td>
                    <asp:TextBox ID="txtCargaHoraria" runat="server" Height="22px" MaxLength="10" 
                        Width="148px"></asp:TextBox>
                </td>
            </tr>
            </table>

        <br />
        
        <table width="100%">
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" 
                        /> &nbsp; 
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" 
                        /> &nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" 
                        CausesValidation="False" />
                </td>
            </tr>
            <tr align="center">
                <td> 
                    &nbsp;</td>
            </tr>
            <tr align="center">
                <td> 
                <asp:ValidationSummary ID="sumarioErro" runat="server" BorderColor="#3366FF" 
                    BorderStyle="Double" Font-Names="verdana" Font-Size="Small" ForeColor="#CC0000" 
                    HeaderText="Validação:" Width="350px" />
                </td>
            </tr>
        </table>

</asp:Content>
