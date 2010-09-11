using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
    [Serializable]
    public class LoginDTO
    {

        #region Construtores

        /// <summary>
        /// Construtor com parâmetro
        /// </summary>
        /// <param name="umLogin"></param>
        public LoginDTO(Login umLogin)
        {
            this.Login = umLogin;
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public LoginDTO()
        {
        }

        #endregion

        #region Propriedades

        Login _login;

        /// <summary>
        /// Um objeto Login
        /// </summary>
        public Login Login
        {
            get { return _login; }
            set { _login = value; }
        }


        List<Login> _loginLista;

        /// <summary>
        /// Lista de Login
        /// </summary>
        public List<Login> LoginLista
        {
            get { return _loginLista; }
            set { _loginLista = value; }
        }

        private string _loginValor;
        public string LoginValor
        {
            set { _loginValor = value; }
            get { return _loginValor; }
        }

        private string _nomeValor;
        public string NomeValor
        {
            set { _nomeValor = value; }
            get { return _nomeValor; }
        }

        #endregion

    }
}