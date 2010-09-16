using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Orcamento
    {
        private int _codigoOrcamento;
        private int _casalar_CodigoCasaLar;
        private string _nomePlano;
        private string _statusPlano;
        private float _valorTotal;
        private float _valorEstimado;
        private float _valorDisponivel;
        private string _nomeGasto;
        private float _valorGasto;
        private DateTime? _dataGasto;
        private int? _qtdParcelas;
        private float _gastoTotal;
        private float _mediaGastoMensal;
        private DateTime? _inicioVigencia;
        private DateTime? _fimVigencia;


        public int CodigoOrcamento
        {
            get { return _codigoOrcamento; }
            set { _codigoOrcamento = value; }
        }

        public int Casalar_CodigoCasaLar
        {
            get { return _casalar_CodigoCasaLar; }
            set { _casalar_CodigoCasaLar = value; }
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

        public float ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }

        public float ValorEstimado
        {
            get { return _valorEstimado; }
            set { _valorEstimado = value; }
        }

        public float ValorDisponivel
        {
            get { return _valorDisponivel; }
            set { _valorDisponivel = value; }
        }

        public string NomeGasto
        {
            get { return _nomeGasto; }
            set { _nomeGasto = value; }
        }

        public float ValorGasto
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

        public float GastoTotal
        {
            get { return _gastoTotal; }
            set { _gastoTotal = value; }
        }

        public float MediaGastoTotal
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