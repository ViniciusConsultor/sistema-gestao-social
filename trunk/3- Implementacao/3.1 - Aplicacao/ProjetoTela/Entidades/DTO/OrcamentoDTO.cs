using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
        [Serializable]
    public class OrcamentoDTO
    {

        #region Construtores

        /// <summary>
        /// Construtor com parâmetro
        /// </summary>
        /// <param name="umOrcamento"></param>
        public OrcamentoDTO(Orcamento umOrcamento)
        {
            this.Orcamento = umOrcamento;
            this.NaturezaLancamento = new NaturezaLancamento();
            this.OrcamentoNatureza = new OrcamentoNatureza();
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public OrcamentoDTO()
        {
            this.Orcamento = new Orcamento();
            this.NaturezaLancamento = new NaturezaLancamento();
            this.OrcamentoNatureza = new OrcamentoNatureza();
        }

        #endregion

        #region Propriedades

        Orcamento _orcamento;

        /// <summary>
        /// Um objeto Orcamento
        /// </summary>
        public Orcamento Orcamento
        {
            get { return _orcamento; }
            set { _orcamento = value; }
        }


        List<Orcamento> _orcamentoLista;

        /// <summary>
        /// Lista de Orcamento
        /// </summary>
        public List<Orcamento> OrcamentoLista
        {
            get { return _orcamentoLista; }
            set { _orcamentoLista = value; }
        }

        private int? _codigoOrcamentoValor;
        public int? CodigoOrcamentoValor
        {
            set { _codigoOrcamentoValor = value; }
            get { return _codigoOrcamentoValor; }
        }

        private DateTime? _inicioVigenciaValor;
        public DateTime? InicioVigenciaValor
        {
            set { _inicioVigenciaValor = value; }
            get { return _inicioVigenciaValor; }
        }

        private DateTime? _fimVigenciaValor;
        public DateTime? FimVigenciaValor
        {
            set { _fimVigenciaValor = value; }
            get { return _fimVigenciaValor; }

        }

        private Decimal _valorOrcamentoValor;
        public Decimal ValorOrcamentoValor
        {
            set { _valorOrcamentoValor = value; }
            get { return _valorOrcamentoValor; }
        }

        private Decimal _saldoDisponivelValor;
        public Decimal SaldoDisponivelValor
        {
            set { _saldoDisponivelValor = value; }
            get { return _saldoDisponivelValor; }

        }

        private string _statusPlanoValor;
        public string StatusPlanoValor
        {
            set { _statusPlanoValor = value; }
            get { return _statusPlanoValor; }
        }



        NaturezaLancamento _naturezaLancamento;

        /// <summary>
        /// Um objeto NaturezaLancamento
        /// </summary>
        public NaturezaLancamento NaturezaLancamento
        {
            get { return _naturezaLancamento; }
            set { _naturezaLancamento = value; }
        }


        List<NaturezaLancamento> _naturezaLancamentoLista;

        /// <summary>
        /// Lista de NaturezaLancamento
        /// </summary>
        public List<NaturezaLancamento> NaturezaLancamentoLista
        {
            get { return _naturezaLancamentoLista; }
            set { _naturezaLancamentoLista = value; }
        }



        OrcamentoNatureza _orcamentoNatureza;

        /// <summary>
        /// Um objeto OrcamentoNatureza
        /// </summary>
        public OrcamentoNatureza OrcamentoNatureza
        {
            get { return _orcamentoNatureza; }
            set { _orcamentoNatureza = value; }
        }


        List<OrcamentoNatureza> _orcamentoNaturezaLista;

        /// <summary>
        /// Lista de OrcamentoNatureza
        /// </summary>
        public List<OrcamentoNatureza> OrcamentoNaturezaLista
        {
            get { return _orcamentoNaturezaLista; }
            set { _orcamentoNaturezaLista = value; }
        }

        #endregion

    }
}