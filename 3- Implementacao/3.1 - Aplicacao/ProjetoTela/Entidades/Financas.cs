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
        private int? _codigoCasaLar;
        private int? _codigoNatureza;
        private DateTime? _dataLancamento;
        private DateTime? _dataCriacao;
        private string _tipoLancamento;
        private Decimal? _valor;
        private string _lancadoPor;
        private string _observacao;
        private NaturezaLancamento _naturezaLancamento;

        public int? CodigoFinancas
        {
            get { return _codigoFinancas; }
            set { _codigoFinancas = value; }

        }

        public int? CodigoCasaLar
        {
            get { return _codigoCasaLar; }
            set { _codigoCasaLar = value; }

        }

        public int? CodigoNatureza
        {
            get { return _codigoNatureza; }
            set { _codigoNatureza = value; }

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

        public NaturezaLancamento NaturezaLancamento
        {
            get { return _naturezaLancamento; }
            set { _naturezaLancamento = value; }
        }

     }
 }
