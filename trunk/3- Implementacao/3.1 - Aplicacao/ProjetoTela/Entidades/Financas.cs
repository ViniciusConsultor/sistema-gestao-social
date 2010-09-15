using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Financas
    {
        private int _codFinancas;
        private int _casalar_CodCasaLar;
        private DateTime? _dataLancamento;
        private DateTime? _dataCriacao;
        private string _tipoLancamento;
        private Decimal? _valor;
        private string _lancadoPor;
        private string _observacao;


        public int codFinancas
        {
            get { return _codFinancas; }
            set { _codFinancas = value; }

        }

        public int casalar_CodCasaLar
        {
            get { return _casalar_CodCasaLar; }
            set { _casalar_CodCasaLar = value; }

        }

        public DateTime? dataLancamento
        {
            get { return _dataLancamento; }
            set { _dataLancamento = value; }
        }

        public DateTime? dataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }

        public string tipoLancamento
        {
            get { return _tipoLancamento; }
            set { _tipoLancamento = value; }
        }

        public Decimal? valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string lancadoPor
        {
            get { return _lancadoPor; }
            set { _lancadoPor = value; }
        }

        public string observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }
    }
}