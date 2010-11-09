using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SGS.Entidades
{
    [Serializable]
    public class Alimentacao
    {
        private int? _codigoAlimentacao;
        private int? _assistido_CodigoAssistido;
        private string _diaSemana;
        private string _periodo;
        private DateTime? _horario;
        private string _alimento;
        private string _diretiva;
        //TODO: depois de criar entidade alimento, criar uma lista de alimento aqui.

        public int? CodigoAlimentacao
        {
            get { return _codigoAlimentacao; }
            set { _codigoAlimentacao = value; }
        }

        public int? Assistido_CodigoAssistido
        {
            get { return _assistido_CodigoAssistido; }
            set { _assistido_CodigoAssistido = value; }
        }

        public string DiaSemana
        {
            get { return _diaSemana; }
            set { _diaSemana = value; }
        }

        public string Periodo
        {
            get { return _periodo; }
            set { _periodo = value; }
        }

        public DateTime? Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

        public string Alimento
        {
            get { return _alimento; }
            set { _alimento = value; }
        }

        public string Diretiva
        {
            get { return _diretiva; }
            set { _diretiva = value; }
        }
    }
}