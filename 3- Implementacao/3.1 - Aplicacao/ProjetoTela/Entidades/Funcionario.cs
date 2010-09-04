using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Funcionario
    {

        private int _codFuncionario;
        private string _cargo;
        private float _salario;
        private DateTime _dataContratacao;
        private int _numCtps;
        private int _pis;
        private int _grauEscolaridade;
        private string _cursoFormacao;
        private string _estadoCivil;
        private int _certidaoNascimento;
        private int _certidaoCasamento;
        private int _qtdFilhos;
        private int _certificadoReservista;
        

        public int codFuncionario
        {
            get { return _codFuncionario; }
            set { _codFuncionario = value; }
        }

        public string cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public float salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        public DateTime dataContratacao
        {
            get { return _dataContratacao; }
            set { _dataContratacao = value; }
        }

        public int numCtps
        {
            get { return _numCtps; }
            set { _numCtps = value; }
        }

        public int pis
        {
            get { return _pis; }
            set { _pis = value; }
        }

        public int grauEscolaridade
        {
            get { return _grauEscolaridade; }
            set { _grauEscolaridade = value; }
        }

        public string cursoFormacao
        {
            get { return _cursoFormacao; }
            set { _cursoFormacao = value; }
        }

        public string estadoCivil
        {
            get { return _estadoCivil; }
            set { _estadoCivil = value; }
        }

        public int certidaoNascimento
        {
            get { return _certidaoNascimento; }
            set { _certidaoNascimento = value; }
        }

        public int certidaoCasamento
        {
            get { return _certidaoCasamento; }
            set { _certidaoCasamento = value; }
        }

        public int qtdFilhos
        {
            get { return _qtdFilhos; }
            set { _qtdFilhos = value; }
        }

        public int certificadoReservista
        {
            get { return _certificadoReservista; }
            set { _certificadoReservista = value; }
        }
        
    }

}