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
        private string _statusAssistido;
        private string _certidaoNascimento;
        private string _nomePai;
        private string _nomeMae;
        private string _cpfPai;
        private string _cpfMae;
        private string _rgPai;
        private string _rgMae;
        private Decimal? _peso;
        private Decimal? _altura;
        private string _cor;
        private string _historicoVida;
        private string _telefoneMae;
        private string _telefonePai;
        private int? _qtdIrmaos;
        private string _responsavelLegal;
        private string _cpfResponsavel;
        private DateTime? _dataEntrada;
        private DateTime? _dataSaida;
        private string _estadoSaude;
        private string _dormitorio;
        private string _tamanhoCamisa;
        private string _tamanhoCalca;
        private string _tamanhoCalcado;
        private string _deficiente;
        private string _hobby;
        private string _paiVivo;
        private string _maeViva;
        private int? _codigoContatoResponsavel;
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

        public string Etnia
        {
            get { return _cor; }
            set { _cor = value; }
        }

        public string HistoricoVida
        {
            get { return _historicoVida; }
            set { _historicoVida = value; }
        }

        public string TelefoneMae
        {
            get { return _telefoneMae; }
            set { _telefoneMae = value; }
        }


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


        public DateTime? DataEntrada
        {
            get { return _dataEntrada; }
            set { _dataEntrada = value; }
        }


        public DateTime? DataSaida
        {
            get { return _dataSaida; }
            set { _dataSaida = value; }
        }


        public String EstadoSaude
        {
            get { return _estadoSaude; }
            set { _estadoSaude = value; }
        }


        public String Dormitorio
        {
            get { return _dormitorio; }
            set { _dormitorio = value; }
        }


        public String TamanhoCamisa
        {
            get { return _tamanhoCamisa; }
            set { _tamanhoCamisa = value; }
        }


        public String TamanhoCalca
        {
            get { return _tamanhoCalca; }
            set { _tamanhoCalca = value; }
        }


        public String TamanhoCalcado
        {
            get { return _tamanhoCalcado; }
            set { _tamanhoCalcado = value; }
        }


        public String Deficiente
        {
            get { return _deficiente; }
            set { _deficiente = value; }
        }


        public String Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }


        public String PaiVivo
        {
            get { return _paiVivo; }
            set { _paiVivo = value; }
        }


        public String MaeViva
        {
            get { return _maeViva; }
            set { _maeViva = value; }
        }

        public int? CodigoContatoResponsavel
        {
            get { return _codigoContatoResponsavel; }
            set { _codigoContatoResponsavel = value; }
        }

        public Contato ContatoResponsavel
        {
            set { _contatoResponsavel = value; }
            get { return _contatoResponsavel;  }
        }

        /// <summary>
        /// Esta propriedade traduz o True e False para Sim ou Não
        /// </summary>
        public string AssistidoAtivo
        {
            get
            {
                if (base.Ativo.HasValue)
                {
                    if (base.Ativo == true)
                        return "Sim";
                    else
                        return "Não";
                }
                else
                {
                    return "";
                }
            }
        }

    }
}