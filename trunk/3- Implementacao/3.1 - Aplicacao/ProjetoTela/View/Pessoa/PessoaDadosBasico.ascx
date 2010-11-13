<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PessoaDadosBasico.ascx.cs" Inherits="SGS.View.Pessoa.PessoaDadosBasico" %>

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

                $('.mask-data-pessoa').mask('99/99/9999'); //data pessoa
                $('.mask-hora').mask('99:99'); //hora
                $('.mask-fone-pessoa').mask('(99) 9999-9999'); //telefone pessoa
                $('.mask-rg-pessoa').mask('99.999.999-9'); //RG pessoa
                $('.mask-ag').mask('9999-9'); //Agência
                $('.mask-ag').mask('9.999-9'); //Conta
                $(".mask-cpf-pessoa").mask("999.999.999-99"); //cpf pessoa
                $(".mask-cnpj").mask("99.999.999/9999-99"); //cnpj
                $(".mask-cep-pessoa").mask("99999-999"); //cep pessoa
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

<table width="100%" style="font-size: small; font-family: Verdana;">
    <tr>
        <td colspan="2">
            <strong>Dados Pessoais</strong></td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Nome</td>
        <td colspan="2">
            <asp:TextBox ID="txtNome" runat="server" MaxLength="80" Width="400px"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="validatorNome" runat="server" 
                ControlToValidate="txtNome" ErrorMessage="Preenche o Nome do Assistido" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Sexo</td>
        <td>
            <asp:RadioButtonList ID="rdbSexo" runat="server" RepeatDirection="Horizontal" 
                RepeatLayout="Flow">
                <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                <asp:ListItem Value="Feminino">Feminino</asp:ListItem>
            </asp:RadioButtonList>
        &nbsp;<asp:RequiredFieldValidator ID="validatorSexo" runat="server" 
                ControlToValidate="rdbSexo" ErrorMessage="Escolha o Sexo do Assistido" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
        <td>
            Data nascimento</td>
        <td>
            <asp:TextBox ID="txtDataNascimento" runat="server" MaxLength="10" 
                CssClass="mask-data-pessoa"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="validatorDataNascimento" runat="server" 
                ControlToValidate="txtDataNascimento" ErrorMessage="Preenche a Data de Nascimento" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            CPF</td>
        <td>
            <asp:TextBox ID="txtCPF" runat="server" MaxLength="14" CssClass="mask-cpf"></asp:TextBox>
        </td>
        <td>
            RG</td>
        <td>
            <asp:TextBox ID="txtRG" runat="server" MaxLength="12" CssClass="mask-rg"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Cert. Nascimento</td>
        <td>
            <asp:TextBox ID="txtCertidaoNascimento" runat="server" MaxLength="14"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Nacionalidade</td>
        <td>
            <asp:TextBox ID="txtNacionalidade" runat="server" MaxLength="20"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="validatorNacionalidade" runat="server" 
                ControlToValidate="txtNacionalidade" ErrorMessage="Preenche a Nacionalidade" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
        <td>
            Naturalidade</td>
        <td>
            <asp:TextBox ID="txtNaturalidade" runat="server" MaxLength="20"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="validatorNaturalidade" runat="server" 
                ControlToValidate="txtNaturalidade" ErrorMessage="Preenche a Naturalidade" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Foto</td>
        <td colspan="3">
            <asp:FileUpload ID="fileUploadFoto" runat="server" Width="215px" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

