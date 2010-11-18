using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
    public class AssistidoRelatorioDTO
    {

        private List<Assistido> _assistidoLista;
        public List<Assistido> AssistidoLista
        {
            get { return _assistidoLista; }
            set { _assistidoLista = value; }

        }

    }
}