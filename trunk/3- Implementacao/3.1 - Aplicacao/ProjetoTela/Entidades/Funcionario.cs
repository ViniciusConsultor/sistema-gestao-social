using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Funcionario
    {

        private int _codigoFuncionario;
        private int _pessoa_CodigoPessoa;
        private string _cargo;
        private float _salario;
        private DateTime? _dataContratacao;
        private string _numCtps;
        private string _pis;
        private string _grauEscolaridade;
        private string _cursoFormacao;
        private string _estadoCivil;
        private string _certidaoNascimento;
        private string _certidaoCasamento;
        private string _qtdFilhos;
        private string _certificadoReservista;
        

        public int CodigoFuncionario
        {
            get { return _codigoFuncionario; }
            set { _codigoFuncionario = value; }
        }

        public int Pessoa_CodigoPessoa
        {
            get { return _pessoa_CodigoPessoa; }
            set { _pessoa_CodigoPessoa = value; }
        }

        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public float Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        public DateTime? DataContratacao
        {
            get { return _dataContratacao; }
            set { _dataContratacao = value; }
        }

        public string NumCTPS
        {
            get { return _numCtps; }
            set { _numCtps = value; }
        }

        public string PIS
        {
            get { return _pis; }
            set { _pis = value; }
        }

        public string GrauEscolaridade
        {
            get { return _grauEscolaridade; }
            set { _grauEscolaridade = value; }
        }

        public string CursoFormacao
        {
            get { return _cursoFormacao; }
            set { _cursoFormacao = value; }
        }

        public string EstadoCivil
        {
            get { return _estadoCivil; }
            set { _estadoCivil = value; }
        }

        public string CertidaoNascimento
        {
            get { return _certidaoNascimento; }
            set { _certidaoNascimento = value; }
        }

        public string CertidaoCasamento
        {
            get { return _certidaoCasamento; }
            set { _certidaoCasamento = value; }
        }

        public string QtdFilhos
        {
            get { return _qtdFilhos; }
            set { _qtdFilhos = value; }
        }

        public string CertificadoReservista
        {
            get { return _certificadoReservista; }
            set { _certificadoReservista = value; }
        }
        
    }

}