using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
    [Serializable]
    public class ParametroConsultarEscolarDTO
    {
        private int? _codigoAssistido;

        public int? CodigoAssistido
        {
            get { return _codigoAssistido; }
            set { _codigoAssistido = value; }
        }

        private string _nomeInstituicao;

        public string NomeInstituicao
        {
            get { return _nomeInstituicao; }
            set { _nomeInstituicao = value; }
        }

    }
}