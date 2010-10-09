<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterCasaLar.aspx.cs" Inherits="ProjetoTela.View.CasaLar.ManterCasaLar" %>
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
        .style10
        {
            text-align: right;
            font-size: small;
            height: 26px;
        }
        .style11
        {
            height: 26px;
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

    <table class="style6">
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Nome Casa Lar</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" CssClass="style8" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridCasaLar" runat="server" 
                        ControlToValidate="txtNome" ErrorMessage="Preencha o campo Casa Lar" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Status</td>
                <td>
                    <asp:DropDownList ID="ddlStatus" runat="server" Width="148px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Legal</asp:ListItem>
                        <asp:ListItem Value="Ilegal">Ilegal</asp:ListItem>
                        <asp:ListItem>Em Construção</asp:ListItem>
                        <asp:ListItem>Interditada</asp:ListItem>
                        <asp:ListItem>Em Análise</asp:ListItem>
                        <asp:ListItem>A Inaugurar</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridStatus" runat="server" 
                        ControlToValidate="ddlStatus" ErrorMessage="Escolha o Status" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    CNPJ</td>
                <td>
                    <asp:TextBox ID="txtCNPJ" runat="server" Width="148px" MaxLength="18"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidatorCNPJ" runat="server" 
                        ErrorMessage="Preencha o campo CNPJ" ControlToValidate="txtCNPJ" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Alvará</td>
                <td>
                    <asp:TextBox ID="txtAlvara" runat="server" CssClass="style8" MaxLength="20"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridAlvara" runat="server" 
                        ControlToValidate="txtAlvara" ErrorMessage="Preencha o campo Alvará" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data fundação</td>
                <td>
                    <asp:TextBox ID="txtDataFundacao" runat="server" CssClass="style8" 
                        MaxLength="10"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridDaTaFundacao" runat="server" 
                        ControlToValidate="txtDataFundacao" ErrorMessage="Preencha o campo Data de Fundação" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Telefone</td>
                <td>
                    <asp:TextBox ID="txtTelefone" runat="server" CssClass="style8" MaxLength="13"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridTelefone" runat="server" 
                        ControlToValidate="txtTelefone" ErrorMessage="Preencha o campo Telefone" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Telefone Celular</td>
                <td>
                    <asp:TextBox ID="txtTelefoneCelular" runat="server" Height="22px" Width="148px"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Fax</td>
                <td>
                    <asp:TextBox ID="txtFax" runat="server" CssClass="style8" MaxLength="13"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    E-mail</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="style8" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridEmail" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Preencha o campo E-mail" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Site</td>
                <td>
                    <asp:TextBox ID="txtSite" runat="server" CssClass="style8" MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Blog</td>
                <td>
                    <asp:TextBox ID="txtBlog" runat="server" Height="22px" Width="148px" 
                        MaxLength="50"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    País</td>
                <td>
                    <asp:DropDownList ID="ddlPais" runat="server" Width="148px" 
                        CssClass="style8" Enabled="False">
                        <asp:ListItem>Brasil</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style10" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Estado</td>
                <td class="style11">
                    <asp:DropDownList ID="ddlEstado" runat="server" Width="148px" 
                        CssClass="style8">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>AC</asp:ListItem>
                        <asp:ListItem>AL</asp:ListItem>
                        <asp:ListItem>AP</asp:ListItem>
                        <asp:ListItem>AM</asp:ListItem>
                        <asp:ListItem>BA</asp:ListItem>
                        <asp:ListItem>CE</asp:ListItem>
                        <asp:ListItem>DF</asp:ListItem>
                        <asp:ListItem>ES</asp:ListItem>
                        <asp:ListItem>GO</asp:ListItem>
                        <asp:ListItem>MA</asp:ListItem>
                        <asp:ListItem>MT</asp:ListItem>
                        <asp:ListItem>MS</asp:ListItem>
                        <asp:ListItem>MG</asp:ListItem>
                        <asp:ListItem>PA</asp:ListItem>
                        <asp:ListItem>PB</asp:ListItem>
                        <asp:ListItem>PR</asp:ListItem>
                        <asp:ListItem>PE</asp:ListItem>
                        <asp:ListItem>PI</asp:ListItem>
                        <asp:ListItem>RJ</asp:ListItem>
                        <asp:ListItem>RN</asp:ListItem>
                        <asp:ListItem>RS</asp:ListItem>
                        <asp:ListItem>RO</asp:ListItem>
                        <asp:ListItem>RR</asp:ListItem>
                        <asp:ListItem>SC</asp:ListItem>
                        <asp:ListItem>SP</asp:ListItem>
                        <asp:ListItem>SE</asp:ListItem>
                        <asp:ListItem>TO</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="ValidatorEstado" runat="server" 
                        ControlToValidate="ddlEstado" ErrorMessage="Escolha o Estado" 
                        InitialValue="Selecione" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style10" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Cidade</td>
                <td class="style11">
                    <asp:TextBox ID="txtCidade" runat="server" CssClass="style8" MaxLength="20" 
                        Height="22px" Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridCidade" runat="server" 
                        ControlToValidate="txtCidade" ErrorMessage="Preencha o campo Cidade" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    CEP</td>
                <td>
                    <asp:TextBox ID="txtCEP" runat="server" CssClass="style8" MaxLength="9"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridCEP" runat="server" 
                        ControlToValidate="txtCEP" ErrorMessage="Preencha o campo CEP" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Logradouro</td>
                <td>
                    <asp:TextBox ID="txtLogradouro" runat="server" CssClass="style8" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridLogradouro" runat="server" 
                        ControlToValidate="txtLogradouro" ErrorMessage="Preencha o campo Logradouro" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Numero</td>
                <td>
                    <asp:TextBox ID="txtNumero" runat="server" Width="148px" MaxLength="6"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridNumero" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="Preencha o campo Numero" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Bairro</td>
                <td>
                    <asp:TextBox ID="txtBairro" runat="server" CssClass="style8" MaxLength="20"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridBairro" runat="server" 
                        ControlToValidate="txtBairro" ErrorMessage="Preencha o campo Bairro" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Foto</td>
                <td colspan="2">
                    <asp:FileUpload ID="uploadFoto" runat="server" Width="220px" 
                        CssClass="style8" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Qtd. Máximo Assistidos</td>
                <td>
                    <asp:TextBox ID="txtQtdMaximo" runat="server" CssClass="style8" MaxLength="3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridQtdMáximo" runat="server" 
                        ControlToValidate="txtQtdMaximo" ErrorMessage="Preencha o campo Qtd. Máximo Assistidos" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Qtd. Assistidos</td>
                <td>
                    <asp:TextBox ID="txtQtdAssistidos" runat="server" CssClass="style8" 
                        MaxLength="3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridQtdAssistidos" runat="server" 
                        ControlToValidate="txtQtdAssistidos" ErrorMessage="Preencha o campo Qtd. Assistidos" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    Gestor</td>
                <td>
                    <asp:TextBox ID="txtGestor" runat="server" CssClass="style8" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridGestor" runat="server" 
                        ControlToValidate="txtGestor" ErrorMessage="Preencha o campo Gestor" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    E-mail Gestor </td>
                <td>
                    <asp:TextBox ID="txtEmailGestor" runat="server" CssClass="style8" 
                        MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridEmailGestor" runat="server" 
                        ControlToValidate="txtEmailGestor" ErrorMessage="Preencha o campo E-mail Gestor" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA;" 
                    class="style9">
                    Telefone Gestor</td>
                <td>
                    <asp:TextBox ID="txtTelefoneGestor" runat="server" MaxLength="13" Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridTelefoneGestor" runat="server" 
                        ControlToValidate="txtTelefoneGestor" ErrorMessage="Preencha o campo Telefone Gestor" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
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
                        Width="481px" CssClass="style8" MaxLength="2000"></asp:TextBox>
                </td>
            </tr>
            </table>

        <br />

        <table width="100%">
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" onclick="btnSalvar_Click" 
                        /> &nbsp; 
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" 
                        CausesValidation="False" onclientclick="return confirm('Deseja realmente excluir a Casa Lar?')" 
                        /> &nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" 
                        CausesValidation="False" onclick="btnCancelar_Click" />
                </td>
            </tr>
            <tr align="center">
                <td> 
                    &nbsp;</td>
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

</asp:Content>
