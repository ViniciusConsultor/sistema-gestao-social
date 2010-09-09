using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public int? Pessoa_CodigoPessoa
        {
            get { return _pessoa_CodigoPessoa; }
            set { _pessoa_CodigoPessoa = value; }
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
            get { return _senha; }
            set { _senha = value; }
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