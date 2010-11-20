<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterAlimentacao.aspx.cs" Inherits="SGS.View.Alimentacao.ManterAlimentacao" %>
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
                <td class="style7">
                    <asp:Label ID="lblDiaSemana" runat="server" Text="Dia da semana"></asp:Label>
                </td>
                <td class="style9">
                    <span class="style10">
                    <asp:DropDownList ID="ddlDiaSemana" runat="server" Width="155px" Height="22px" 
                        AutoPostBack="True" 
                        onselectedindexchanged="ddlDiaSemana_SelectedIndexChanged">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem Text="Domingo" Value="Domingo" ></asp:ListItem>
                        <asp:ListItem Text="Segunda-Feira" Value="Segunda-Feira"></asp:ListItem>
                        <asp:ListItem Text="Terça-Feira" Value="Terca-Feira"></asp:ListItem>
                        <asp:ListItem Text="Quarta-Feira" Value="Quarta-Feira"></asp:ListItem>
                        <asp:ListItem Text="Quinta-Feira" Value="Quinta-Feira"></asp:ListItem>
                        <asp:ListItem Text="Sexta-Feira" Value="Sexta-Feira"></asp:ListItem>
                        <asp:ListItem Value="Sabado">Sábado</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridDiaSemana" runat="server" 
                        ControlToValidate="ddlDiaSemana" ErrorMessage="Escolha o Dia da Semana" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                    </span></td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="lblPeriodo" runat="server" Text="Período" Visible="False"></asp:Label>
                </td>
                <td class="style9">
                    <span class="style10">
                    <asp:DropDownList ID="ddlPeriodo" runat="server" Width="155px" Height="22px" 
                        AutoPostBack="True" onselectedindexchanged="ddlPeriodo_SelectedIndexChanged" 
                        Visible="False">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem >Desjejum</asp:ListItem>
                        <asp:ListItem Value="Colacao">Colação</asp:ListItem>
                        <asp:ListItem Value="Almoco">Almoço</asp:ListItem>
                        <asp:ListItem>Lanche</asp:ListItem>
                        <asp:ListItem>Jantar</asp:ListItem>
                        <asp:ListItem>Ceia</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridPeriodo" runat="server" 
                        ControlToValidate="ddlPeriodo" ErrorMessage="Escolha o Periodo" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                    </span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="lblHorario" runat="server" Text="Horário" Visible="False"></asp:Label>
                </td>
                <td class="style8">
                    <asp:TextBox ID="txtHorario" runat="server" Height="22px" MaxLength="5" 
                        Width="148px" CssClass="mask-hora" Visible="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridHorario" runat="server" 
                        ControlToValidate="txtHorario" ErrorMessage="Preencha o Campo Horário" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="lblAlimentos" runat="server" Text="Alimentos" Visible="False"></asp:Label>
                </td>
                <td class="style8">
                    <asp:ListBox ID="ltbAlimentos" runat="server" Height="105px" Width="288px" 
                        SelectionMode="Multiple" Visible="False" DataTextField="NomeAlimento" 
                        DataValueField="CodigoAlimento">
                    </asp:ListBox>
                    <asp:RequiredFieldValidator ID="requeridAlimentos" runat="server" 
                        ControlToValidate="ltbAlimentos" ErrorMessage="Escolha os Alimentos" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="lblDiretiva" runat="server" Text="Diretiva" Visible="False"></asp:Label>
                </td>
                <td align="right" class="style9" style="text-align: left">
                    <span class="style10">
                    <asp:TextBox ID="txtDiretiva" runat="server" Height="86px" TextMode="MultiLine" 
                        Width="285px" MaxLength="200" Visible="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridDiretiva" runat="server" 
                        ControlToValidate="txtDiretiva" ErrorMessage="Preencha o Campo Diretiva" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    </span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
         <br />

         <br />

        <table width="100%">
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" onclick="btnSalvar_Click" 
                        /> &nbsp; 
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" 
                        onclick="btnExcluir_Click" onclientclick="return confirm('Deseja realmente excluir?')" 
                        /> &nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Cancelar" Width="110px" 
                        CausesValidation="False" />
                </td>
            </tr>
            <tr align="center">
                <td> 
                    &nbsp;</td>
            </tr>
            <tr align="center">
                <td> 
                
                </td>
            </tr>
        </table>
        <table align="center">
        <tr>
            <td>
                <asp:ValidationSummary ID="sumarioErro" runat="server" BorderColor="#3366FF" 
                    BorderStyle="Double" Font-Names="verdana" Font-Size="Small" ForeColor="#CC0000" 
                    HeaderText="Validação:" Width="350px" />
            </td>
        </tr>
        </table>

</asp:Content>
