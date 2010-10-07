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
                    Tipo Lançamento</td>
                <td class="style9">
                    <asp:DropDownList ID="ddlTipoLancamento" runat="server" Height="22px" 
                        Width="148px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Receita</asp:ListItem>
                        <asp:ListItem>Despesa</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="validatorTipoLancamento" runat="server" 
                        ControlToValidate="ddlTipoLancamento" 
                        ErrorMessage="Selecione o Tipo de Lançamento" ForeColor="Red" 
                        InitialValue="Selecione">*</asp:RequiredFieldValidator>
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
                    <asp:TextBox ID="txtDataLancamento" runat="server" Height="22px" Width="148px" 
                        MaxLength="10"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorDataLancamento" runat="server" 
                        ControlToValidate="txtDataLancamento" 
                        ErrorMessage="Informe a Data de Lançamento" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data Criação</td>
                <td class="style9">
                    <asp:TextBox ID="txtDataCriacao" runat="server" Height="22px" Width="148px" 
                        MaxLength="10"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorDataCriacao" runat="server" 
                        ControlToValidate="txtDataCriacao" ErrorMessage="Informe a Data de Criação" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
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
                    <asp:TextBox ID="txtValor" runat="server" Height="22px" Width="148px" 
                        MaxLength="13"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorValor" runat="server" 
                        ControlToValidate="txtValor" ErrorMessage="Informe o Valor" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
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
                    <asp:TextBox ID="txtLancadoPor" runat="server" Height="22px" Width="148px" 
                        MaxLength="50" Rows="20"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorLancadoPor" runat="server" 
                        ControlToValidate="txtLancadoPor" ErrorMessage="Preencha o campo Lançado Por" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
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
                        Width="300px" MaxLength="4000"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="validatorObservacao" runat="server" 
                        ControlToValidate="txtObservacao" ErrorMessage="Preencha o campo Observação" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>
            <br />

            <table width="100%">
                <tr align="center">
                    <td> 
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" 
                            onclick="btnSalvar_Click" /> &nbsp; 
                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" /> &nbsp;
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" CausesValidation="False" />
                    </td>
                </tr>
                <tr align="center">
                    <td> 
                        &nbsp;
                        <asp:ValidationSummary ID="sumarioErro" runat="server" BorderColor="#0066FF" 
                            BorderStyle="Double" BorderWidth="1px" ForeColor="Red" HeaderText="Validação:" 
                            Height="135px" style="font-size: small; text-align: left" Width="365px" />
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
</asp:Content>
