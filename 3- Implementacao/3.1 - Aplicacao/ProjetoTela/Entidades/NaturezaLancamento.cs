using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Componentes;

namespace SGS.Entidades
{
    [Serializable]
    public class NaturezaLancamento
    {
        private int? _codigoNatureza;
        private String _nomeNatureza;



        public int? CodigoNatureza
        {
            set { _codigoNatureza = value; }
            get { return _codigoNatureza; }

        }

        public String NomeNatureza
        {
            set { _nomeNatureza = value; }
            get { return _nomeNatureza; }
        }
    }
}