using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;

namespace SGS.Entidades.DTO
{
    public class ConsultarAssistidoDTO
    {

        private List<Assistido> _assistidoLista;
        public List<Assistido> AssistidoLista
        {
            get { return _assistidoLista; }
            set { _assistidoLista = value;  }
        }

    }
}