using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Contato
    {
        private int _codigoContato;
        private int _pessoa_CodigoPessoa;
        private string _logradouro;
        private string _numero;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _pais;
        private string _cep;
        private string _telConvencional;
        private string _telCelular;
        private string _fax;
        private string _email;
        private string _site;
        private string _blog;


        public int CodigoContato
        {
            get { return _codigoContato; }
            set { _codigoContato = value; }
        }

        public int Pessoa_CodigoPessoa
        {
            get { return _pessoa_CodigoPessoa; }
            set { _pessoa_CodigoPessoa = value; }
        }

        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public string TelConvencional
        {
            get { return _telConvencional; }
            set { _telConvencional = value; }
        }

        public string TelCelular
        {
            get { return _telCelular; }
            set { _telCelular = value; }
        }

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Site
        {
            get { return _site; }
            set { _site = value; }
        }

        public string Blog
        {
            get { return _blog; }
            set { _blog = value; }
        }
    }
}