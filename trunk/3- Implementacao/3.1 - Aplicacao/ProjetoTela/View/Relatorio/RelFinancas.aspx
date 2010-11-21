<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true"
    CodeBehind="RelFinancas.aspx.cs" Inherits="SGS.View.Relatorio.RelFinancas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            height: 20px;
        }
        .style11
        {
            height: 20px;
            text-decoration: underline;
        }
        .style17
        {
            font-family: Arial, sans-serif;
            font-size: small;
        }
        .style18
        {
            height: 20px;
            width: 189px;
        }
        .style19
        {
            text-align: right;
        }
        .style20
        {
            height: 20px;
            }
        .style26
        {
            text-align: right;
            width: 160px;
        }
        .style29
        {
            width: 105px;
            text-align: left;
        }
        .style30
        {
            width: 220px;
            text-align: left;
        }
        .style31
        {
            font-family: Arial, sans-serif;
            font-size: small;
            width: 220px;
        }
        .style33
        {
            width: 220px;
        }
        .style34
        {
            width: 197px;
        }
        .style36
        {
            text-align: right;
            width: 197px;
            margin-left: 40px;
        }
        .style38
        {
            width: 168px;
        }
        .style39
        {
            text-align: right;
            width: 168px;
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
        <asp:Label ID="Label1" runat="server" Text="Relatório Financeiro"></asp:Label>
    </strong> &nbsp;</span><br />
    
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; 
    <asp:Label ID="Label2" runat="server" 
        Text="Descrição: Permite gerar relatório financeiro da casa lar."></asp:Label> 
        
        <br /><br />
   
    </span>

    <table width="100%" align="left" style="font-size: small; font-family: verdana">
        <tr>
            <td class="style18"> &nbsp; <span class="style11"><strong style="text-align: left">Filtro</strong></span></td>    
            <td class="style29"> &nbsp;</td>
            <td class="style20"> </td>
            <td class="style6"> </td>
        </tr>
        <tr>
            <td class="style18"> &nbsp;</td>    
            <td class="style29"> <strong>Tipo Relatório:</strong></td>
            <td class="style20" colspan="2"> 
            <asp:RadioButtonList ID="rdbTipo" runat="server" RepeatDirection="Horizontal" 
                RepeatLayout="Flow" AutoPostBack="True" 
                    onselectedindexchanged="rdbTipo_SelectedIndexChanged" Width="200px">
                <asp:ListItem Value="Orcamento">Orçamento</asp:ListItem>
                <asp:ListItem Value="Financas">Finanças</asp:ListItem>
            </asp:RadioButtonList>
            </td>
        </tr>
    </table>

    <br /><br /><br />

    <asp:Panel runat="server" ID="pnlFinancas" Visible="false">
    
    <table width="100%" align="left" style="font-size: small; font-family: verdana" 
            border="0">
        <tr>
            <td class="style36"> 
                <asp:Label ID="lbl" runat="server"></asp:Label>
            </td>    
            <td class="style30" valign="middle">  
                <asp:DropDownList ID="ddl" runat="server" Height="22px" 
                    Width="200px" DataTextField="Nome" DataValueField="CodigoPessoa" 
                    >
                    <asp:ListItem>Todos</asp:ListItem>
                    <asp:ListItem>Receita</asp:ListItem>
                    <asp:ListItem>Despesa</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style39"> 
                <asp:Label ID="lbl1" runat="server"></asp:Label>
            </td>
            <td>  
                 <asp:DropDownList ID="ddlNaturezaLancamento" runat="server" Width="200px" 
                     DataTextField="NomeNatureza" DataValueField="CodigoNatureza">
                </asp:DropDownList>
            </td>
        </tr>
        <tr valign="middle">
            <td class="style34" style="text-align: right"> 
                <asp:Label ID="lbl2" runat="server"></asp:Label>
            </td>    
            <td class="style33" valign="middle">  
                <asp:TextBox ID="txtDtInicioLancamento" runat="server" Width="196px" 
                    CssClass="mask-data"></asp:TextBox>
                <asp:CompareValidator ID="validatorDtInicioLancamento" runat="server" 
                    ControlToValidate="txtDtInicioLancamento" 
                    ErrorMessage="Preencha a Data Início Lançamento com uma data válida" 
                    ForeColor="Red" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
            </td>
            <td style="text-align: right" class="style38"> 
                 <asp:Label ID="lbl3" runat="server"></asp:Label>
            </td>
            <td>   
                <asp:TextBox ID="txtDtFimLancamento" runat="server" Width="196px" 
                    CssClass="mask-data"></asp:TextBox>

                <asp:CompareValidator ID="validatorDtFimLancamento" runat="server" 
                    ControlToValidate="txtDtFimLancamento" Display="Dynamic" 
                    ErrorMessage="Preencha a Data Fim Lançamento com uma data válida" 
                    ForeColor="Red" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                <asp:CompareValidator ID="validatorDtFimLancMaiorInicio" runat="server" 
                    ControlToCompare="txtDtInicioLancamento" ControlToValidate="txtDtFimLancamento" 
                    Display="Dynamic" 
                    ErrorMessage="Preencha a Data Fim com uma Data Maior do que a Data Início" 
                    ForeColor="Red" Operator="GreaterThanEqual" Type="Date">*</asp:CompareValidator>

            </td>
        </tr>
        <tr>
            <td class="style36"> &nbsp;</td>   
            <td class="style31" 
                
                
                
                style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA" 
                valign="middle"> 
                &nbsp;</td>
            <td class="style39"> 
                 &nbsp;</td>
            <td class="style17" 
                style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">  
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style19" colspan="2">  
                <asp:Button ID="btnGerarRelatorioFinancas" runat="server" Text="Gerar Relatório" 
                    Width="160px" Height="26px" onclick="btnGerarRelatorioFinancas_Click" />
            </td>   
            <td colspan="2"> 
                 <asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="160px" 
                     style="text-align: center" Height="26px" onclick="btnLimpar_Click"/>
            </td>
        </tr>
               
       
        </table>
  
    </asp:Panel>
    <br /><br />
    <p> &nbsp;</p>
     <p>&nbsp; </p>

              <table width="100%">
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

 
    
    <p align="center" >
        &nbsp;</p>


</asp:Content>
