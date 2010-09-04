using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Contato
    {
        private int _codContato;
        private string _logradouro;
        private int _numero;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _pais;
        private int _cep;
        private int _telConvencional;
        private int _telCelular;
        private int _fax;
        private string _email;
        private string _site;
        private string _blog;


        public int codContato
        {
            get { return _codContato; }
            set { _codContato = value; }
        }

        public string logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        public int numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        public string cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public int cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public int telConvencional
        {
            get { return _telConvencional; }
            set { _telConvencional = value; }
        }

        public int telCelular
        {
            get { return _telCelular; }
            set { _telCelular = value; }
        }

        public int fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string site
        {
            get { return _site; }
            set { _site = value; }
        }

        public string blog
        {
            get { return _blog; }
            set { _blog = value; }
        }
    }
}