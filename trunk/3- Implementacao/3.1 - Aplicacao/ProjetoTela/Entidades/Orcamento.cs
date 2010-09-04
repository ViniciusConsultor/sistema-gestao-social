using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Orcamento
    {
        private int _codOrcamento;
        private string _nomePlano;
        private string _statusPlano;
        private float _valorTotal;
        private float _valorEstimado;
        private float _valorDisponivel;
        private string _nomeGasto;
        private float _valorGasto;
        private DateTime _dataGasto;
        private int _qtdParcelas;
        private float _gastoTotal;
        private float _mediaGastoMensal;
        private DateTime _inicioVigencia;
        private DateTime _fimVigencia;


        public int codOrcamento
        {
            get { return _codOrcamento; }
            set { _codOrcamento = value; }
        }

        public string nomePlano
        {
            get { return _nomePlano; }
            set { _nomePlano = value; }
        }

        public string statusPlano
        {
            get { return _statusPlano; }
            set { _statusPlano = value; }
        }

        public float valorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }

        public float valorEstimado
        {
            get { return _valorEstimado; }
            set { _valorEstimado = value; }
        }

        public float valorDisponivel
        {
            get { return _valorDisponivel; }
            set { _valorDisponivel = value; }
        }

        public string nomeGasto
        {
            get { return _nomeGasto; }
            set { _nomeGasto = value; }
        }

        public float valorGasto
        {
            get { return _valorGasto; }
            set { _valorGasto = value; }
        }

        public DateTime dataGasto
        {
            get { return _dataGasto; }
            set { _dataGasto = value; }
        }

        public int qtdParcelas
        {
            get { return _qtdParcelas; }
            set { _qtdParcelas = value; }
        }

        public float gastoTotal
        {
            get { return _gastoTotal; }
            set { _gastoTotal = value; }
        }

        public float mediaGastoTotal
        {
            get { return _mediaGastoMensal; }
            set { _mediaGastoMensal = value; }
        }

        public DateTime inicioVigencia
        {
            get { return _inicioVigencia; }
            set { _inicioVigencia = value; }
        }

        public DateTime fimVigencia
        {
            get { return _fimVigencia; }
            set { _fimVigencia = value; }
        }


    }
}