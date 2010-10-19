using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Componentes;

namespace SGS.Entidades
{
    [Serializable]
    public class Login
    {
        private int? _codigoLogin;
        private int? _pessoa_CodigoPessoa;
        private string _nome;
        private string _loginUsuario;
        private string _senha;
        private string _email;
        private string _perfil;

        public int? CodigoLogin
        {
            get { return _codigoLogin; }
            set { _codigoLogin = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string LoginUsuario
        {
            get { return _loginUsuario; }
            set { _loginUsuario = value; }
        }

        public string Senha
        {
            get 
            { 
                //Este código Descriptografa a senha
                return Criptografia.Descriptografar(_senha, "Protetor"); 
            }
            set 
            {
                //Este código Criptografa a senha
                _senha = Criptografia.Criptografar(value, "Protetor"); 
            }
        }

        /// <summary>
        /// Esta propriedade retorna a senha criptografada do Login
        /// </summary>
        public string SenhaCriptografada
        {
            get
            {
                return _senha;
            }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

    }
}