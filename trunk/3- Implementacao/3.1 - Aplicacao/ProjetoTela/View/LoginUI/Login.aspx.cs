using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SGS.Entidades;
using SGS.Servicos;
using SGS.Entidades.DTO;

namespace ProjetoTela.Telas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       /// <summary>
       /// Este é o método OnClick do botão btnLogar
       /// </summary>
        protected void btnLogar_Click(object sender, EventArgs e)
        {
            SGS.Entidades.Login umLogin = new SGS.Entidades.Login();
            SGSServico umSGSService = new SGSServico();
           
            umLogin.LoginUsuario = txtNome.Text;
            umLogin.Senha = txtSenha.Text;

            umLogin = umSGSService.ValidarLogin(umLogin);

            if (umLogin != null)
            {
                SessaoDTO umSessaoDTO = new SessaoDTO(umLogin);
                Session.Add("Sessao", umSessaoDTO);
                Server.Transfer("../Apresentacao.aspx");
            }
            else
            {
                ExibirCritica("Dados para acesso inválidos!");
            }
          
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSenha.Text = "";
        }

        public void ExibirCritica(string critica)
        {
            RequiredFieldValidator validator = new RequiredFieldValidator();
            validator.ErrorMessage = critica;
            validator.IsValid = false;

            Page.Validators.Add(validator);
        }

        public void EmitirAlerta()
        {
            String meuscript = "alert('Preencha o campo de busca!');";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "meuscript", meuscript, true);
        }
       
        
    }
}