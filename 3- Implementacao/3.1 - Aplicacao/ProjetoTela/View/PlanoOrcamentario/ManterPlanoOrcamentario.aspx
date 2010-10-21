<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterPlanoOrcamentario.aspx.cs" Inherits="SGS.View.PlanoOrcamentario.ManterPlanoOrcamentario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style8
    {
        font-family: Verdana;
        font-size: small;
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
        height: 29px;
    }
    .style11
    {
        height: 29px;
    }
    .style12
    {
        height: 197px;
    }
    .mask-real-cifrao
    {}
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
        <asp:Label ID="lblTitulo" runat="server" 
        Text="Cadastrar Plano Orçamentário"></asp:Label>
    </strong> &nbsp;</span><br />
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; <asp:Label ID="lblDescricao" runat="server" 
        Text="Descrição: Permite cadastrar um Plano Orçamentário para a Casa Lar."></asp:Label> 
        
        <br /><br />
 </span>

 <table class="style6" align="center">
 <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Nome do Plano </td>
                <td>
                    <asp:TextBox ID="txtNomePlano" runat="server" CssClass="style8" MaxLength="25" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorNomePlano" runat="server" 
                        ControlToValidate="txtNomePlano" ErrorMessage="Informe o Nome do Plano" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    Início de Vigência</td>
                <td>
                    <asp:TextBox ID="txtInicioVigencia" runat="server" MaxLength="10" Width="148px" CssClass="mask-data"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorInicioVigencia" runat="server" 
                        ControlToValidate="txtInicioVigencia" 
                        ErrorMessage="Informe o Início de Vigência" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    Fim de Vigência</td>
                <td>
                    <asp:TextBox ID="txtFimVigencia" runat="server" MaxLength="10" Width="148px"  CssClass="mask-data"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorFimVigencia" runat="server" 
                        ControlToValidate="txtFimVigencia" ErrorMessage="Informe o Fim de Vigência" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Valor Estimado</td>
                <td>
                    <asp:TextBox ID="txtValorEstimado" runat="server" CssClass="mask-real-cifrao" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorValorEstimado" runat="server" 
                        ControlToValidate="txtValorEstimado" ErrorMessage="Informe o Valor Estimado" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Valor Disponível</td>
                <td>
                    <asp:TextBox ID="txtValorDisponivel" runat="server" Width="148px" 
                        CssClass="mask-real-cifrao"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorValorDisponivel" runat="server" 
                        ControlToValidate="txtValorDisponivel" 
                        ErrorMessage="Informe o Valor Disponível" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Status </td>
                <td>
                    <asp:DropDownList ID="ddlStatus" runat="server" Width="148px" 
                        CssClass="style8">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Em Vigor</asp:ListItem>
                        <asp:ListItem>Realizado</asp:ListItem>
                        <asp:ListItem>A Realizar</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="validatorStatus" runat="server" 
                        ControlToValidate="ddlStatus" ErrorMessage="Selecione o Status" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
 </table>

 <br />

 <table class="style6" align="center">
            
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Nome do Gasto</td>
                <td>
                    <asp:TextBox ID="txtNomeGasto" runat="server" CssClass="style8" Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorNomeGasto" runat="server" 
                        ControlToValidate="txtNomeGasto" ErrorMessage="Informe o Nome do Gasto" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style10" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Valor do Gasto</td>
                <td class="style11">
                    <asp:TextBox ID="txtValorGasto" runat="server" CssClass="mask-real-cifrao" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorValorGasto" runat="server" 
                        ControlToValidate="txtValorGasto" ErrorMessage="Informe o Valor do Gasto" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data do Gasto</td>
                <td>
                    <asp:TextBox ID="txtDataGasto" runat="server" CssClass="mask-data" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorDataGasto" runat="server" 
                        ControlToValidate="txtDataGasto" ErrorMessage="Informe a Data do Gasto" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            </table>

        <br />

        <table width="100%" align="center">
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
                <td class="style12"> 
                    <asp:ValidationSummary ID="sumarioErro" runat="server" Height="190px" 
                        Width="340px" BorderColor="#0066FF" BorderStyle="Double" BorderWidth="1px" 
                        ForeColor="Red" HeaderText="Validação:" style="text-align: left" 
                        Font-Size="Small" />
                </td>
            </tr>
        </table>

</asp:Content>
