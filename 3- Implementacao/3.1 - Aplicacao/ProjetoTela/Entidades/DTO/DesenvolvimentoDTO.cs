using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
    [Serializable]
    public class DesenvolvimentoDTO
    {
             #region Construtores

        /// <summary>
        /// Construtor com parâmetro
        /// </summary>
        /// <param name="umDesenvolvimento"></param>
        public DesenvolvimentoDTO(Desenvolvimento umDesenvolvimento)
        {
            this.Desenvolvimento = umDesenvolvimento;
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public DesenvolvimentoDTO()
        {
        }

        #endregion

        #region Propriedades

        Desenvolvimento _desenvolvimento;

        /// <summary>
        /// Um objeto Desenvolvimento
        /// </summary>
        public Desenvolvimento Desenvolvimento
        {
            get { return _desenvolvimento; }
            set { _desenvolvimento = value; }
        }


        List<Desenvolvimento> _desenvolvimentoLista;

        /// <summary>
        /// Lista de Desenvolvimento
        /// </summary>
        public List<Desenvolvimento> DesenvolvimentoLista
        {
            get { return _desenvolvimentoLista; }
            set { _desenvolvimentoLista = value; }
        }

        private int? _assistidoValor;
        public int? AssistidoValor
        {
            set { _assistidoValor = value; }
            get { return _assistidoValor; }
        }
            
            
        private string _tipoAtividadeValor;
        public string TipoAtividadeValor
        {
            set { _tipoAtividadeValor = value; }
            get { return _tipoAtividadeValor; }
        }

        private string _atividadeValor;
        public string AtividadeValor
        {
            set { _atividadeValor = value; }
            get { return _atividadeValor; }
        }

        private string _descricaoValor;
        public string DescricaoValor
        {
            set { _descricaoValor = value; }
            get { return _descricaoValor; }
        }

        private string _statusValor;
        public string StatusValor
        {
            set { _statusValor = value; }
            get { return _statusValor; }
        }

        private string _valorAtividadeValor;
        public string ValorAtividadeValor
        {
            set { _valorAtividadeValor = value; }
            get { return _valorAtividadeValor; }
        }

        private DateTime? _dataInicioValor;
        public DateTime? DataInicioValor
        {
            set { _dataInicioValor = value; }
            get { return _dataInicioValor; }
        }

        private DateTime? _dataFimValor;
        public DateTime? DataFimValor
        {
            set { _dataFimValor = value; }
            get { return _dataFimValor; }
        }


        private string _cargaHorariaValor;
        public string CargaHorariaValor
        {
            set { _cargaHorariaValor = value; }
            get { return _cargaHorariaValor; }
        }

        
        List<DesenvolvimentoAssistidoDTO> _desenvolvimentoAssistidoDTOLista;

        /// <summary>
        /// Lista de Desenvolvimento
        /// </summary>
        public List<DesenvolvimentoAssistidoDTO> DesenvolvimentoAssistidoDTOLista
        {
            get { return _desenvolvimentoAssistidoDTOLista; }
            set { _desenvolvimentoAssistidoDTOLista = value; }
        }


        #endregion
    }
}