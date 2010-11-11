using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class ProcedimentosAssistido
    {

        private string _nomeAssistido;

        public string NomeAssistido
        {
            set { _nomeAssistido = value; }
            get { return _nomeAssistido; }
        
        }
    }
}