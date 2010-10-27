<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterPessoa.aspx.cs" Inherits="SGS.View.Pessoa.ManterPessoa" %>
<%@ Register src="PessoaDadosBasico.ascx" tagname="PessoaDadosBasico" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            width: 170px;
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
    <br />

    <table width="100%">
        <tr>
            <td style="text-align: right" class="style6"> Casa Lar</td>
            <td>  
                <asp:DropDownList ID="ddlCasaLar" runat="server" Width="200px" 
                    AutoPostBack="True">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem>Assistido</asp:ListItem>
                    <asp:ListItem Value="Funcionario">Funcionário</asp:ListItem>
                    <asp:ListItem Value="Voluntario">Voluntário</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right" class="style6"> &nbsp; Tipo Pessoa</td>
            <td>  
                <asp:DropDownList ID="ddlTipoPessoa" runat="server" Width="200px" 
                    onselectedindexchanged="ddlTipoPessoa_SelectedIndexChanged" 
                    AutoPostBack="True">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem>Assistido</asp:ListItem>
                    <asp:ListItem Value="Funcionario">Funcionário</asp:ListItem>
                    <asp:ListItem Value="Voluntario">Voluntário</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
    </table>


    <br />

      <table width="100%">
        <tr>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
    </table>

    <uc1:PessoaDadosBasico ID="ucPessoaDadosBasico" runat="server" 
        Visible="False" />

    <br />
      <table width="100%">
        <tr>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
            <td> &nbsp; </td>
        </tr>
    </table>

</asp:Content>
