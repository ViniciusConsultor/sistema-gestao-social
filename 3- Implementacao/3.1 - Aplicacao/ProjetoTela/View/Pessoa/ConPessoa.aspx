<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConPessoa.aspx.cs" Inherits="ProjetoTela.Telas.Pessoa.ConPessoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
         .style12
         {
             width: 70%;
         }
         .style13
         {
             width: 66px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <strong><span class="style4">Consultar Pessoa</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; Descrição: Possibilita consultar uma Pessoa(Assistido, Funcionário, 
        Voluntário, Patrocinador, Médicos).<br />
        <br />
    <br />
    <table class="style12" align="center">
        <tr>
            <td class="style13">
                Selecione:</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="299px">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem>Tiago Augusto</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="Localizar" Width="100px" />
            </td>
        </tr>
    </table>
        <br />
        </span>

</asp:Content>
