<%@ Page Title=".:: SGS - Manter Assistido ::." Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterAssistido.aspx.cs" Inherits="SGS.View.Pessoa.ManterPessoa" %>
<%@ Register src="PessoaDadosBasico.ascx" tagname="PessoaDadosBasico" tagprefix="uc1" %>
<%@ Register src="PessoaAssistido.ascx" tagname="PessoaAssistido" tagprefix="uc2" %>

<%@ Register src="../UserControls/MessageBox.ascx" tagname="MessageBox" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            /* width: 148px; */
            font-size: small;
            text-align: left;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <span class="style4"><strong> 
        <asp:Label ID="lblTitulo" runat="server" Text="" CssClass="Titulo"></asp:Label>
    </strong> &nbsp;</span><br />
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp; <asp:Label ID="lblDescricao" runat="server" Text="" CssClass="Descricao"></asp:Label> 
        
        <br /><br />
    </span>
    <br />

    <table width="100%">
        <tr>
            <td class="style6"> Casa Lar</td>
            <td>  
                <asp:DropDownList ID="ddlCasaLar" runat="server" Width="200px" 
                    AutoPostBack="True" DataTextField="NomeCasaLar" 
                    DataValueField="CodigoCasaLar" Enabled="False" style="margin-left: 0px">
                </asp:DropDownList>
            </td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        </table>


    <uc1:PessoaDadosBasico ID="ucPessoaDadosBasico" runat="server" />


    <br />

      

        <uc2:PessoaAssistido ID="ucPessoaAssistido" runat="server" />

      

        <br />

    <br />

    <table width="100%">
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" 
                        onclick="btnSalvar_Click" /> &nbsp; 
                    <asp:Button ID="btnAtivarDesativar" runat="server" Text="Ativar" Width="110px" 
                        onclick="btnAtivarDesativar_Click" /> &nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" 
                        CausesValidation="False" onclick="btnCancelar_Click" />
                </td>
            </tr>
            <tr align="center">
                <td> 
                    <asp:Button ID="btnCarregarDadosTela" runat="server" 
                        onclick="btnCarregarDadosTela_Click" Text="Carregar Dados Tela" 
                        CausesValidation="False" Visible="False" />
                </td>
            </tr>
        </table>

   <br />
    <table align="center">
        <tr>
            <td>
                <asp:ValidationSummary ID="sumarioErro" runat="server" BorderColor="#3366FF" 
                    BorderStyle="Double" Font-Names="verdana" Font-Size="Small" ForeColor="#CC0000" 
                    HeaderText="Validação:" Width="350px" />
            </td>
        </tr>
    </table>
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <uc3:MessageBox ID="MessageBox1" runat="server" />
    <br />


</asp:Content>
