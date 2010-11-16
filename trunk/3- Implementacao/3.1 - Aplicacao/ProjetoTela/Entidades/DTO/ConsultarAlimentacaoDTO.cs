using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
    [Serializable]
    public class ConsultarAlimentacaoDTO
    {

        public ConsultarAlimentacaoDTO()
        {
            this.DiaSemanaDTOLista = new List<DiaSemanaDTO>();
        }

        private List<DiaSemanaDTO> _diaSemanaDTOLista;
        public List<DiaSemanaDTO> DiaSemanaDTOLista
        {
            get { return _diaSemanaDTOLista; }
            set { _diaSemanaDTOLista = value; }
        }

        public string _diaSemanaValor;
        public string DiaSemanaValor
        {
            get { return _diaSemanaValor; }
            set { _diaSemanaValor = value; }
        }

        [Serializable]
        public class DiaSemanaDTO
        {

            public DiaSemanaDTO()
            {
                this.PeriodoDTOLista = new List<PeriodoDTO>();
            }
            
            private string _diaSemana;
            public string DiaSemana
            {
                get { return _diaSemana; }
                set { _diaSemana = value; }
            }

            private List<PeriodoDTO> _periodoDTOLista;
            public List<PeriodoDTO> PeriodoDTOLista
            {
                get { return _periodoDTOLista; }
                set { _periodoDTOLista = value; }
            }
        }

        [Serializable]
        public class PeriodoDTO
        {
            private string _nomePeriodo;
            public string NomePeriodo
            {
                get { return _nomePeriodo; }
                set { _nomePeriodo = value; }
            }

            private string _horario;
            public string Horario
            {
                get { return _horario; }
                set { _horario = value; }
            }

            private string _alimentos;
            public string Alimentos
            {
                get { return _alimentos; }
                set { _alimentos = value; }
            }

            private string _diretiva;
            public string Diretiva
            {
                get { return _diretiva; }
                set { _diretiva = value; }
            }
        }
    }
}