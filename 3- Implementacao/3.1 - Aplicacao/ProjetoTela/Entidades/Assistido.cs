using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Assistido
    {
        private int _codigoAssistido;
        private int _certidaoNascimento;
        private int _pessoa_CodigoPessoa;
        private int _contato_CodigoContato;
        private string _nomePai;
        private string _nomeMae;
        private string _cpfPai;
        private string _cpfMae;
        private string _rgPai;
        private string _rgMae;
        private string _enderecoFamilia;
        private string _telFamilia;
        private float _peso;
        private float _altura;
        private string _cor;
        private string _historicoVida;
        private string _vivo;
        private string _telMae;
        private int? _qtdIrmaos;
        private string _responsavelLegal;
        private string _cpfResponsavel;
        private string _telResponsavel;
        private string _logradouroResponsavel;
        private string _numeroResponsavel;
        private string _cepResponsavel;



        public int CodigoAssistido
        {
            get { return _codigoAssistido; }
            set { _codigoAssistido = value; }
        }

        public int Pessoa_CodigoPessoa
        {
            get { return _pessoa_CodigoPessoa; }
            set { _pessoa_CodigoPessoa = value; }
        }

        public int Contato_CodContato
        {
            get { return _contato_CodigoContato; }
            set { _contato_CodigoContato = value; }
        }

        public int CertidaoNascimento
        {
            get { return _certidaoNascimento; }
            set { _certidaoNascimento = value; }
        }

        public string NomePai
        {
            get { return _nomePai; }
            set { _nomePai = value; }
        }

        public string NomeMae
        {
            get { return _nomeMae; }
            set { _nomeMae = value; }
        }

        public string CpfPai
        {
            get { return _cpfPai; }
            set { _cpfPai = value; }
        }

        public string CpfMae
        {
            get { return _cpfMae; }
            set { _cpfMae = value; }
        }

        public string RgPai
        {
            get { return _rgPai; }
            set { _rgPai = value; }
        }

        public string Rgmae
        {
            get { return _rgMae; }
            set { _rgMae = value; }
        }

        public string EnderecoFamilia
        {
            get { return _enderecoFamilia; }
            set { _enderecoFamilia = value; }
        }

        public string TelFamilia
        {
            get { return _telFamilia; }
            set { _telFamilia = value; }
        }

        public float Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public string Cor
        {
            get { return _cor; }
            set { _cor = value; }
        }

        public string HistoricoVida
        {
            get { return _historicoVida; }
            set { _historicoVida = value; }
        }

        public string Vivo
        {
            get { return _vivo; }
            set { _vivo = value; }
        }

        public string TelMae
        {
            get { return _telMae; }
            set { _telMae = value; }
        }

        public int? QtdIrmaos
        {
            get { return _qtdIrmaos; }
            set { _qtdIrmaos = value; }
        }

        public string ResponsavelLegal
        {
            get { return _responsavelLegal; }
            set { _responsavelLegal = value; }
        }

        public string CpfResponsavel
        {
            get { return _cpfResponsavel; }
            set { _cpfResponsavel = value; }
        }

        public string TelResponsavel
        {
            get { return _telResponsavel; }
            set { _telResponsavel = value; }
        }

        public string LogradouroResponsavel
        {
            get { return _logradouroResponsavel; }
            set { _logradouroResponsavel = value; }
        }

        public string NumeroResponsavel
        {
            get { return _numeroResponsavel; }
            set { _numeroResponsavel = value; }
        }

        public string CepResponsavel
        {
            get { return _cepResponsavel; }
            set { _cepResponsavel = value; }
        }
    }
}