using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Pessoa
    {
        private int _codPessoa;
        private string _nome;
        private string _sexo;
        private int? _cpf;
        private int? _rg;
        private int? _tituloEleitor;
        private DateTime? _dataNascimento;
        private string _naturalidade;
        private string _nacionalidade;
        private string _foto;


        public int codpessoa
        {
            get { return _codPessoa; }
            set { _codPessoa = value; }
        }

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public int? cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public int? rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        public int? tituloEleitor
        {
            get { return _tituloEleitor; }
            set { _tituloEleitor = value; }
        }

        public DateTime? dataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

        public string naturalidade
        {
            get { return _naturalidade; }
            set { _naturalidade = value; }
        }

        public string nacionalidade
        {
            get { return _nacionalidade; }
            set { _nacionalidade = value; }
        }

        public string foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

    }
}