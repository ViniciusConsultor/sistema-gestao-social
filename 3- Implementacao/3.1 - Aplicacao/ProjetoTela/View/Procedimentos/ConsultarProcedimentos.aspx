<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConsultarProcedimentos.aspx.cs" Inherits="SGS.View.Procedimentos.ConsultarProcedimentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
        .style11
    {
        width: 174px;
        text-align: right;
    }
    .style12
    {
    }
    .style14
    {
        width: 174px;
        text-align: left;
    }
    .style15
    {
        width: 100px;
    }
    .style16
    {
        width: 486px;
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

 <table width="850px" align="left">
        <tr>
            <td class="style15"> &nbsp; </td>    
            <td class="style11"> &nbsp; </td>
            <td class="style16"> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
        <tr>
            <td class="style15"> &nbsp;</td>    
            <td class="style14"> <strong>Filtro:</strong></td>
            <td class="style16"> &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style15"> &nbsp;</td>    
            <td class="style11"> Assistido</td>
            <td class="style16"> 
                <asp:DropDownList ID="ddlAssistido" runat="server" Height="21px" Width="271px">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem>João</asp:ListItem>
                    <asp:ListItem>Maria</asp:ListItem>
                    <asp:ListItem>Luiz</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style15"> &nbsp;</td>    
            <td class="style11"> &nbsp;Data Agendada&nbsp; </td>
            <td class="style16"> 
                <asp:TextBox ID="txtDataMarcada" runat="server" Width="200px" 
                    CssClass="mask-data"></asp:TextBox>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style15"> &nbsp;</td>    
            <td class="style11"> Data Efetuada </td>
            <td class="style16"> 
                <asp:TextBox ID="txtDataRealizada" runat="server" Width="200px" 
                    CssClass="mask-data"></asp:TextBox>
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style15"> &nbsp;</td>    
            <td style="text-align: right" class="style11"> &nbsp;</td>
            <td class="style16"> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style15"> &nbsp;</td>    
            <td style="text-align: right" class="style11"> &nbsp; </td>
            <td class="style16"> 
                <asp:Button ID="btnLocalizar" runat="server" Text="Localizar" Width="95px" 
                    onclick="btnLocalizar_Click" />
&nbsp;<asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="95px" 
                    onclick="btnLimpar_Click" />
            </td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style15"> &nbsp;</td>    
            <td style="text-align: right" class="style11"> &nbsp;</td>
            <td class="style16"> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td class="style12" colspan="4">   
                <asp:GridView ID="gridProcedimentos" runat="server" CellPadding="4" 
                    EmptyDataText="Nenhum dado foi encontrado." ForeColor="#333333" 
                    GridLines="Horizontal" Width="96%" AutoGenerateColumns="False" 
                    BorderColor="#003399" HorizontalAlign="Center" Height="161px" 
                    AllowPaging="True" PageSize="2">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="CodigoProcedimento" 
                            DataNavigateUrlFormatString="ManterProcedimentos.aspx?tipo=alt&amp;cod={0}" 
                            Text="Selecionar">
                        <ItemStyle Width="75px" />
                        </asp:HyperLinkField>
                        <asp:BoundField DataField="CodigoAssistido" HeaderText="Assistido">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TipoProcedimento" HeaderText="Tipo de Procedimento">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Procedimento" HeaderText="Procedimento">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DataMarcada" HeaderText="Data de Agendada" 
                            DataFormatString="{0:dd-M-yyyy}">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DataRealizada" DataFormatString="{0:dd-M-yyyy}" 
                            HeaderText="Data Efetuada">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
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
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                </td>    
        </tr>
        <tr>
            <td class="style15"> &nbsp;</td>    
            <td style="text-align: right" class="style11"> &nbsp;</td>
            <td class="style16"> 
                &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
    </table>
    <br />

     
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>
