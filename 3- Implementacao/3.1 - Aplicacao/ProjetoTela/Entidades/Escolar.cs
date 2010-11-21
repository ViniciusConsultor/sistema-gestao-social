using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    [Serializable]
    public class Escolar
    {

        public Escolar()
        {
            this.Contato = new Contato();
        }

        private int? _codigoEscolar;
        private int? _contato_CodigoContato;
        private int? _assistido_CodigoAssistido;
        private string _numInscricaoInstituicao;
        private string _instituicao;
        private Decimal _mediaEscola;
        private string _grauEscolaridade;
        private string _serieCursada;
        private DateTime? _dataMatricula;
        private DateTime? _dataSaida;
        private string _statusSerie;
        private Contato _contato;


        public int? CodigoEscolar
        {
            get { return _codigoEscolar; }
            set { _codigoEscolar = value; }
        }

        public int? Contato_CodigoContato
        {
            get { return _contato_CodigoContato; }
            set { _contato_CodigoContato = value; }
        }

        public int? Assistido_CodigoAssistido
        {
            get { return _assistido_CodigoAssistido; }
            set { _assistido_CodigoAssistido = value; }
        }

        public string Instituicao
        {
            get { return _instituicao; }
            set { _instituicao = value; }
        }

        public string NumInscricaoInstituicao
        {
            get { return _numInscricaoInstituicao; }
            set { _numInscricaoInstituicao = value; }
        }

        public Decimal MediaEscola
        {
            get { return _mediaEscola; }
            set { _mediaEscola = value; }
        }

        public string GrauEscolaridade
        {
            get { return _grauEscolaridade; }
            set { _grauEscolaridade = value; }
        }

        public string SerieCursada
        {
            get { return _serieCursada; }
            set { _serieCursada = value; }
        }

        public DateTime? DataMatricula
        {
            get { return _dataMatricula; }
            set { _dataMatricula = value; }
        }

        public DateTime? DataSaida
        {
            get { return _dataSaida; }
            set { _dataSaida = value; }
        }

        public string StatusSerie
        {
            get { return _statusSerie; }
            set { _statusSerie = value; }
        }

        public Contato Contato
        {
            get { return _contato; }
            set { _contato = value; }
        }

    }
}