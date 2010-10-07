using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    [Serializable]
    public class Financas
    {
        private int? _codigoFinancas;
        private int? _casaLar_CodigoCasaLar;
        private DateTime? _dataLancamento;
        private DateTime? _dataCriacao;
        private string _tipoLancamento;
        private Decimal? _valor;
        private string _lancadoPor;
        private string _observacao;


        public int? CodigoFinancas
        {
            get { return _codigoFinancas; }
            set { _codigoFinancas = value; }

        }

        public int? CasaLar_CodigoCasaLar
        {
            get { return _casaLar_CodigoCasaLar; }
            set { _casaLar_CodigoCasaLar = value; }

        }

        public DateTime? DataLancamento
        {
            get { return _dataLancamento; }
            set { _dataLancamento = value; }
        }

        public DateTime? DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }

        public string TipoLancamento
        {
            get { return _tipoLancamento; }
            set { _tipoLancamento = value; }
        }

        public Decimal? Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string LancadoPor
        {
            get { return _lancadoPor; }
            set { _lancadoPor = value; }
        }

        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }
    }
}