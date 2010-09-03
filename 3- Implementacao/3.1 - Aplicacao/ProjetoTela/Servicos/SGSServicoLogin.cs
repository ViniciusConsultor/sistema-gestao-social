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

        public Login ValidarLogin(Login umLogin)
        {
            LoginDados umLoginDados = new LoginDados();
            
            return umLoginDados.ValidarLogin(umLogin);
        }

    }
}