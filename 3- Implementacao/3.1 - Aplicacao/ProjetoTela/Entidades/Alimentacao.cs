using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Alimentacao
    {
        private int _codAlimentacao;
        private string _diaSemana;
        private string _periodo;
        private DateTime _horario;
        private string _alimento;
        private string _porcaoAlimento;


        public int codAlimentacao
        {
            get { return _codAlimentacao; }
            set { _codAlimentacao = value; }
        }

        public string diaSemana
        {
            get { return _diaSemana; }
            set { _diaSemana = value; }
        }

        public string periodo
        {
            get { return _periodo; }
            set { _periodo = value; }
        }

        public DateTime horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

        public string alimento
        {
            get { return _alimento; }
            set { _alimento = value; }
        }

        public string porcaoAlimento
        {
            get { return _porcaoAlimento; }
            set { _porcaoAlimento = value; }
        }
    }
}