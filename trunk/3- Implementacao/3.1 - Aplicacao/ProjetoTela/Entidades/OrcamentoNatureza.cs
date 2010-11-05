using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Componentes;

namespace SGS.Entidades
{
    [Serializable]
    public class OrcamentoNatureza
    {
        private int? _codigoNatureza;
        private int? _codigoOrcamento;
        private Decimal? _valor;
        private DateTime _dataCriacao;


        public int? CodigoNatureza
        {
            set { _codigoNatureza = value; }
            get { return _codigoNatureza; }
        }

        public int? CodigoOrcamento
        {
            set { _codigoOrcamento = value; }
            get { return _codigoOrcamento; }
        }

        public Decimal? Valor
        {
            set { _valor = value; }
            get { return _valor; }
        }

        public DateTime DataCriacao
        {
            set { _dataCriacao = value; }
            get { return _dataCriacao; }
        }
    }
}