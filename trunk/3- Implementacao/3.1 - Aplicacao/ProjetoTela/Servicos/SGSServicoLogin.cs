using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;
using SGS.CamadaDados;

namespace SGS.Servicos
{
    public partial class SGSServico
    {

        public Login ValidarLogin(Login objLogin)
        {
            LoginDados objLoginDados = new LoginDados();
            
            return objLoginDados.ValidarLogin(objLogin);
        }

        public Login SalvarLogin(Login objLogin)
        {
            LoginDados objLoginDados = new LoginDados();

            objLogin = objLoginDados.Salvar(objLogin);

            return objLogin;
        }

        public Login ObterLogin(int codigoLogin)
        {
            LoginDados objLoginDados = new LoginDados();

            return objLoginDados.ObterLogin(codigoLogin);
        }

        public bool ExcluirLogin(int codigoLogin)
        {
            LoginDados objLoginDados = new LoginDados();

            return objLoginDados.ExcluirLogin(codigoLogin);
        }

    }
}