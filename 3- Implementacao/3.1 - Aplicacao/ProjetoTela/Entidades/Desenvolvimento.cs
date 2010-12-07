using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    [Serializable]
    public class Desenvolvimento
    {
        private int? _codigoDesenvolvimento;
        private int? _codigoAssistido;
        private string _atividade;
        private string _tipoAtividade;
        private string _descricaoAtividade;
        private Decimal? _valor;
        private DateTime? _dataInicio;
        private DateTime? _dataFim;
        private string _cargaHoraria;
        private string _statusAtividade;


        public int? CodigoDesenvolvimento
        {
            get { return _codigoDesenvolvimento; }
            set { _codigoDesenvolvimento = value; }
        }

        public int? CodigoAssistido
        {
            get { return _codigoAssistido; }
            set { _codigoAssistido = value; }
        }

        public string Atividade
        {
            get { return _atividade; }
            set { _atividade = value; }
        }

        public string TipoAtividade
        {
            get { return _tipoAtividade; }
            set { _tipoAtividade = value; }
        }

        public string DescricaoAtividade
        {
            get { return _descricaoAtividade; }
            set { _descricaoAtividade = value; }
        }

        public Decimal? Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public DateTime? DataInicio
        {
            get { return _dataInicio; }
            set { _dataInicio = value; }
        }

        public DateTime? DataFim
        {
            get { return _dataFim; }
            set { _dataFim = value; }
        }

        public string CargaHoraria
        {
            get { return _cargaHoraria; }
            set { _cargaHoraria = value; }
        }

        public string StatusAtividade
        {
            get { return _statusAtividade; }
            set { _statusAtividade = value; }
        }


    }
}