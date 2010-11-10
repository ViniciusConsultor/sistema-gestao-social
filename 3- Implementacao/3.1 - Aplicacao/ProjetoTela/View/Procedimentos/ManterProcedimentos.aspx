<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterProcedimentos.aspx.cs" Inherits="SGS.View.Procedimentos.ManterProcedimentos" %>
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
    .style10
    {
        text-align: right;
        font-size: small;
        height: 20px;
    }
    .style11
    {
        height: 20px;
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
                        <asp:ListItem Value="1">João</asp:ListItem>
                        <asp:ListItem Value="2">Pedro</asp:ListItem>
                        <asp:ListItem Value="3">Maria</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridAssistido" runat="server" 
                        ControlToValidate="ddlAssistido" ErrorMessage="Escolha o Assistido" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Tipo de Procedimento </td>
                <td>
                    <asp:DropDownList ID="ddlTipoProcedimento" runat="server" Width="148px" 
                        Height="22px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Médico</asp:ListItem>
                        <asp:ListItem>Emocional</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridTipoProcedimento" runat="server" 
                        ControlToValidate="ddlTipoProcedimento" ErrorMessage="Escolha o Tipo de Procedimneto" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Procedimento</td>
                <td>
                    <asp:DropDownList ID="ddlProcedimento" runat="server" Width="148px" 
                        Height="22px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Clinico Geral</asp:ListItem>
                        <asp:ListItem>Dentista</asp:ListItem>
                        <asp:ListItem>Reforço Escolar</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridProcedimento" runat="server" 
                        ControlToValidate="ddlProcedimento" ErrorMessage="Escolha o Procedimento" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Descrição </td>
                <td>
                    <asp:TextBox ID="txtDescricao" runat="server" Height="22px" Width="148px" 
                        MaxLength="100"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridDescricao" runat="server" 
                        ControlToValidate="txtDescricao" ErrorMessage="Preencha o campo Descrição" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Status</td>
                <td>
                    <asp:DropDownList ID="ddlStatus" runat="server" Width="148px" Height="22px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Criado</asp:ListItem>
                        <asp:ListItem>Marcado</asp:ListItem>
                        <asp:ListItem>Efetuado</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridStatus" runat="server" 
                        ControlToValidate="ddlStatus" ErrorMessage="Escolha o Status" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Pessoa Atendente</td>
                <td>
                    <asp:TextBox ID="txtPessoaAtendente" runat="server" Height="22px" 
                        MaxLength="50" Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridPessoaAtendente" runat="server" 
                        ControlToValidate="txtPessoaAtendente" ErrorMessage="Preencha o campo Pessoa Atendente" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data Marcada</td>
                <td>
                    <asp:TextBox ID="txtDataMarcada" runat="server" Height="22px" MaxLength="10" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridDataMarcada" runat="server" 
                        ControlToValidate="txtDataMarcada" ErrorMessage="Preencha o campo Data Marcada" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data Realizada</td>
                <td>
                    <asp:TextBox ID="txtDataRealizada" runat="server" Height="22px" MaxLength="10" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridDataRealizada" runat="server" 
                        ControlToValidate="txtDataRealizada" ErrorMessage="Preencha o campo Data Realizada" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Laudo do Atendente</td>
                <td>
                    <asp:TextBox ID="txtLaudoAtendente" runat="server" Height="134px" TextMode="MultiLine" 
                        Width="301px" MaxLength="255"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridLaudoAtendente" runat="server" 
                        ControlToValidate="txtLaudoAtendente" ErrorMessage="Preencha o campo Laudo do Atendente" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            </table>

        <br />
        
        <table width="100%">
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" onclick="btnSalvar_Click" 
                        /> &nbsp; 
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" onclick="btnExcluir_Click" 
                        /> &nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" 
                        CausesValidation="False" onclick="btnCancelar_Click" />
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
