using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    [Serializable]
    public class Assistido : Pessoa
    {
        private int? _codigoAssistido;
        private int? _pessoa_CodigoPessoa;
        private int? _contato_CodigoContato;
        private int? _escolar_CodigoEscolar;
        private string _certidaoNascimento;
        private string _nomePai;
        private string _nomeMae;
        private string _cpfPai;
        private string _cpfMae;
        private string _rgPai;
        private string _rgMae;
        private string _enderecoFamilia;
        private string _telefoneFamilia;
        private Decimal? _peso;
        private Decimal? _altura;
        private string _cor;
        private string _historicoVida;
        private string _vivo;
        private string _telefoneMae;
        private int? _qtdIrmaos;
        private string _responsavelLegal;
        private string _cpfResponsavel;
        private string _telefoneResponsavel;
        private string _logradouroResponsavel;
        private string _numeroResponsavel;
        private string _cepResponsavel;



        public int? CodigoAssistido
        {
            get { return _codigoAssistido; }
            set { _codigoAssistido = value; }
        }

        public int? Pessoa_CodigoPessoa
        {
            get { return _pessoa_CodigoPessoa; }
            set { _pessoa_CodigoPessoa = value; }
        }

        public int? Contato_CodigoContato
        {
            get { return _contato_CodigoContato; }
            set { _contato_CodigoContato = value; }
        }

        public int? Escolar_CodigoEscolar
        {
            get { return _escolar_CodigoEscolar; }
            set { _escolar_CodigoEscolar = value; }
        }

        public string CertidaoNascimento
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

        public string CPFPai
        {
            get { return _cpfPai; }
            set { _cpfPai = value; }
        }

        public string CPFMae
        {
            get { return _cpfMae; }
            set { _cpfMae = value; }
        }

        public string RGPai
        {
            get { return _rgPai; }
            set { _rgPai = value; }
        }

        public string RGMae
        {
            get { return _rgMae; }
            set { _rgMae = value; }
        }

        public string EnderecoFamilia
        {
            get { return _enderecoFamilia; }
            set { _enderecoFamilia = value; }
        }

        public string TelefoneFamilia
        {
            get { return _telefoneFamilia; }
            set { _telefoneFamilia = value; }
        }

        public Decimal? Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public Decimal? Altura
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

        public string TelefoneMae
        {
            get { return _telefoneMae; }
            set { _telefoneMae = value; }
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

        public string CPFResponsavel
        {
            get { return _cpfResponsavel; }
            set { _cpfResponsavel = value; }
        }

        public string TelefoneResponsavel
        {
            get { return _telefoneResponsavel; }
            set { _telefoneResponsavel = value; }
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

        public string CEPResponsavel
        {
            get { return _cepResponsavel; }
            set { _cepResponsavel = value; }
        }
    }
}