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
    }
}