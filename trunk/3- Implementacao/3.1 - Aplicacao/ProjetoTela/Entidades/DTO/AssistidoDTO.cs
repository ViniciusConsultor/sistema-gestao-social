using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;


namespace SGS.Entidades.DTO
{

    [Serializable]
    public class AssistidoDTO
    {

        public AssistidoDTO()
        {
            this.Assistido = new Assistido();
            this.CasaLarLista = new List<CasaLar>();
        }
        private Assistido _assistido;

        public Assistido Assistido
        {
            get { return _assistido; }
            set { _assistido = value; }
        }

        private List<CasaLar> _casaLarLista;
        public List<CasaLar> CasaLarLista
        {
            get { return _casaLarLista; }
            set { _casaLarLista = value; }
        }

    }
}