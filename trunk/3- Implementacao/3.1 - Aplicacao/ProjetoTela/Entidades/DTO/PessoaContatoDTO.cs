using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
    public class PessoaContatoDTO
    {
        private string _cep;
        private string _logradouro;
        private string _numero;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _pais;

        private string _telCelular;
        private string _telConvencional;
        private string _fax;
        private string _site;
        private string _blog;

        public string Cep
        {
            set { _cep = value; }
            get { return _cep; }
        }

        public string Logradouro
        {
            set { _logradouro = value; }
            get { return _logradouro; }
        }

        public string Numero
        {
            set { _numero = value; }
            get { return _numero; }
        }

        public string Bairro
        {
            set { _bairro = value; }
            get { return _bairro; }
        }

        public string Cidade
        {
            set { _cidade = value; }
            get { return _cidade; }
        }

        public string Estado
        {
            set { _estado = value; }
            get { return _estado; }
        }

        public string Pais
        {
            set { _pais = value; }
            get { return _pais; }
        }

        public string TelCelular
        {
            set { _telCelular = value; }
            get { return _telCelular; }
        }

        public string TelConvencional
        {
            set { _telConvencional = value; }
            get { return _telConvencional; }
        }

        public string Fax
        {
            set { _fax = value; }
            get { return _fax; }
        }

        public string Site
        {
            set { _site = value; }
            get { return _site; }
        }

        public string Blog
        {
            set { _blog = value; }
            get { return _blog; }
        }
    }
}