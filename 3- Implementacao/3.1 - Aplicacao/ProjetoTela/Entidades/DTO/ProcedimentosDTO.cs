using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
        [Serializable]
    public class ProcedimentosDTO
    {

      #region Construtores

        /// <summary>
        /// Construtor com parâmetro
        /// </summary>
        /// <param name="umProcedimentos"></param>
        public ProcedimentosDTO(Procedimentos umProcedimentos)
        {
            this.Procedimentos = umProcedimentos;
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public ProcedimentosDTO()
        {
        }

        #endregion

        #region Propriedades

        Procedimentos _procedimentos;

        /// <summary>
        /// Um objeto Procedimentos
        /// </summary>
        public Procedimentos Procedimentos
        {
            get { return _procedimentos; }
            set { _procedimentos = value; }
        }


        List<Procedimentos> _procedimentosLista;

        /// <summary>
        /// Lista de Procedimentos
        /// </summary>
        public List<Procedimentos> ProcedimentosLista
        {
            get { return _procedimentosLista; }
            set { _procedimentosLista = value; }
        }

        private int? _assistidoValor;
        public int? AssistidoValor
        {
            set { _assistidoValor = value; }
            get { return _assistidoValor; }
        }
            
            
        private string _tipoProcedimentoValor;
        public string TipoProcedimentoValor
        {
            set { _tipoProcedimentoValor = value; }
            get { return _tipoProcedimentoValor; }
        }

        private string _procedimentoValor;
        public string ProcedimentoValor
        {
            set { _procedimentoValor = value; }
            get { return _procedimentoValor; }
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

        private string _pessoaAtendendeValor;
        public string PessoaAtendenteValor
        {
            set { _pessoaAtendendeValor = value; }
            get { return _pessoaAtendendeValor; }
        }

        private DateTime? _dataMarcadaValor;
        public DateTime? DataMarcadaValor
        {
            set { _dataMarcadaValor = value; }
            get { return _dataMarcadaValor; }
        }

        private DateTime? _dataRealizadaValor;
        public DateTime? DataRealizadaValor
        {
            set { _dataRealizadaValor = value; }
            get { return _dataRealizadaValor; }
        }


        private string _laudoAtendenteValor;
        public string LaudoAtendenteValor
        {
            set { _laudoAtendenteValor = value; }
            get { return _laudoAtendenteValor; }
        }

        
        List<ProcedimentosAssistidoDTO> _procedimentosAssistidoDTOLista;

        /// <summary>
        /// Lista de Orcamento
        /// </summary>
        public List<ProcedimentosAssistidoDTO> ProcedimentosAssistidoDTOLista
        {
            get { return _procedimentosAssistidoDTOLista; }
            set { _procedimentosAssistidoDTOLista = value; }
        }


        #endregion
    }
}