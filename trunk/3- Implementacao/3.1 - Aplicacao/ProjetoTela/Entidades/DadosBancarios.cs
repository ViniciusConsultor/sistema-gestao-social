using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class DadosBancarios
    {
        private int _codigoDadosBancarios;
        private string _agencia;
        private string _contaBancaria;
        private string _banco;


        public int codigoDadosBancarios
        {
            get { return _codigoDadosBancarios; }
            set { _codigoDadosBancarios = value; }
        }

        public string agencia
        {
            get { return _agencia; }
            set { _agencia = value; }
        }

        public string contaBancaria
        {
            get { return _contaBancaria; }
            set { _contaBancaria = value; }
        }

        public string banco
        {
            get { return _banco; }
            set { _banco = value; }
        }
    }
}