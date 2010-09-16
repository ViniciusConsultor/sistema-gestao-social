using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SGS.Entidades
{
    public class Alimentacao
    {
        private int _codigoAlimentacao;
        private int _assistido_CodigoAssistido;
        private string _diaSemana;
        private string _periodo;
        private DateTime? _horario;
        private string _alimento;
        private string _porcaoAlimento;


        public int CodigoAlimentacao
        {
            get { return _codigoAlimentacao; }
            set { _codigoAlimentacao = value; }
        }

        public int Assistido_CodigoAssistido
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

        public string PorcaoAlimento
        {
            get { return _porcaoAlimento; }
            set { _porcaoAlimento = value; }
        }
    }
}