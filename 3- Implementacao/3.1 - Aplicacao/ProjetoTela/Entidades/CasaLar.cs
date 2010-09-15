using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class CasaLar
    {
        private int _codCasaLar;
        private int _contato_CodContato;
        private string _nomeCasaLar;
        private int? _cnpj;
        private string _alvara;
        private DateTime? _dataFundacao;
        private string _historia;
        private string _gestor;
        private string _statusCasaLar;
        private int? _qtdMaxAssistidos;
        private int? _qtdAssistidos;
        private string _foto;
        private string _emailGestor;
        private int? _telefoneGestor;


        public int codCasaLar
        {
            get { return _codCasaLar; }
            set { _codCasaLar = value; }
        }

        public int contato_CodContato
        {
            get { return _contato_CodContato; }
            set { _contato_CodContato = value; }
        }

        public string nomeCasaLar
        {
            get { return _nomeCasaLar; }
            set { _nomeCasaLar = value; }
        }

        public int? cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public string alvara
        {
            get { return _alvara; }
            set { _alvara = value; }
        }

        public DateTime? dataFundacao
        {
            get { return _dataFundacao; }
            set { _dataFundacao = value; }
        }

        public string historia
        {
            get { return _historia; }
            set { _historia = value; }
        }

        public string gestor
        {
            get { return _gestor; }
            set { _gestor = value; }
        }

        public string statusCasaLar
        {
            get { return _statusCasaLar; }
            set { _statusCasaLar = value; }
        }

        public int? qtdMaxAssistidos
        {
            get { return _qtdMaxAssistidos; }
            set { _qtdMaxAssistidos = value; }
        }

        public int? qtdAssistidos
        {
            get { return _qtdAssistidos; }
            set { _qtdAssistidos = value; }
        }

        public string foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public string emailGestor
        {
            get { return _emailGestor; }
            set { _emailGestor = value; }
        }

        public int? telefoneGestor
        {
            get { return _telefoneGestor; }
            set { _telefoneGestor = value; }
        }
    }
}