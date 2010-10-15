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

        private string _dataLancamentoValor;
        public string DataLancamentoValor
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

        #endregion

    }
}