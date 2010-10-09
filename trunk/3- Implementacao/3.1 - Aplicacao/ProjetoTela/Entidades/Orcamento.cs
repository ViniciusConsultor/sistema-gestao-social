using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    [Serializable]
    public class Orcamento
    {
        private int? _codigoOrcamento;
        private int? _casaLar_CodigoCasaLar;
        private string _nomePlano;
        private string _statusPlano;
        private Decimal _valorTotal;
        private Decimal _valorEstimado;
        private Decimal? _valorDisponivel;
        private string _nomeGasto;
        private Decimal? _valorGasto;
        private DateTime? _dataGasto;
        private int? _qtdParcelas;
        private Decimal? _gastoTotal;
        private Decimal? _mediaGastoMensal;
        private DateTime? _inicioVigencia;
        private DateTime? _fimVigencia;


        public int? CodigoOrcamento
        {
            get { return _codigoOrcamento; }
            set { _codigoOrcamento = value; }
        }

        public int? CasaLar_CodigoCasaLar
        {
            get { return _casaLar_CodigoCasaLar; }
            set { _casaLar_CodigoCasaLar = value; }
        }

        public string NomePlano
        {
            get { return _nomePlano; }
            set { _nomePlano = value; }
        }

        public string StatusPlano
        {
            get { return _statusPlano; }
            set { _statusPlano = value; }
        }

        public Decimal ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }

        public Decimal ValorEstimado
        {
            get { return _valorEstimado; }
            set { _valorEstimado = value; }
        }

        public Decimal? ValorDisponivel
        {
            get { return _valorDisponivel; }
            set { _valorDisponivel = value; }
        }

        public string NomeGasto
        {
            get { return _nomeGasto; }
            set { _nomeGasto = value; }
        }

        public Decimal? ValorGasto
        {
            get { return _valorGasto; }
            set { _valorGasto = value; }
        }

        public DateTime? DataGasto
        {
            get { return _dataGasto; }
            set { _dataGasto = value; }
        }

        public int? QtdParcelas
        {
            get { return _qtdParcelas; }
            set { _qtdParcelas = value; }
        }

        public Decimal? GastoTotal
        {
            get { return _gastoTotal; }
            set { _gastoTotal = value; }
        }

        public Decimal? MediaGastoMensal
        {
            get { return _mediaGastoMensal; }
            set { _mediaGastoMensal = value; }
        }

        public DateTime? InicioVigencia
        {
            get { return _inicioVigencia; }
            set { _inicioVigencia = value; }
        }

        public DateTime? FimVigencia
        {
            get { return _fimVigencia; }
            set { _fimVigencia = value; }
        }


    }
}