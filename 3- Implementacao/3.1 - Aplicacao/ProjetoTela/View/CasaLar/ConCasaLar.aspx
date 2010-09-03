<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ConCasaLar.aspx.cs" Inherits="ProjetoTela.Telas.CasaLar.ConCasaLar" %>
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

    <strong><span class="style4">Consultar Casa Lar</span></strong><br />
        <span class="style4" 
            style="font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        &nbsp;&nbsp; Descrição: Possibilita consultar a Casa Lar.<br />
        <br />
        </span><table class="style6">
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Nome</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="style8" Enabled="False">Reviver ONG</asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    CNPJ</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="style8" Enabled="False">10.235.876/35</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Alvará</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="style8" Enabled="False">746.913.4</asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data fundação</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="style8" Enabled="False">26/06/1980</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Telefone</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="style8" Enabled="False">021 2415-7575</asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Fax</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="style8" Enabled="False">021 2415-7576</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    E-mail</td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server" CssClass="style8" Enabled="False">reviver@reviver.org.br</asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Site</td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server" CssClass="style8" Enabled="False">www.reviver.org.br</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Blog</td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server" CssClass="style8" Enabled="False">reviver.blogspot.com</asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    País</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="140px" 
                        CssClass="style8" Enabled="False">
                        <asp:ListItem Selected="True">Brasil</asp:ListItem>
                        <asp:ListItem>Argentina</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Estado</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="140px" 
                        CssClass="style8" Enabled="False">
                        <asp:ListItem>RJ</asp:ListItem>
                        <asp:ListItem>SP</asp:ListItem>
                        <asp:ListItem>MG</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Cidade</td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="140px" 
                        CssClass="style8" Enabled="False">
                        <asp:ListItem>Rio de Janeiro</asp:ListItem>
                        <asp:ListItem>Petropólis</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Bairro</td>
                <td>
                    <asp:TextBox ID="TextBox12" runat="server" CssClass="style8" Enabled="False">Campo Grande</asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Endereço</td>
                <td>
                    <asp:TextBox ID="TextBox13" runat="server" CssClass="style8" Enabled="False">Rua nova vida</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    CEP</td>
                <td>
                    <asp:TextBox ID="TextBox14" runat="server" CssClass="style8" Enabled="False">23057-280</asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Foto</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="220px" 
                        CssClass="style8" Enabled="False" />
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Qtd. Máximo Assistidos</td>
                <td>
                    <asp:TextBox ID="TextBox15" runat="server" CssClass="style8" Enabled="False">50</asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Qtd. Assistidos</td>
                <td>
                    <asp:TextBox ID="TextBox16" runat="server" CssClass="style8" Enabled="False">25</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    Gestor</td>
                <td>
                    <asp:TextBox ID="TextBox17" runat="server" CssClass="style8" Enabled="False">Fernando</asp:TextBox>
                </td>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    Ramo atividade</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="style8" Enabled="False">Filantrópico</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    História</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox5" runat="server" Height="107px" TextMode="MultiLine" 
                        Width="481px" CssClass="style8" Enabled="False">Foi fundada em 26/06/1980 por Augusto Charles.</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    </td>
                <td class="style10">
                    </td>
                <td class="style10">
                    </td>
                <td class="style10">
                    </td>
            </tr>
            <tr>
                <td class="style4" colspan="4" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" BackColor="#A6B4C6" Text="Salvar" 
                        Width="80px" CssClass="style8" />
                &nbsp;<asp:Button ID="Button3" runat="server" BackColor="#A6B4C6" Text="Excluir" 
                        Width="80px" CssClass="style8" />
                &nbsp;<asp:Button ID="Button2" runat="server" BackColor="#A6B4C6" Text="Cancelar" 
                        Width="100px" CssClass="style8" />
                </td>
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
