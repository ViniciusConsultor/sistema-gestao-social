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
        private string _nomeInstituicao;
        private string _grauEscolaridade;
        private string _serieCursada;
        private string _statusSerie;
        private string _nomeAssistido;

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

        public string NomeAssistido
        {
            get { return _nomeAssistido; }
            set { _nomeAssistido = value; }
        }


        public string NomeInstituicao
        {
            get { return _nomeInstituicao; }
            set { _nomeInstituicao = value; }
        }

        public string GrauEscolaridade
        {
            get { return _grauEscolaridade; }
            set { _grauEscolaridade = value; }
        }

        public string SerieCursada    
        {
            get { return _serieCursada; }
            set { _serieCursada = value; }
        }

        public string StatusSerie
        {
            get { return _statusSerie; }
            set { _statusSerie = value; }
        }

    }
}