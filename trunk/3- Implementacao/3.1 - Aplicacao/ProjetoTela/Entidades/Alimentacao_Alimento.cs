using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SGS.Entidades
{
    [Serializable]
    public class AlimentacaoAlimento
    {
        private int? _codigoAlimentacao;
        private int? _codigoAlimento;


        public int? CodigoAlimentacao
        {
            get { return _codigoAlimentacao; }
            set { _codigoAlimentacao = value; }
        }

        public int? CodigoAlimento
        {
            get { return _codigoAlimento; }
            set { _codigoAlimento = value; }
        }

    }
}