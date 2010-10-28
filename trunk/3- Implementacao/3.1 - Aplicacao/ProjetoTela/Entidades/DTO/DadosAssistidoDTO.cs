using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
    /// <summary>
    /// Este DTO contém todos os dados do componente PessoaAssistido.ascx
    /// </summary
    public class DadosAssistidoDTO
    {
        
        #region Atributos Dados Pessoais
       
        private DateTime _dataEntrada;
        private DateTime _dataSaida;
        private string _estadoSaude;
        private float _peso;
        private string _cor;
        private string _dormitorio;
        private string _tamanhoCamisa;
        private string _tamanhoCalca;
        private string _tamanhoCalcado;
        private bool _deficiente;
        private string _hobby;
        private string _historicoVida;

#endregion

        #region Atributos Dados Familia

        private string _pai;
        private string _mae;
        private bool _paiVivo;
        private bool _maeViva;
        private string _cpfPai;
        private string _cpfMae;
        private string _rgPai;
        private string _rgMae;
        private string _telPai;
        private string _telMae;
        private int _qtdIrmaos;

        #endregion 

        #region Atributos Dados responsável

        private string _responsavel;
        private string _telResponsavel;
        private string _cpfResponsavel;
        private string _emailResponsavel;
        private string _cepResponsavel;
        private string _logradouroResponsavel;
        private string _numeroResponsavel;
        private string _bairroResponsavel;
        private string _cidadeResponsavel;
        private string _estadoResponsavel;
        private string _paisResponsavel;

        #endregion  


        #region Propriedade Dados Pessoais

        public DateTime DataEntrada
        {
            get { return _dataEntrada; }
            set { _dataEntrada = value;  }
        }

        public DateTime DataSaida
        {
            get { return _dataSaida; }
            set { _dataSaida = value;  }
        }

        public string EstadoSaude
        {
            set { _estadoSaude = value; }
            get { return _estadoSaude; }
        }

        public float Peso
        {
            set { _peso = value; }
            get { return _peso; }
        }

        public string Cor
        {
            set { _cor = value; }
            get { return _cor; }
        }

        public string Dormitorio
        {
            set { _dormitorio = value; }
            get { return _dormitorio; }
        }

        public string TamanhoCamisa
        {
            set { _tamanhoCamisa = value; }
            get { return _tamanhoCamisa; }
        }

        public string TamanhoCalca
        {
            set { _tamanhoCalca = value; }
            get { return _tamanhoCalca; }
        }

        public string TamanhoCalcado
        {
            set { _tamanhoCalcado = value; }
            get { return _tamanhoCalcado; }
        }

        public bool Deficiente
        {
            set { _deficiente = value; }
            get { return _deficiente; }
        }


        public string Hobby
        {
            set { _hobby = value; }
            get { return _hobby; }
        }

        public string HistoricoVida
        {
            set { _historicoVida = value; }
            get { return _historicoVida; }
        }

#endregion

        #region Propriedades Dados Familia

        public string Pai
        {
            set { _pai = value; }
            get { return _pai; }
        }

        public string Mae
        {
            set { _mae = value; }
            get { return _mae; }
        }

        public bool PaiVivo
        {
            set { _paiVivo = value; }
            get { return _paiVivo; }
        }

        public bool MaeViva
        {
            set { _maeViva = value; }
            get { return _maeViva; }
        }

        public string CpfPai
        {
            set { _cpfPai = value; }
            get { return _cpfPai; }
        }

        public string CpfMae
        {
            set { _cpfMae = value; }
            get { return _cpfMae; }
        }

        public string RgPai
        {
            set { _rgPai = value; }
            get { return _rgPai; }
        }

        public string RgMae
        {
            set { _rgMae = value; }
            get { return _rgMae; }
        }

        public string TelPai
        {
            set { _telPai = value; }
            get { return _telPai; }
        }

        public string TelMae
        {
            set { _telMae = value; }
            get { return _telMae; }
        }

        public int QtdIrmaos
        {
            set { _qtdIrmaos = value; }
            get { return _qtdIrmaos; }
        }
        

        #endregion

        #region Propriedade Dados Responsável

        public string Responsavel
        {
            set { _responsavel = value; }
            get { return _responsavel; }
        }

        public string TelResponsavel
        {
            set { _telResponsavel = value; }
            get { return _telResponsavel; }
        }

        public string CpfResponsavel
        {
            set { _cpfResponsavel = value; }
            get { return _cpfResponsavel; }
        }

        public string EmailResponsavel
        {
            set { _emailResponsavel = value; }
            get { return _emailResponsavel; }
        }

        public string CepResponsavel
        {
            set { _cepResponsavel = value; }
            get { return _cepResponsavel; }
        }

        public string LogradouroResponsavel
        {
            set { _logradouroResponsavel = value; }
            get { return _logradouroResponsavel; }
        }

        public string NnumeroResponsavel
        {
            set { _numeroResponsavel = value; }
            get { return _numeroResponsavel; }
        }

        public string BairroResponsavel
        {
            set { _bairroResponsavel = value; }
            get { return _bairroResponsavel; }
        }

        public string CidadeResponsavel
        {
            set { _cidadeResponsavel = value; }
            get { return _cidadeResponsavel; }
        }

        public string EstadoResponsavel
        {
            set { _estadoResponsavel = value; }
            get { return _estadoResponsavel; }
        }

        public string PaisResponsavel
        {
            set { _paisResponsavel = value; }
            get { return _paisResponsavel; }
        }


        #endregion

    }
}