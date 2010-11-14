<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SGS.Master" AutoEventWireup="true" CodeBehind="ManterEscolar.aspx.cs" Inherits="SGS.View.Escolar.ManterEscolar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style9
    {
        text-align: right;
        font-size: small;
    }
       .style10
       {
           width: 177px;
       }
       .style11
       {
           text-align: right;
           font-size: small;
           height: 29px;
       }
       .style12
       {
           width: 177px;
           height: 29px;
       }
       .style13
       {
           height: 29px;
       }
       .style14
       {
           text-align: right;
           font-size: small;
           height: 63px;
       }
       .style15
       {
           width: 177px;
           height: 63px;
       }
       .style16
       {
           height: 63px;
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
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Assistido</td>
                <td class="style10">
                    <asp:DropDownList ID="ddlAssistido" runat="server" Height="22px" Width="155px" 
                        DataTextField="Nome" DataValueField="CodigoAssistido">
                        <asp:ListItem>Selecione</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridAssistido" runat="server" 
                        ControlToValidate="ddlAssistido" ErrorMessage="Escolha o Assistido" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Instituição de Ensino</td>
                <td>
                    <asp:TextBox ID="txtInstituicaoEnsino" runat="server" Height="22px" 
                        Width="148px" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridInstituicaoEnsino" runat="server" 
                        ControlToValidate="txtInstituicaoEnsino" ErrorMessage="Preencha o campo Instituição de Ensino" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Nº de Inscrição</td>
                <td class="style10">
                    <asp:TextBox ID="txtNumeroInscricao" runat="server" Width="148px" Height="22px" 
                        MaxLength="10"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Média Escolar</td>
                <td>
                    <asp:TextBox ID="txtMediaEscolar" runat="server" 
                        MaxLength="2" Height="22px" Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridMediaEscolar" runat="server" 
                        ControlToValidate="txtMediaEscolar" ErrorMessage="Preencha o campo Media Escolar" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Grau de Escolaridade</td>
                <td class="style10">
                    <asp:DropDownList ID="ddlGrauEscolaridade" runat="server" Width="155px" 
                        Height="22px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Analfabeto</asp:ListItem>
                        <asp:ListItem>Sem Grau</asp:ListItem>
                        <asp:ListItem>Primário </asp:ListItem>
                        <asp:ListItem>Ensino Fundamental</asp:ListItem>
                        <asp:ListItem>Ensino Médio</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridGrauEscolaridade" runat="server" 
                        ControlToValidate="ddlGrauEscolaridade" ErrorMessage="Escolha o Grau de Escolaridade" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Série Cursada</td>
                <td>
                    <asp:TextBox ID="txtSerieCursada" runat="server" 
                        MaxLength="20" Height="22px" Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridSerieCursada" runat="server" 
                        ControlToValidate="txtSerieCursada" ErrorMessage="Preencha o campo Série Cursada" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data de Matrícula</td>
                <td class="style10">
                    <asp:TextBox ID="txtDataMatricula" runat="server" Height="22px" Width="148px" 
                        MaxLength="10" CssClass="mask-data"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridDataMatricula" runat="server" 
                        ControlToValidate="txtDataMatricula" ErrorMessage="Preencha o campo Data de Matricula " 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Data de Saída</td>
                <td>
                    <asp:TextBox ID="txtDataSaida" runat="server" Height="22px" MaxLength="10" 
                        Width="148px" CssClass="mask-data"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Status da Matrícula</td>
                <td class="style15" valign="middle">
                    <asp:RadioButtonList ID="rbtStatusMatricula" runat="server" Height="22px" 
                        Width="136px" Font-Size="Small" RepeatLayout="Flow">
                        <asp:ListItem>Matriculado</asp:ListItem>
                        <asp:ListItem>Não Matriculado</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="requeridStatusMatricula" runat="server" 
                        ControlToValidate="rbtStatusMatricula" ErrorMessage="Escolha o Status da Matricula" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style14" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Formato do Ano Letivo</td>
                <td class="style16">
                    <asp:DropDownList ID="ddlFormatoAnoLetivo" runat="server" Width="155px" 
                        Height="22px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Bimestral</asp:ListItem>
                        <asp:ListItem>Trimestral</asp:ListItem>
                        <asp:ListItem>Semestral</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="requeridFormatoAnoLetivo" runat="server" 
                        ControlToValidate="ddlFormatoAnoLetivo" ErrorMessage="Preencha o campo Formato Ano Letivo" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style11" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Matéria</td>
                <td class="style12">
                    <asp:TextBox ID="txtMateria" runat="server" Height="22px" MaxLength="20" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridMateria" runat="server" 
                        ControlToValidate="txtMateria" ErrorMessage="Preencha o campo Matéria" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style11" 
                    
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Status Matéria</td>
                <td class="style13">
                    <asp:DropDownList ID="ddlStatusMateria" runat="server" Width="155px" 
                        Height="22px">
                        <asp:ListItem>Aprovado</asp:ListItem>
                        <asp:ListItem>Recuperação</asp:ListItem>
                        <asp:ListItem>Reprovado</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Professor</td>
                <td class="style10">
                    <asp:TextBox ID="txtProfessor" runat="server" Height="22px" MaxLength="50" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridProfessor" runat="server" 
                        ControlToValidate="txtProfessor" ErrorMessage="Preencha o campo Professor" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Nota</td>
                <td>
                    <asp:TextBox ID="txtNota" runat="server" Height="22px" MaxLength="4" 
                        Width="148px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Parte do Ano Letivo</td>
                <td class="style10">
                    <asp:DropDownList ID="ddlParteAnoLetivo" runat="server" Width="155px" 
                        Height="22px">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>1ª Parte</asp:ListItem>
                        <asp:ListItem>2ª Parte</asp:ListItem>
                        <asp:ListItem>3ª Parte</asp:ListItem>
                        <asp:ListItem>4ª Parte</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Telefone</td>
                <td>
                    <asp:TextBox ID="txtTelefone" runat="server" Height="22px" MaxLength="14" 
                        Width="148px" CssClass="mask-fone"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridTelefone" runat="server" 
                        ControlToValidate="txtTelefone" ErrorMessage="Preencha o campo Telefone" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Telefone Celular</td>
                <td class="style10">
                    <asp:TextBox ID="txtTelefoneCelular" runat="server" Height="22px" 
                        MaxLength="14" Width="148px" CssClass="mask-fone"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Fax</td>
                <td>
                    <asp:TextBox ID="txtFax" runat="server" Height="22px" MaxLength="14" 
                        Width="148px" CssClass="mask-fone"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    E-mail</td>
                <td class="style10">
                    <asp:TextBox ID="txtEmail" runat="server" Height="22px" MaxLength="50" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridEmail" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Preencha o campo E-mail" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Site</td>
                <td>
                    <asp:TextBox ID="txtSite" runat="server" Height="22px" MaxLength="50" 
                        Width="148px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Blog</td>
                <td class="style10">
                    <asp:TextBox ID="txtBlog" runat="server" Height="22px" MaxLength="50" 
                        Width="148px"></asp:TextBox>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    País</td>
                <td>
                    <asp:DropDownList ID="ddlPais" runat="server" Width="155px" Enabled="False">
                        <asp:ListItem>Brasil</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Estado</td>
                <td class="style10">
                    <asp:DropDownList ID="ddlEstado" runat="server" Width="155px" Height="22px">
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
                    <asp:RequiredFieldValidator ID="requeridEstado" runat="server" 
                        ControlToValidate="ddlEstado" ErrorMessage="Escolha o Estado" 
                        ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Cidade</td>
                <td>
                    <asp:TextBox ID="txtCidade" runat="server" Height="22px" MaxLength="20" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridCidade" runat="server" 
                        ControlToValidate="txtCidade" ErrorMessage="Preencha o campo Cidade" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    CEP</td>
                <td class="style10">
                    <asp:TextBox ID="txtCEP" runat="server" Height="22px" MaxLength="9" 
                        Width="148px" CssClass="mask-cep"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridCEP" runat="server" 
                        ControlToValidate="txtCEP" ErrorMessage="Preencha o campo CEP" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Logradouro</td>
                <td>
                    <asp:TextBox ID="txtLogradouro" runat="server" Height="22px" MaxLength="40" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridLogradouro" runat="server" 
                        ControlToValidate="txtLogradouro" ErrorMessage="Preencha o campo Logradouro" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Numero</td>
                <td class="style10">
                    <asp:TextBox ID="txtNumero" runat="server" Height="22px" MaxLength="6" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridNumero" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="Preencha o campo Numero" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9" 
                    style="mso-fareast-font-family: &quot;Lucida Sans Unicode&quot;; mso-bidi-font-family: Arial; mso-font-kerning: .5pt; mso-ansi-language: PT-BR; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
                    Bairro</td>
                <td>
                    <asp:TextBox ID="txtBairro" runat="server" Height="22px" MaxLength="20" 
                        Width="148px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requeridBairro" runat="server" 
                        ControlToValidate="txtBairro" ErrorMessage="Preencha o campo Bairro" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            </table>

        <br />

        <table width="100%">
            <tr align="center">
                <td> 
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="110px" onclick="btnSalvar_Click" 
                        /> &nbsp; 
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="110px" onclick="btnExcluir_Click" 
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
