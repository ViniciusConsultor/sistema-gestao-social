using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
    [Serializable]
    public class AssistidoRelatorioDTO
    {
        public AssistidoRelatorioDTO()
        {
            this.ConsultarAssistidoDTO = new ConsultarAssistidoDTO();
        }
        private ConsultarAssistidoDTO _consultarAssistidoDTO;
        public ConsultarAssistidoDTO ConsultarAssistidoDTO
        {
            get { return _consultarAssistidoDTO; }
            set { _consultarAssistidoDTO = value; }
        }

        private List<Assistido> _assistidoLista;
        public List<Assistido> AssistidoLista
        {
            get { return _assistidoLista; }
            set { _assistidoLista = value; }

        }

    }
}