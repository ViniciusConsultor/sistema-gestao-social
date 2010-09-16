using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Pessoa
    {
        private int _codigoPessoa;
        private string _nome;
        private string _sexo;
        private string _cpf;
        private string _rg;
        private string _tituloEleitor;
        private DateTime? _dataNascimento;
        private string _naturalidade;
        private string _nacionalidade;
        private string _foto;


        public int Codigopessoa
        {
            get { return _codigoPessoa; }
            set { _codigoPessoa = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        public string TituloEleitor
        {
            get { return _tituloEleitor; }
            set { _tituloEleitor = value; }
        }

        public DateTime? DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

        public string Naturalidade
        {
            get { return _naturalidade; }
            set { _naturalidade = value; }
        }

        public string Nacionalidade
        {
            get { return _nacionalidade; }
            set { _nacionalidade = value; }
        }

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

    }
}