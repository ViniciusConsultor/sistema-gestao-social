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


        <!-- Importa todos os script JavaScript-->
        <script type="text/javascript" src="../../Scripts/jquery-1.3.2.min.js"> </script>
        <script type="text/javascript" src="../../Scripts/jquery.maskedinput-1.2.1.js"> </script>
        <script type="text/javascript" src="../../Scripts/jquery.maskMoney.js"> </script>
        
        <!-- Comandos de JavaScript-->
        <script type="text/javascript">

            //Diz que quando a página for carregada, irá ser executado o
            //bloco de código contido entre os {};

            $(document).ready(function () {

                //Para usuar as máscaras abaixo coloque a descrição após o . na Propriedade CssClass de cada controle.
                //Exemplo: asp:TextBox ID="txtNome2" runat="server" Width="330px" MaxLength="50" CssClass="mask-real" 

                $('.mask-numero').mask('999999'); //número
                $('.mask-numero2').maskMoney({ precision: 6 }); //número

                $('.mask-data').mask('99/99/9999'); //data
                $('.mask-hora').mask('99:99'); //hora
                $('.mask-fone').mask('(99) 9999-9999'); //telefone
                $('.mask-rg').mask('99.999.999-9'); //RG
                $('.mask-ag').mask('9999-9'); //Agência
                $('.mask-ag').mask('9.999-9'); //Conta
                $(".mask-cpf").mask("999.999.999-99"); //cpf
                $(".mask-cnpj").mask("99.999.999/9999-99"); //cnpj
                $(".mask-cep").mask("99999-999"); //cep
                $(".mask-real-cifrao").maskMoney({ symbol: "R$", decimal: ",", thousands: ".", showSymbol: true }); //real com cifrão R$1.000,00
                $(".mask-real").maskMoney({ symbol: "R$", decimal: ",", thousands: ".", showSymbol: false }); //real sem cifrão 1.000,00
                $(".mask-precision").maskMoney({ precision: 3 }); //com 3 casas de precisão 1,000

                /* Default options are (but you can always change that):
                symbol:'US$',
                decimal:'.',
                precision:2,
                thousands:',',
                allowZero:false,
                showSymbol:false */

            });

        </script>

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
                    <asp:DropDownList ID="ddlCasaLar" runat="server" Enabled="False" Height="22px" 
                        Width="148px" DataTextField="NomeCasaLar" DataValueField="CodigoCasaLar" 
                        onselectedindexchanged="ddlCasaLar_SelectedIndexChanged">
                        <asp:ListItem Selected="True" Value="13">Minha Casa</asp:ListItem>
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
                    Natureza da Finança</td>
                <td class="style9">
                    <asp:DropDownList ID="ddlNaturezaFinanca" runat="server" Height="22px" 
                        Width="148px" DataTextField="NomeNatureza" DataValueField="CodigoNatureza">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem Value="2">Compras</asp:ListItem>
                        <asp:ListItem Value="1">Reforma</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="validatorNaturezaFinanca" runat="server" 
                        ControlToValidate="ddlNaturezaFinanca" 
                        ErrorMessage="Informe a Natureza da Finança" ForeColor="Red" 
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
                        MaxLength="10" CssClass="mask-data"></asp:TextBox>
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
                    Valor</td>
                <td class="style9">
                    <asp:TextBox ID="txtValor" runat="server" Height="22px" Width="148px" MaxLength="13" CssClass="mask-real-cifrao"></asp:TextBox>
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
                    Data Criação</td>
                <td class="style9">
                    <asp:TextBox ID="txtDataCriacao" runat="server" Height="22px" Width="148px" 
                        MaxLength="10" CssClass="mask-data" Enabled="False"></asp:TextBox>
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
                    Lançado Por</td>
                <td class="style9">
                    <asp:TextBox ID="txtLancadoPor" runat="server" Height="22px" Width="148px" 
                        MaxLength="50" Rows="20" Enabled="False"></asp:TextBox>
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
                    Descrição</td>
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
                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" 
                            onclick="btnExcluir_Click" 
                            onclientclick="return confirm('Deseja realmente excluir?')" /> &nbsp;
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" 
                            CausesValidation="False" onclick="btnCancelar_Click" />
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
