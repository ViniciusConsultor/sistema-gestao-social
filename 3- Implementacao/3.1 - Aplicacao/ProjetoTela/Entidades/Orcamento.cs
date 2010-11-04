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
        private int? _CodigoCasaLar;
        private string _nomePlano;
        private string _statusPlano;
        private Decimal _valorOrcamento;
        private Decimal _saldoDisponivel;
        private DateTime? _inicioVigencia;
        private DateTime? _fimVigencia;
        private NaturezaLancamento _naturezaLancamento;
        private OrcamentoNatureza _orcamentoNatureza;
        private CasaLar _casaLar;



        public int? CodigoOrcamento
        {
            get { return _codigoOrcamento; }
            set { _codigoOrcamento = value; }
        }

        public int? CodigoCasaLar
        {
            get { return _CodigoCasaLar; }
            set { _CodigoCasaLar = value; }
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

        public Decimal ValorOrcamento
        {
            get { return _valorOrcamento; }
            set { _valorOrcamento = value; }
        }

        public Decimal SaldoDisponivel
        {
            get { return _saldoDisponivel; }
            set { _saldoDisponivel = value; }
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

        public NaturezaLancamento NaturezaLancamento
        {
            set { _naturezaLancamento = value; }
            get { return _naturezaLancamento; }

        }

        public OrcamentoNatureza OrcamentoNatureza
        { 
                set { _orcamentoNatureza = value; }
                get { return _orcamentoNatureza; }
        }

        public CasaLar CasaLar
        {
            get { return _casaLar; }
            set { _casaLar = value; }
        }




    }
}