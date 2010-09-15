using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Patricionador
    {
        private int _codPatrocinador;
        private int _pessoa_CodPessoa;
        private string _empresa;
        private int? _cnpj;
        private string _ramoAtividade;
        private float _valorContribuicao;
        private string _periodicidadeContribuicao;


        public int codPatrocinador
        {
            get { return _codPatrocinador; }
            set { _codPatrocinador = value; }
        }

        public int pessoa_CodPessoa
        {
            get { return _pessoa_CodPessoa; }
            set { _pessoa_CodPessoa = value; }
        }

        public string empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        public int? cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public string ramoAtividade
        {
            get { return _ramoAtividade; }
            set { _ramoAtividade = value; }
        }

        public float valorContribuicao
        {
            get { return _valorContribuicao; }
            set { _valorContribuicao = value; }
        }

        public string periodicidadeContribuicao
        {
            get { return _periodicidadeContribuicao; }
            set { _periodicidadeContribuicao = value; }
        }
           
    }
}