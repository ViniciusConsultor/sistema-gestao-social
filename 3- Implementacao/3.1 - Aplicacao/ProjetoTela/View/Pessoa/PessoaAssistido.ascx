<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PessoaAssistido.ascx.cs" Inherits="SGS.View.Pessoa.PessoaAssistido" %>

<!-- Importa todos os script JavaScript-->
        <style type="text/css">
            .style1
            {
                width: 73px;
            }
            </style>
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

                $('.mask-numero').mask('99999'); //número
                $('.mask-numero2').maskMoney({ precision: 6 }); //número
                $('.mask-peso').mask('999'); //número
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

<table width="100%" style="font-size: small; font-family: Verdana">
    <tr>
        <td colspan="4" style="color: #003499">
            <strong><u>Dados Assistido</u></strong></td>
    </tr>
    <tr>
        <td>
            Status Assistido</td>
        <td class="style1">
            <asp:DropDownList ID="ddlStatusAssistido" runat="server" Width="155px">
                <asp:ListItem Value="Selecione">Selecione</asp:ListItem>
                <asp:ListItem>Em Atendimento</asp:ListItem>
                <asp:ListItem>Retornou Família</asp:ListItem>
                <asp:ListItem>Adotado</asp:ListItem>
                <asp:ListItem>Transferido</asp:ListItem>
                <asp:ListItem>Desaparecido</asp:ListItem>
                <asp:ListItem>A Passeio</asp:ListItem>
            </asp:DropDownList>
        &nbsp;<asp:RequiredFieldValidator ID="validatorStatusAssistido" runat="server" 
                ControlToValidate="ddlStatusAssistido" ErrorMessage="Escolha o Status do Assistido" 
                ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Data Entrada</td>
        <td class="style1">
            <asp:TextBox ID="txtDataEntrada" runat="server" MaxLength="10" 
                CssClass="mask-data" Width="147px"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="validatorDataEntrada" runat="server" 
                ControlToValidate="txtDataEntrada" ErrorMessage="Preencha a Data de Entrada" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
        <td>
            Data Saída</td>
        <td>
            <asp:TextBox ID="txtDataSaida" runat="server" MaxLength="10" 
                CssClass="mask-data" Width="147px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Estado Saúde</td>
        <td class="style1">
            <asp:DropDownList ID="ddlEstadoSaude" runat="server" Width="155px">
                <asp:ListItem Value="Saudavel">Saudável</asp:ListItem>
                <asp:ListItem>Doente</asp:ListItem>
            </asp:DropDownList>
        &nbsp;<asp:RequiredFieldValidator ID="validatorEstadoSaude" runat="server" 
                ControlToValidate="ddlEstadoSaude" ErrorMessage="Escolha o Estado de Saúde" 
                ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
        </td>
        <td>
            Peso(Kg)</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtPeso" runat="server" MaxLength="3" Width="147px"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="validatorPeso" runat="server" 
                ControlToValidate="txtPeso" ErrorMessage="Preencha o Peso" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Etnia</td>
        <td class="style1">
            <asp:DropDownList ID="ddlCor" runat="server" Width="155px">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem Value="Branco">Branco</asp:ListItem>
                <asp:ListItem>Negro</asp:ListItem>
                <asp:ListItem>Caboclo</asp:ListItem>
                <asp:ListItem>Mulato</asp:ListItem>
                <asp:ListItem>Cafuzo</asp:ListItem>
                <asp:ListItem>Indígena</asp:ListItem>
            </asp:DropDownList>
        &nbsp;<asp:RequiredFieldValidator ID="validatorEtnia" runat="server" 
                ControlToValidate="ddlCor" ErrorMessage="Escolha a Etnia" 
                ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
        </td>
        <td>
            Altura</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtAltura" runat="server" MaxLength="6" Width="147px"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="validatorAltura" runat="server" 
                ControlToValidate="txtAltura" ErrorMessage="Preencha a Altura" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Tam. Camisa</td>
        <td class="style1">
            <asp:DropDownList ID="ddlTamanhoCamisa" runat="server" Width="155px">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem Value="PP">PP</asp:ListItem>
                <asp:ListItem>P</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>G</asp:ListItem>
                <asp:ListItem>GG</asp:ListItem>
                <asp:ListItem>EXG</asp:ListItem>
            </asp:DropDownList>
        &nbsp;<asp:RequiredFieldValidator ID="validatorTamCamisa" runat="server" 
                ControlToValidate="ddlTamanhoCamisa" ErrorMessage="Escolha o Tamanho da Camisa" 
                ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
        </td>
        <td>
            Tam. Calça</td>
        <td style="margin-left: 40px">
            <asp:DropDownList ID="ddlTamanhoCalca" runat="server" Width="155px">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem Value="PP">PP</asp:ListItem>
                <asp:ListItem>P</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>G</asp:ListItem>
                <asp:ListItem>GG</asp:ListItem>
                <asp:ListItem>EXG</asp:ListItem>
            </asp:DropDownList>
        &nbsp;<asp:RequiredFieldValidator ID="validatorTamCalca" runat="server" 
                ControlToValidate="ddlTamanhoCalca" ErrorMessage="Escolha o Tamanho da Calça" 
                ForeColor="Red" InitialValue="Selecione">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Tam. Calçado</td>
        <td class="style1">
            <asp:TextBox ID="txtTamanhoCalcado" runat="server" MaxLength="2" Width="147px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="validatorTamCalcado" runat="server" 
                ControlToValidate="txtTamanhoCalcado" ErrorMessage="Preencha o Tamanho do Calçado" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
        <td>
            Dormitório</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtDormitorio" runat="server" MaxLength="20" Width="147px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Deficiente</td>
        <td class="style1">
            <asp:RadioButtonList ID="rblDeficiente" runat="server" 
                RepeatDirection="Horizontal">
                <asp:ListItem>Sim</asp:ListItem>
                <asp:ListItem Value="N">Não</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="validatorDeficiente" runat="server" 
                ControlToValidate="rblDeficiente" ErrorMessage="Informe se o Assistido é Deficiente" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Hobby&#39;s</td>
        <td colspan="3">
            <asp:TextBox ID="txtHobby" runat="server" MaxLength="100" Height="100px" 
                TextMode="MultiLine" Width="430px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Histórico de Vida</td>
        <td colspan="3">
            <asp:TextBox ID="txtHistoricoVida" runat="server" MaxLength="2000" 
                Height="100px" TextMode="MultiLine" Width="430px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="color: #003499" colspan="2">
            <strong><u>Dados Família</u></strong></td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Pai</td>
        <td colspan="2">
            <asp:TextBox ID="txtPai" runat="server" MaxLength="80" Width="400px"></asp:TextBox>
            </td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Mãe</td>
        <td class="style1">
            <asp:TextBox ID="txtMae" runat="server" MaxLength="80" Width="400px"></asp:TextBox>
            </td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Pai Vivo</td>
        <td class="style1">
            <asp:RadioButtonList ID="rblPaiVivo" runat="server" 
                RepeatDirection="Horizontal">
                <asp:ListItem Value="S">Sim</asp:ListItem>
                <asp:ListItem Value="N">Não</asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
            Mãe Viva</td>
        <td style="margin-left: 40px">
            <asp:RadioButtonList ID="rblMaeViva" runat="server" 
                RepeatDirection="Horizontal">
                <asp:ListItem Value="S">Sim</asp:ListItem>
                <asp:ListItem Value="N">Não</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>
            CPF Pai</td>
        <td class="style1">
            <asp:TextBox ID="txtCPFPai" runat="server" MaxLength="14" CssClass="mask-cpf" 
                Width="147px"></asp:TextBox>
        </td>
        <td>
            CPF Mãe</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtCPFMae" runat="server" MaxLength="14" CssClass="mask-cpf" 
                Width="147px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            RG Pai</td>
        <td class="style1">
            <asp:TextBox ID="txtRGPai" runat="server" MaxLength="12" CssClass="mask-rg" 
                Width="147px"></asp:TextBox>
        </td>
        <td>
            RG Mãe</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtRGMae" runat="server" MaxLength="12" CssClass="mask-rg" 
                Width="147px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Tel. Pai</td>
        <td class="style1">
            <asp:TextBox ID="txtTelPai" runat="server" MaxLength="14" CssClass="mask-fone" 
                Width="147px"></asp:TextBox>
        </td>
        <td>
            Tel.Mãe</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtTelMae" runat="server" MaxLength="14" CssClass="mask-fone" 
                Width="147px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Qtd. Irmãos</td>
        <td class="style1">
            <asp:TextBox ID="txtQtdIrmaos" runat="server" MaxLength="2" Width="147px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2" style="color: #003499">
            <strong><u>Dados do Responsável</u></strong></td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Responsável</td>
        <td colspan="3">
            <asp:TextBox ID="txtResponsavel" runat="server" MaxLength="80" Width="400px"></asp:TextBox>
            </td>
       
    </tr>
    <tr>
        <td>
            CPF </td>
        <td class="style1">
            <asp:TextBox ID="txtCPFResponsavel" runat="server" MaxLength="14" 
                CssClass="mask-cpf" Width="147px"></asp:TextBox>
        </td>

          <td>
            Tel. Reponsável
            </td>
        <td>
            <asp:TextBox ID="txtTelResponsavel" runat="server" MaxLength="14" 
                CssClass="mask-fone" Width="147px"></asp:TextBox>
        </td>
       
        
    </tr>
    <tr>
        <td>
            E-mail Responsável</td>
        <td class="style1">
            <asp:TextBox ID="txtEmailResponsavel" runat="server" MaxLength="50" 
                Width="250px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Cep</td>
        <td class="style1">
            <asp:TextBox ID="txtCEPResponsavel" runat="server" MaxLength="20" 
                CssClass="mask-cep" Width="147px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Logradouro</td>
        <td class="style1">
            <asp:TextBox ID="txtLogradouroResponsavel" runat="server" MaxLength="50" 
                Width="147px"></asp:TextBox>
        </td>
        <td>
            Número</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtNumeroResponsavel" runat="server" MaxLength="6" 
                Width="147px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Bairro</td>
        <td class="style1">
            <asp:TextBox ID="txtBairroResponsavel" runat="server" MaxLength="25" 
                Width="147px"></asp:TextBox>
        </td>
        <td>
            Cidade</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtCidadeResponsavel" runat="server" MaxLength="20" 
                Width="147px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Estado</td>
        <td class="style1">
                    <asp:DropDownList ID="ddlEstadoResponsavel" runat="server" 
                Width="155px" Height="22px">
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
        </td>
        <td>
            País</td>
        <td style="margin-left: 40px">
                    <asp:DropDownList ID="ddlPaisResponsavel" runat="server" Width="155px" 
                Enabled="False">
                        <asp:ListItem>Selecione</asp:ListItem>
                        <asp:ListItem>Brasil</asp:ListItem>
                    </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
</table>

