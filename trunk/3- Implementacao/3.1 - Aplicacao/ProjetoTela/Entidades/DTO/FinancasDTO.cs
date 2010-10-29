using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{

    [Serializable]
    public class FinancasDTO
    {

        #region Construtores

        /// <summary>
        /// Construtor com parâmetro
        /// </summary>
        /// <param name="umFinancas"></param>
        public FinancasDTO(Financas umFinancas)
        {
            this.Financas = umFinancas;
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public FinancasDTO()
        {
        }

        #endregion

        #region Propriedades

        Financas _financas;

        /// <summary>
        /// Um objeto Financas
        /// </summary>
        public Financas Financas
        {
            get { return _financas; }
            set { _financas = value; }
        }


        List<Financas> _financasLista;

        /// <summary>
        /// Lista de Financas
        /// </summary>
        public List<Financas> FinancasLista
        {
            get { return _financasLista; }
            set { _financasLista = value; }
        }

        private string _tipoLancamentoValor;
        public string TipoLancamentoValor
        {
            set { _tipoLancamentoValor = value; }
            get { return _tipoLancamentoValor; }
        }

        private DateTime? _dataLancamentoValor;
        public DateTime? DataLancamentoValor
        {
            set { _dataLancamentoValor = value; }
            get { return _dataLancamentoValor; }
        }

        private string _descricaoValor;
        public string DescricaoValor
        {
            set { _descricaoValor = value; }
            get { return _descricaoValor; }
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


        private List<NaturezaLancamento> _naturezaLancamentoLista;

        /// <summary>
        /// Lista de NaturezaLancamento
        /// </summary>
        public List<NaturezaLancamento> NaturezaLancamentoLista
        {
            get { return _naturezaLancamentoLista; }
            set { _naturezaLancamentoLista = value; }
        }

        private string _naturezaFinancaValor;
        public string NaturezaFinancaValor
        {
            set { _naturezaFinancaValor = value; }
            get { return _naturezaFinancaValor; }
        }




        CasaLar _casaLar;

        /// <summary>
        /// Um objeto CasaLar
        /// </summary>
        public CasaLar CasaLar
        {
            get { return _casaLar; }
            set { _casaLar = value; }
        }


        private List<CasaLar> _casaLarLista;

        /// <summary>
        /// Lista de CasaLar
        /// </summary>
        public List<CasaLar> CasaLarLista
        {
            get { return _casaLarLista; }
            set { _casaLarLista = value; }
        }

        private string _codigoCasaLarValor;
        public string CodigoCasaLarValor
        {
            set { _codigoCasaLarValor = value; }
            get { return _codigoCasaLarValor; }
        }

        #endregion
        
    }
}