<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="AltLogin.aspx.cs" Inherits="SGS.View.AltLogin" %>
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
              width: 339px;
          }
          .style9
          {
              width: 339px;
          }
          .style10
          {
              color: #FF0000;
          }
          .style11
          {
              font-size: small;
              color: #FF0000;
          }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <strong><span class="style4">Alterar Login</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; Descrição: Permite Alterar o login de acesso ao sistema.
        <br />
        <br />
        </span>
        <table class="style6">
            <tr>
                <td class="style7">
                    Nome</td>
                <td class="style9">
                    <asp:TextBox ID="TextBox1" runat="server" Width="300px">Alice Boaventura Silva</asp:TextBox>
                    <span class="style10">*</span></td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Login</td>
                <td class="style9">
                    <asp:TextBox ID="TextBox2" runat="server">Alice</asp:TextBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Senha</td>
                <td class="style8">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password">123456</asp:TextBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    E-mail</td>
                <td class="style8">
                    <asp:TextBox ID="TextBox4" runat="server">alice@sgs.com</asp:TextBox>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    Perfil</td>
                <td align="right" class="style9" style="text-align: left">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="126px" Height="18px">
                        <asp:ListItem Text="Selecione" Value="Selecione" ></asp:ListItem>
                        <asp:ListItem Text="Gestor" Value="Gestor" Selected="True" ></asp:ListItem>
                        <asp:ListItem Text="Funcionário" Value="Funcionario"></asp:ListItem>
                    </asp:DropDownList>
                    <span class="style10">*</span></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
         <br />
        <table width="100%">
            <tr align="center"> 
                <td class="style11">
                     Os campos que possuem * são obrigatórios.
                </td>
            </tr>
            <tr align="center"> 
                <td class="style11">
                     &nbsp;</td>
            </tr>
            <tr align="center">
                <td> 
                    &nbsp;
                    <asp:Button ID="btnCancelar0" runat="server" Text="Alterar" Width="109px" />
                    &nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" />
                </td>
            </tr>
        </table>
        <br />

</asp:Content>
