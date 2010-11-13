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

    }
}