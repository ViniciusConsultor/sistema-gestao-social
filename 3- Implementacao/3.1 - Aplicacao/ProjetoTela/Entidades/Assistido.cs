using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Assistido
    {
        private int _codAssistido;
        private int _certidaoNascimento;
        private string _nomePai;
        private string _nomeMae;
        private int _cpfPai;
        private int _cpfMae;
        private int _rgPai;
        private int _rgMae;
        private string _enderecoFamilia;
        private int _telFamilia;
        private float _peso;
        private float _altura;
        private string _cor;
        private string _historicoVida;
        private string _vivo;
        private int _telMae;
        private int _qtdIrmaos;
        private string _responsavelLegal;
        private int _cpfResponsavel;
        private int _telResponsavel;
        private string _logradouroResponsavel;
        private int _numeroResponsavel;
        private int _cepResponsavel;



        public int codAssistido
        {
            get { return _codAssistido; }
            set { _codAssistido = value; }
        }

        public int certidaoNascimento
        {
            get { return _certidaoNascimento; }
            set { _certidaoNascimento = value; }
        }

        public string nomePai
        {
            get { return _nomePai; }
            set { _nomePai = value; }
        }

        public string nomeMae
        {
            get { return _nomeMae; }
            set { _nomeMae = value; }
        }

        public int cpfPai
        {
            get { return _cpfPai; }
            set { _cpfPai = value; }
        }

        public int cpfMae
        {
            get { return _cpfMae; }
            set { _cpfMae = value; }
        }

        public int rgPai
        {
            get { return _rgPai; }
            set { _rgPai = value; }
        }

        public int rgmae
        {
            get { return _rgMae; }
            set { _rgMae = value; }
        }

        public string enderecoFamilia
        {
            get { return _enderecoFamilia; }
            set { _enderecoFamilia = value; }
        }

        public int telFamilia
        {
            get { return _telFamilia; }
            set { _telFamilia = value; }
        }

        public float peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public float altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public string cor
        {
            get { return _cor; }
            set { _cor = value; }
        }

        public string historicoVida
        {
            get { return _historicoVida; }
            set { _historicoVida = value; }
        }

        public string vivo
        {
            get { return _vivo; }
            set { _vivo = value; }
        }

        public int telMae
        {
            get { return _telMae; }
            set { _telMae = value; }
        }

        public int qtdIrmaos
        {
            get { return _qtdIrmaos; }
            set { _qtdIrmaos = value; }
        }

        public string responsavelLegal
        {
            get { return _responsavelLegal; }
            set { _responsavelLegal = value; }
        }

        public int cpfResponsavel
        {
            get { return _cpfResponsavel; }
            set { _cpfResponsavel = value; }
        }

        public int telResponsavel
        {
            get { return _telResponsavel; }
            set { _telResponsavel = value; }
        }

        public string logradouroResponsavel
        {
            get { return _logradouroResponsavel; }
            set { _logradouroResponsavel = value; }
        }

        public int numeroResponsavel
        {
            get { return _numeroResponsavel; }
            set { _numeroResponsavel = value; }
        }

        public int cepResponsavel
        {
            get { return _cepResponsavel; }
            set { _cepResponsavel = value; }
        }
    }
}