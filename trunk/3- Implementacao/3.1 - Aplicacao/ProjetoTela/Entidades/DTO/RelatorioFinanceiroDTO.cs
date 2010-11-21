using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
    [Serializable]
    public class FinanceiroRelatorioDTO
    {
        public FinanceiroRelatorioDTO()
        {
            OrcamentoDTO = new OrcamentoDTO();
        }

        private string _tipoLancamentoValor;
        public string TipoLancamentoValor
        {
            get { return _tipoLancamentoValor; }
            set { _tipoLancamentoValor = value; }
        }

        private int? _naturezaLancamentoValor;
        public int? NaturezaLancamentoValor
        {
            get { return _naturezaLancamentoValor; }
            set { _naturezaLancamentoValor = value; }
        }

        private DateTime? _dtInicioValor;
        public DateTime? DtInicioValor
        {
            get { return _dtInicioValor; }
            set { _dtInicioValor = value; }
        }

        private DateTime? _dtFimValor;
        public DateTime? DtFimValor
        {
            get { return _dtFimValor; }
            set { _dtFimValor = value; }
        }

        private List<Financas> _financasLista;
        public List<Financas> FinancasLista
        {
            get { return _financasLista;  }
            set { _financasLista = value; }
        }

        private List<NaturezaLancamento> _naturezaLancamentoLista;
        public List<NaturezaLancamento> NaturezaLancamentoLista
        {
            get { return _naturezaLancamentoLista; }
            set { _naturezaLancamentoLista = value; }
        }

        private List<Orcamento> _orcamentoLista;
        public List<Orcamento> OrcamentoLista
        {
            get { return _orcamentoLista; }
            set { _orcamentoLista = value; }
        }

        private int? _CodigoPlanoValor;
        public int? CodigoPlanoValor
        {
            get { return _CodigoPlanoValor; }
            set { _CodigoPlanoValor = value; }
        }

        private OrcamentoDTO _orcamentoDTO;
        public OrcamentoDTO OrcamentoDTO
        {
            get { return _orcamentoDTO; }
            set { _orcamentoDTO = value; }
        }

    }
}