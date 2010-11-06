using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{

    [Serializable]
    public class ConsultarEscolarDTO
    {


        #region Propriedades

        private ParametroConsultarEscolarDTO _parametroConsultarEscolarDTO;

        public ParametroConsultarEscolarDTO ParametroConsultarEscolarDTO
        {
            set { _parametroConsultarEscolarDTO = value; }
            get { return _parametroConsultarEscolarDTO; }
        }
        
        private List<GradeConsultarEscolarDTO> _gradeConsultarEscolarDTOLista;

        public List<GradeConsultarEscolarDTO> gradeConsultarEscolarDTOLista
        {
            set { _gradeConsultarEscolarDTOLista = value; }
            get { return _gradeConsultarEscolarDTOLista; }
        }


        private List<Assistido> _assistidoLista;

        public List<Assistido> AssistidoLista
        {
            set { _assistidoLista = value; }
            get { return _assistidoLista; }
        }

        #endregion

    }
}