using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{

    /// <summary>
    /// Este DTO contém todos os dados do componente PessoaDadosBasico.ascx
    /// </summary>
    public class PessoaDadosBasicoDTO
    {

        private string _nome;
        private string _sexo;
        private DateTime _dataNascimento;
        private string _cpf;
        private string _rg;
        private string _nacionalidade;
        private string _naturalidade;
        //Todo: Maycon foto
        private string _foto;

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

        public string Nome
        {
            set { _nome = value;  }
            get { return _nome; }
        }

        public string Sexo
        {
            set { _sexo = value; }
            get { return _sexo; }
        }

        public DateTime DataNascimento
        {
            set { _dataNascimento = value; }
            get { return _dataNascimento; }
        }

        public string CPF
        {
            set { _cpf = value; }
            get { return _cpf; }
        }

        public string RG
        {
            set { _rg = value; }
            get { return _rg; }
        }

        public string Nacionalidade
        {
            set { _nacionalidade = value; }
            get { return _nacionalidade; }
        }

        public string Naturalidade
        {
            set { _naturalidade = value; }
            get { return _naturalidade; }
        }

        //TODO: Maycon foto
        public string Foto
        {
            set { _foto = value; }
            get { return _foto; }
        }

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