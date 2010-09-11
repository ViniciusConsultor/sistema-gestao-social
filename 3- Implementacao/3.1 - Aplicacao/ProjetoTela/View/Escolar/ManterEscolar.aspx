<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterEscolar.aspx.cs" Inherits="SGS.View.Escolar.ManterEscolar" %>
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
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <span class="style4"><strong> 
        <asp:Label ID="lblTitulo" runat="server"></asp:Label>
    </strong> &nbsp;</span><br />
    <span class="style4" style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; <asp:Label ID="lblDescricao" runat="server"></asp:Label> 
        
        <br /><br />
 </span>

  <table class="style6">
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Nome</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" CssClass="style8" MaxLength="25"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Status</td>
                <td>
                    <asp:DropDownList ID="ddlStatus" runat="server" Width="148px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    CNPJ</td>
                <td>
                    <asp:TextBox ID="txtCNPJ" runat="server" Width="148px"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Alvará</td>
                <td>
                    <asp:TextBox ID="txtAlvara" runat="server" CssClass="style8" MaxLength="10"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data fundação</td>
                <td>
                    <asp:TextBox ID="txtDataFundacao" runat="server" CssClass="style8" 
                        MaxLength="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Telefone</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="style8"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Fax</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="style8"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    E-mail</td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server" CssClass="style8"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Site</td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server" CssClass="style8"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Blog</td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server" CssClass="style8"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    País</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="140px" 
                        CssClass="style8">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Estado</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="140px" 
                        CssClass="style8">
                    </asp:DropDownList>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Cidade</td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="140px" 
                        CssClass="style8">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Bairro</td>
                <td>
                    <asp:TextBox ID="TextBox12" runat="server" CssClass="style8"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Endereço</td>
                <td>
                    <asp:TextBox ID="TextBox13" runat="server" CssClass="style8"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    CEP</td>
                <td>
                    <asp:TextBox ID="TextBox14" runat="server" CssClass="style8"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Foto</td>
                <td>
                    <asp:FileUpload ID="uploadFoto" runat="server" Width="220px" 
                        CssClass="style8" />
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Qtd. Máximo Assistidos</td>
                <td>
                    <asp:TextBox ID="txtQtdMaximo" runat="server" CssClass="style8" MaxLength="4"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Qtd. Assistidos</td>
                <td>
                    <asp:TextBox ID="txtQtdAssistidos" runat="server" CssClass="style8" 
                        MaxLength="4"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    Gestor</td>
                <td>
                    <asp:TextBox ID="txtGestor" runat="server" CssClass="style8"></asp:TextBox>
                </td>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    E-mail Gestor </td>
                <td>
                    <asp:TextBox ID="txtEmailGestor" runat="server" CssClass="style8" 
                        MaxLength="25"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    Telefone Gestor</td>
                <td>
                    <asp:TextBox ID="TelefoneGestor" runat="server" MaxLength="10" Width="148px"></asp:TextBox>
                </td>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    História</td>
                <td colspan="3">
                    <asp:TextBox ID="txtHistoria" runat="server" Height="107px" TextMode="MultiLine" 
                        Width="481px" CssClass="style8" MaxLength="255"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td style="text-align: right">
                    <asp:Button ID="Button1" runat="server" BackColor="#A6B4C6" Text="Salvar" 
                        Width="80px" CssClass="style8" />
                </td>
                <td style="margin-left: 40px">
                    <asp:Button ID="Button2" runat="server" BackColor="#A6B4C6" Text="Cancelar" 
                        Width="100px" CssClass="style8" />
                </td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td style="text-align: right">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>

</asp:Content>
