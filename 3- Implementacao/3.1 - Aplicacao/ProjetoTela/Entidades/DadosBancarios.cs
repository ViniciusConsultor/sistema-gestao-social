using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class DadosBancarios
    {
        private int _codigoDadosBancarios;
        private int _patrocinador_CodPatrocinador;
        private int _voluntario_CodVoluntario;
        private int _funcionario_CodFuncionario;
        private string _agencia;
        private string _contaBancaria;
        private string _banco;


        public int codigoDadosBancarios
        {
            get { return _codigoDadosBancarios; }
            set { _codigoDadosBancarios = value; }
        }

        public int patrocinador_CodPatrocinador
        {
            get { return _patrocinador_CodPatrocinador; }
            set { _patrocinador_CodPatrocinador = value; }
        }

        public int voluntario_CodVoluntario
        {
            get { return _voluntario_CodVoluntario; }
            set { _voluntario_CodVoluntario = value; }
        }

        public int funcionario_CodFuncionario
        {
            get { return _funcionario_CodFuncionario; }
            set { _funcionario_CodFuncionario = value; }
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