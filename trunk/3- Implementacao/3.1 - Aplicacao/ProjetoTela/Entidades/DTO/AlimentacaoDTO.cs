using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{

    [Serializable]
    public class AlimentacaoDTO
    {

        #region Construtores

        /// <summary>
        /// Construtor com parâmetro
        /// </summary>
        /// <param name="umFinancas"></param>
        public AlimentacaoDTO(Alimentacao umAlimentacao)
        {
            this.Alimentacao = umAlimentacao;
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public AlimentacaoDTO()
        {
        }

        #endregion

        #region Propriedades

        Alimentacao _alimentacao;

        /// <summary>
        /// Um objeto Alimentacao
        /// </summary>
        public Alimentacao Alimentacao
        {
            get { return _alimentacao; }
            set { _alimentacao = value; }
        }


        List<Alimentacao> _alimentacaoLista;

        /// <summary>
        /// Lista de Alimentacao
        /// </summary>
        public List<Alimentacao> AlimentacaoLista
        {
            get { return _alimentacaoLista; }
            set { _alimentacaoLista = value; }
        }

        #endregion
        
    }
}