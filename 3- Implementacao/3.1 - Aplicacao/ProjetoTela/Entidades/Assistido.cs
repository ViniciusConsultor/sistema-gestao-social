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
        private string _statusAssistido;
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
        private Contato _contatoResponsavel;


        public string StatusAssistido
        {
            get { return _statusAssistido; }
            set { _statusAssistido = value; }
        }

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

        public string Pai
        {
            get { return _nomePai; }
            set { _nomePai = value; }
        }

        public string Mae
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

        private string _telefonePai;
        public string TelefonePai
        {
            get { return _telefonePai; }
            set { _telefonePai = value; }
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

        private string _dataEntrada;
        public String DataEntrada
        {
            get { return _dataEntrada; }
            set { _dataEntrada = value; }
        }

        private string _dataSaida;
        public String DataSaida
        {
            get { return _dataSaida; }
            set { _dataSaida = value; }
        }

        private string _estadoSaude;
        public String EstadoSaude
        {
            get { return _estadoSaude; }
            set { _estadoSaude = value; }
        }

        private string _dormitorio;
        public String Dormitorio
        {
            get { return _dormitorio; }
            set { _dormitorio = value; }
        }

        private string _tamanhoCamisa;
        public String TamanhoCamisa
        {
            get { return _tamanhoCamisa; }
            set { _tamanhoCamisa = value; }
        }

        private string _tamanhoCalca;
        public String TamanhoCalca
        {
            get { return _tamanhoCalca; }
            set { _tamanhoCalca = value; }
        }

        private string _tamanhoCalcado;
        public String TamanhoCalcado
        {
            get { return _tamanhoCalcado; }
            set { _tamanhoCalcado = value; }
        }

        private string _deficiente;
        public String Deficiente
        {
            get { return _deficiente; }
            set { _deficiente = value; }
        }

        private string _hobby;
        public String Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }

        private string _paiVivo;
        public String PaiVivo
        {
            get { return _paiVivo; }
            set { _paiVivo = value; }
        }

        private string _maeViva;
        public String MaeViva
        {
            get { return _maeViva; }
            set { _maeViva = value; }
        }

        public Contato ContatoResponsavel
        {
            set { _contatoResponsavel = value; }
            get { return _contatoResponsavel;  }
        }

    }
}