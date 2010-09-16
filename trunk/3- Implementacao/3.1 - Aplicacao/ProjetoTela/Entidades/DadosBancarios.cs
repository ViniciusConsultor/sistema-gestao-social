using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class DadosBancarios
    {
        private int _codigoDadosBancarios;
        private int _patrocinador_CodigoPatrocinador;
        private int _voluntario_CodigoVoluntario;
        private int _funcionario_CodigoFuncionario;
        private string _agencia;
        private string _contaBancaria;
        private string _banco;


        public int CodigoDadosBancarios
        {
            get { return _codigoDadosBancarios; }
            set { _codigoDadosBancarios = value; }
        }

        public int Patrocinador_CodigoPatrocinador
        {
            get { return _patrocinador_CodigoPatrocinador; }
            set { _patrocinador_CodigoPatrocinador = value; }
        }

        public int Voluntario_CodigoVoluntario
        {
            get { return _voluntario_CodigoVoluntario; }
            set { _voluntario_CodigoVoluntario = value; }
        }

        public int Funcionario_CodigoFuncionario
        {
            get { return _funcionario_CodigoFuncionario; }
            set { _funcionario_CodigoFuncionario = value; }
        }

        public string Agencia
        {
            get { return _agencia; }
            set { _agencia = value; }
        }

        public string ContaBancaria
        {
            get { return _contaBancaria; }
            set { _contaBancaria = value; }
        }

        public string Banco
        {
            get { return _banco; }
            set { _banco = value; }
        }
    }
}