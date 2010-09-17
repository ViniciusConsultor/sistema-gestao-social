using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Patrocinador
    {
        private int? _codigoPatrocinador;
        private int? _pessoa_CodigoPessoa;
        private string _empresa;
        private string _cnpj;
        private string _ramoAtividade;
        private Decimal? _valorContribuicao;
        private string _periodicidadeContribuicao;


        public int? CodigoPatrocinador
        {
            get { return _codigoPatrocinador; }
            set { _codigoPatrocinador = value; }
        }

        public int? Pessoa_CodigoPessoa
        {
            get { return _pessoa_CodigoPessoa; }
            set { _pessoa_CodigoPessoa = value; }
        }

        public string Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public string RamoAtividade
        {
            get { return _ramoAtividade; }
            set { _ramoAtividade = value; }
        }

        public Decimal? ValorContribuicao
        {
            get { return _valorContribuicao; }
            set { _valorContribuicao = value; }
        }

        public string PeriodicidadeContribuicao
        {
            get { return _periodicidadeContribuicao; }
            set { _periodicidadeContribuicao = value; }
        }
           
    }
}