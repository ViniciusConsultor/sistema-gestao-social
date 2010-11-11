using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SGS.Entidades
{
    [Serializable]
    public class Alimento
    {
        private int? _codigoAlimento;
        private string _nomeAlimento;
        
        public int? CodigoAlimento
        {
            get { return _codigoAlimento; }
            set { _codigoAlimento = value; }
        }

        public string NomeAlimento
        {
            get { return _nomeAlimento; }
            set { _nomeAlimento = value; }
        }

    }
}