using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;

namespace SGS.Entidades.DTO 
{
    public class SessaoDTO : Login
    {

        #region Construtores

        /// <summary>
        /// Construtor com parâmetro
        /// </summary>
        /// <param name="umLogin"></param>
        public SessaoDTO(Login umLogin)
        {
            this.Login = umLogin;
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public SessaoDTO()
        {
        }

        #endregion

        #region Propriedades 

        Login _login;
        public Login Login
        {
            get { return _login; }
            set { _login = value; }
        }

        #endregion

    }
}