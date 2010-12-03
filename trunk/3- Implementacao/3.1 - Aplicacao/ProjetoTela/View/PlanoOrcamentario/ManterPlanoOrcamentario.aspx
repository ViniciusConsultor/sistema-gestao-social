<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterPlanoOrcamentario.aspx.cs" Inherits="SGS.View.PlanoOrcamentario.ManterPlanoOrcamentario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .style6
        {
            width: 100%;
        font-size: small;
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
    .style13
    {
        text-align: left;
        font-size: small;
    }
    .style14
    {
        text-align: right;
        font-size: small;
        width: 200px;
    }
    .style15
    {
        text-align: right;
        width: 119px;
    }
    .style16
    {
        width: 119px;
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
                $(".mask-real-cifrao").maskMoney({ symbol: "R$", decimal: ",", thousands: ".", showSymbol: true, precision: 2 }); //real com cifrão R$1.000,00
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
        Text="Cadastrar Plano Orçamentário" CssClass="Titulo"></asp:Label>
    </strong> &nbsp;</span><br />
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp; <asp:Label ID="lblDescricao" runat="server" 
        Text="<b>Descrição:</b> Permite cadastrar um Plano Orçamentário para a Casa Lar." CssClass="Descricao"></asp:Label> 
        
        <br /><br />
 </span>

 <table class="style6" align="center">
 <tr>
                <td class="style14" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Casa Lar</td>
                <td colspan="3">
                    <asp:DropDownList ID="ddlCasaLar" runat="server" Enabled="False" Height="22px" 
                        Width="320px" DataTextField="NomeCasaLar" DataValueField="CodigoCasaLar">
                    </asp:DropDownList>
                </td>
            </tr>
 <tr>
                <td class="style14" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    &nbsp;</td>
                <td colspan="3">
                    &nbsp;</td>
            </tr>
 <tr>
                <td class="style14" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Nome do Plano </td>
                <td>
                    <asp:TextBox ID="txtNomePlano" runat="server" CssClass="style8" MaxLength="25" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorNomePlano" runat="server" 
                        ControlToValidate="txtNomePlano" ErrorMessage="Informe o Nome do Plano" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style15">
                    Status 
                </td>
                <td>
                    <asp:DropDownList ID="ddlStatus" runat="server" Width="154px" 
                        CssClass="style8">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Planejado</asp:ListItem>
                        <asp:ListItem>Em Vigor</asp:ListItem>
                        <asp:ListItem>Realizado</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="validatorStatus" runat="server" ControlToValidate="ddlStatus" ErrorMessage="Selecione o Status" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style14">
                    Início de Vigência</td>
                <td>
                    <asp:TextBox ID="txtInicioVigencia" runat="server" MaxLength="10" Width="148px" CssClass="mask-data"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorInicioVigencia" runat="server" 
                        ControlToValidate="txtInicioVigencia" 
                        ErrorMessage="Informe o Início de Vigência" ForeColor="Red" 
                        Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="compareInicioVigenciaData" runat="server" ControlToValidate="txtInicioVigencia" 
                    
                    ErrorMessage="Preencha o campo Início Vigência com uma data válida" 
                    ForeColor="Red" Display="Dynamic" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                </td>
                <td class="style15">
                    Fim de Vigência</td>
                <td>
                    <asp:TextBox ID="txtFimVigencia" runat="server" MaxLength="10" Width="148px"  CssClass="mask-data"></asp:TextBox>
                <asp:CompareValidator ID="compareSenha" runat="server" 
                    ControlToCompare="txtInicioVigencia" ControlToValidate="txtFimVigencia" 
                    
                    ErrorMessage="Preencha o campo Fim Vigência com uma data maior do que o Início Vigência" 
                    ForeColor="Red" Display="Dynamic" Operator="GreaterThan" 
                        SetFocusOnError="True" Type="Date">*</asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="validatorFimVigencia" runat="server" 
                        ControlToValidate="txtFimVigencia" ErrorMessage="Informe o Fim de Vigência" 
                        ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="compareFimVigenciaData0" runat="server" ControlToValidate="txtFimVigencia" 
                    
                    ErrorMessage="Preencha o campo Fim Vigência com uma data válida" 
                    ForeColor="Red" Display="Dynamic" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style14">
                    Valor do Orçamento</td>
                <td>
                    <asp:TextBox ID="txtValorOrcamento" runat="server" CssClass="mask-real-cifrao" 
                        Width="148px" MaxLength="15"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorValorOrcamento" runat="server" 
                        ControlToValidate="txtValorOrcamento" ErrorMessage="Informe o Valor do Orçamento" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style15">
                    Valor Orçado</td>
                <td>
                    <asp:TextBox ID="txtValorOrcado" runat="server" CssClass="mask-real-cifrao" 
                        Width="148px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Valor Financeiro Real</td>
                <td>
                    <asp:TextBox ID="txtValorFinanceiroReal" runat="server" CssClass="mask-real-cifrao" 
                        Width="148px" Enabled="False"></asp:TextBox>
                </td>
                <td class="style15">
                    Saldo Orçamento</td>
                <td>
                    <asp:TextBox ID="txtSaldoDisponivel" runat="server" Width="148px" 
                        CssClass="mask-real-cifrao" Enabled="False" ForeColor="Black"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style16">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>

        <table width="100%" align="center">
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" 
                        onclick="btnSalvar_Click" Height="26px" 
                        /> &nbsp; 
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" 
                        onclick="btnExcluir_Click" onclientclick="return confirm('Deseja realmente excluir?')" 
                        /> &nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" 
                        CausesValidation="False" onclick="btnCancelar_Click" />
                </td>
            </tr>
        </table>

 <br />
 <hr width="80%"/>

 <asp:Panel runat="server" ID="pnlItemOrcamento">
 
 
 <table class="style6" align="center">
            
            <tr>
                <td class="style13" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    <strong>&nbsp;&nbsp; <b> <span class="style4"> 
        <asp:Label ID="lblItemOrcamento" runat="server" 
        Text="Item Orçamento"></asp:Label>
                    </span> </b> </strong></td>
                <td>
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    <asp:Label ID="lblNaturezaDespesa" runat="server" Text="Natureza da Despesa"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlNaturezaDespesa" runat="server" Width="154px" 
                        CssClass="style8" DataTextField="NomeNatureza" 
                        DataValueField="CodigoNatureza" AutoPostBack="True" 
                        onselectedindexchanged="ddlNaturezaDespesa_SelectedIndexChanged">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem Value="1">Reforma</asp:ListItem>
                        <asp:ListItem Value="2">Compras</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="validatorNaturezaDespesa" runat="server" 
                        ControlToValidate="ddlNaturezaDespesa" ErrorMessage="Escolha a Natureza da Despesa" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style10" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    <asp:Label ID="lblValorDespesa" runat="server" Text="Valor Orçado Despesa"></asp:Label>
                </td>
                <td class="style11">
                    <asp:TextBox ID="txtValorDespesa" runat="server" CssClass="mask-real-cifrao" 
                        Width="148px" MaxLength="15"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorValorOrcado" runat="server" 
                        ControlToValidate="txtValorDespesa" ErrorMessage="Preencha o Valor Orçado da Despesa" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            </table>

        <table width="100%" align="center">
            <tr>
                <td style="text-align: center"> 
                    <asp:Button ID="btnIncluir" runat="server" Text="Incluir Item" Width="110px" 
                        onclick="btnIncluir_Click" Height="26px" 
                        /> &nbsp; 
                    <asp:Button ID="btnRemover" runat="server" Text="Remover Item" Width="110px" 
                        onclick="btnRemover_Click" Enabled="False" Height="26px" 
                        /> &nbsp;
                    </td>
            </tr>
                <tr>
                    <td>
                        <asp:Panel ID="pnlHR" runat="server" Height="10px">
                            <hr width="80%" Height="10px"/>
                        </asp:Panel>
                    </td>
                </tr>
        </table>

</asp:Panel>

       
         <table class="style6" align="center">
         <tr>
            <td>  
                
                <asp:Panel ID="pnlGrid" runat="server">
                
                <b> &nbsp;&nbsp; <span class="style4"><strong> <asp:Label ID="lblVisualizarItem" runat="server" Text="Visualizar Itens do Orçamento "></asp:Label> 
                    <br />
                    </strong></span> </b> <br />

                <asp:GridView ID="gridOrcamento" runat="server" CellPadding="0" 
                    
                    EmptyDataText="<br><br> Não existe item do orçamento cadastrado. <br><br><br>" ForeColor="#333333" 
                    GridLines="Horizontal" Width="90%" 
                    BorderColor="#003399" HorizontalAlign="Center"  
                    AllowPaging="True" AutoGenerateColumns="False" 
                    onpageindexchanging="gridOrcamento_PageIndexChanging" Visible="False" Enabled="false">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="NomeNatureza" HeaderText="Nome da Natureza">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Valor" HeaderText="Valor Orçado" 
                            DataFormatString="{0:c2}">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Valor Financeiro Real" DataField="BalancoFinancas" 
                            DataFormatString="{0:c2}" >
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Saldo Disponível" DataField="SaldoOrcamento" 
                            DataFormatString="{0:c2}" >
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" BorderColor="#003399" />
                    <EmptyDataRowStyle Font-Bold="True" Font-Size="Small" ForeColor="Red" 
                        HorizontalAlign="Center" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" Font-Size="Small" 
                        ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Right" 
                        Font-Size="Smaller" />
                    <RowStyle BackColor="#EFF3FB" Font-Size="Small" BorderColor="#003399" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
                
                </asp:Panel>
                <br />
                </td>    
            </tr>

         </table>
         
         <br />
         
          <table align="center">
            <tr align="center" valign="top">
                <td valign="top"> 
                    <asp:ValidationSummary ID="sumarioErro" runat="server" 
                        Width="340px" BorderColor="#0066FF" BorderStyle="Double" BorderWidth="1px" 
                        ForeColor="Red" HeaderText="Validação:" style="text-align: left" 
                        Font-Size="Small" />

                </td>
            </tr>
        </table>
        <br /><br />
</asp:Content>
