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
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public OrcamentoDTO()
        {
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

        private string _nomePlanoValor;
        public string NomePlanoValor
        {
            set { _nomePlanoValor = value; }
            get { return _nomePlanoValor; }
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

        /*    private string _naturezaDespesaValor;

              public string NaturezaDespesaValor
               {
                   set { _naturezaDespesaValor = value; }
                   get { return _naturezaDespesaValor; }
               } 

               private Decimal _valorDespesaValor;
               public Decimal ValorDespesaValor
               {
                   set { _valorDespesaValor = value;}
                   get { return _valorDespesaValor;
               }*/

        #endregion

    }
}