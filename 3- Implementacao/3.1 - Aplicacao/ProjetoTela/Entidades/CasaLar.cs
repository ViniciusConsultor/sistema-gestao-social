using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    [Serializable]
    public class CasaLar
    {
        private int? _codigoCasaLar;
        private int? _contato_CodigoContato;
        private string _nomeCasaLar;
        private string _cnpj;
        private string _alvara;
        private DateTime? _dataFundacao;
        private string _historia;
        private string _gestor;
        private string _statusCasaLar;
        private int? _qtdMaxAssistidos;
        private int? _qtdAssistidos;
        private string _foto;
        private string _emailGestor;
        private string _telefoneGestor;
        private Contato _contato;

       
        public int? CodigoCasaLar
        {
            get { return _codigoCasaLar; }
            set { _codigoCasaLar = value; }
        }

        public int? CodigoContato
        {
            get { return _contato_CodigoContato; }
            set { _contato_CodigoContato = value; }
        }

        public string NomeCasaLar
        {
            get { return _nomeCasaLar; }
            set { _nomeCasaLar = value; }
        }

        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public string Alvara
        {
            get { return _alvara; }
            set { _alvara = value; }
        }

        public DateTime? DataFundacao
        {
            get { return _dataFundacao; }
            set { _dataFundacao = value; }
        }

        public string Historia
        {
            get { return _historia; }
            set { _historia = value; }
        }

        public string Gestor
        {
            get { return _gestor; }
            set { _gestor = value; }
        }

        public string StatusCasaLar
        {
            get { return _statusCasaLar; }
            set { _statusCasaLar = value; }
        }

        public int? QtdMaxAssistidos
        {
            get { return _qtdMaxAssistidos; }
            set { _qtdMaxAssistidos = value; }
        }

        public int? QtdAssistidos
        {
            get { return _qtdAssistidos; }
            set { _qtdAssistidos = value; }
        }

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public string EmailGestor
        {
            get { return _emailGestor; }
            set { _emailGestor = value; }
        }

        public string TelefoneGestor
        {
            get { return _telefoneGestor; }
            set { _telefoneGestor = value; }
        }

        public Contato Contato
        {
            get { return _contato; }
            set { _contato = value; }
        }
    }
}