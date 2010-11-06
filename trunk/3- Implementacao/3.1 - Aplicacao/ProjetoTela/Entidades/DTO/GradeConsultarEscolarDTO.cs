using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{

    [Serializable]
    public class GradeConsultarEscolarDTO
    {
        private int? _codigoEscolar;
        private int? _codigoAssistido;
        private int? _nomeInstituicao;
        private int? _grauEscolaridade;
        private int? _serieCursada;

        public int? CodigoEscolar
        {
            get { return _codigoEscolar; }
            set { _codigoEscolar = value; }
        }

        public int? CodigoAssistido
        {
            get { return _codigoAssistido; }
            set { _codigoAssistido = value; }
        }

        public int? NomeInstituicao
        {
            get { return _nomeInstituicao; }
            set { _nomeInstituicao = value; }
        }

        public int? GrauEscolaridade
        {
            get { return _grauEscolaridade; }
            set { _grauEscolaridade = value; }
        }

        public int? SerieCursada
        {
            get { return _serieCursada; }
            set { _serieCursada = value; }
        }

    }
}