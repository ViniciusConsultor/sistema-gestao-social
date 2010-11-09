<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PessoaAssistido.ascx.cs" Inherits="SGS.View.Pessoa.PessoaAssistido" %>
<table width="100%">
    <tr>
        <td colspan="4">
            <strong>Dados Assistido</strong></td>
    </tr>
    <tr>
        <td colspan="4">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Status Assistido</td>
        <td>
            <asp:DropDownList ID="ddlStatusAssistido" runat="server" Width="130px">
                <asp:ListItem Value="Selecione">Selecione</asp:ListItem>
                <asp:ListItem>Em Atendimento</asp:ListItem>
                <asp:ListItem>Retornou Família</asp:ListItem>
                <asp:ListItem>Adotado</asp:ListItem>
                <asp:ListItem>Transferido</asp:ListItem>
                <asp:ListItem>Desaparecido</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Data Entrada</td>
        <td>
            <asp:TextBox ID="txtDataEntrada" runat="server" MaxLength="10"></asp:TextBox>
        </td>
        <td>
            Data Saída</td>
        <td>
            <asp:TextBox ID="txtDataSaida" runat="server" MaxLength="10"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Estado Saúde</td>
        <td>
            <asp:DropDownList ID="ddlEstadoSaude" runat="server" Width="130px">
                <asp:ListItem Value="Saudavel">Saudável</asp:ListItem>
                <asp:ListItem>Doente</asp:ListItem>
                <asp:ListItem>Internado</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            Peso</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtPeso" runat="server" MaxLength="6"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Cor</td>
        <td>
            <asp:DropDownList ID="ddlCor" runat="server" Width="130px">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem Value="Branco">Branco</asp:ListItem>
                <asp:ListItem>Negro</asp:ListItem>
                <asp:ListItem>Pardo</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            Altura</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtAltura" runat="server" MaxLength="6"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Tam. Camisa</td>
        <td>
            <asp:DropDownList ID="ddlTamanhoCamisa" runat="server" Width="130px">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem Value="PP">PP</asp:ListItem>
                <asp:ListItem>P</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>G</asp:ListItem>
                <asp:ListItem>GG</asp:ListItem>
                <asp:ListItem>EXG</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            Tam. Calça</td>
        <td style="margin-left: 40px">
            <asp:DropDownList ID="ddlTamanhoCalca" runat="server" Width="130px">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem Value="PP">PP</asp:ListItem>
                <asp:ListItem>P</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>G</asp:ListItem>
                <asp:ListItem>GG</asp:ListItem>
                <asp:ListItem>EXG</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Tam. Calçado</td>
        <td>
            <asp:TextBox ID="txtTamanhoCalcado" runat="server" MaxLength="2"></asp:TextBox>
        </td>
        <td>
            Dormitório</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtDormitorio" runat="server" MaxLength="20"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Deficiente</td>
        <td>
            <asp:RadioButtonList ID="rblDeficiente" runat="server" 
                RepeatDirection="Horizontal">
                <asp:ListItem>Sim</asp:ListItem>
                <asp:ListItem Value="N">Não</asp:ListItem>
            </asp:RadioButtonList>
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
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <strong>Dados Família</strong></td>
        <td>
            &nbsp;</td>
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
        <td>
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
        <td>
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
        <td>
            <asp:TextBox ID="txtCPFPai" runat="server" MaxLength="14"></asp:TextBox>
        </td>
        <td>
            CPF Mãe</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtCPFMae" runat="server" MaxLength="14"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            RG Pai</td>
        <td>
            <asp:TextBox ID="txtRGPai" runat="server" MaxLength="12"></asp:TextBox>
        </td>
        <td>
            RG Mãe</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtRGMae" runat="server" MaxLength="12"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Tel. Pai</td>
        <td>
            <asp:TextBox ID="txtTelPai" runat="server" MaxLength="14"></asp:TextBox>
        </td>
        <td>
            Tel.Mãe</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtTelMae" runat="server" MaxLength="14"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Qtd. Irmãos</td>
        <td>
            <asp:TextBox ID="txtQtdIrmaos" runat="server" MaxLength="2"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <strong>Dados do Responsável</strong></td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Responsável</td>
        <td colspan="2">
            <asp:TextBox ID="txtResponsavel" runat="server" MaxLength="80" Width="400px"></asp:TextBox>
            </td>
        <td>
            &nbsp;</td>
       
    </tr>
    <tr>
        <td>
            CPF </td>
        <td>
            <asp:TextBox ID="txtCPFResponsavel" runat="server" MaxLength="14"></asp:TextBox>
        </td>

          <td>
            Tel. Reponsável
            </td>
        <td>
            <asp:TextBox ID="txtTelResponsavel" runat="server" MaxLength="14"></asp:TextBox>
        </td>
       
        
    </tr>
    <tr>
        <td>
            E-mail Responsável</td>
        <td>
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
        <td>
            <asp:TextBox ID="txtCEPResponsavel" runat="server" MaxLength="20"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Logradouro</td>
        <td>
            <asp:TextBox ID="txtLogradouroResponsavel" runat="server" MaxLength="50"></asp:TextBox>
        </td>
        <td>
            Número</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtNumeroResponsavel" runat="server" MaxLength="6"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Bairro</td>
        <td>
            <asp:TextBox ID="txtBairroResponsavel" runat="server" MaxLength="25"></asp:TextBox>
        </td>
        <td>
            Cidade</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtCidadeResponsavel" runat="server" MaxLength="20"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Estado</td>
        <td>
            <asp:TextBox ID="txtEstadoResponsavel" runat="server" MaxLength="20"></asp:TextBox>
        </td>
        <td>
            País</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="txtPaisResponsavel" runat="server" MaxLength="20"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
</table>

