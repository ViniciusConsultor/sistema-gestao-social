using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Escolar
    {
        private int _codigoInstituicao;
        private int _contato_CodigoContato;
        private int _assistido_CodigoAssistido;
        private int? _numInscricaoInstituicao;
        private string _instituicao;
        private float _mediaEscola;
        private string _grauEscolaridade;
        private string _serieCursada;
        private DateTime? _dataMatricula;
        private DateTime? _dataSaida;
        private string _statusMatricula;
        private string _formatoAnoLetivo;
        private string _materia;
        private string _professor;
        private float _nota;
        private string _statusMateria;
        private string _parteAnoLetivo;


        public int CodigoInstituicao
        {
            get { return _codigoInstituicao; }
            set { _codigoInstituicao = value; }
        }

        public int Contato_CodigoContato
        {
            get { return _contato_CodigoContato; }
            set { _contato_CodigoContato = value; }
        }

        public int Assistido_CodigoAssistido
        {
            get { return _assistido_CodigoAssistido; }
            set { _assistido_CodigoAssistido = value; }
        }

        public string Instituicao
        {
            get { return _instituicao; }
            set { _instituicao = value; }
        }

        public int? NumInscricaoInstituicao
        {
            get { return _numInscricaoInstituicao; }
            set { _numInscricaoInstituicao = value; }
        }

        public float MediaEscola
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

        public string StatusMatricula
        {
            get { return _statusMatricula; }
            set { _statusMatricula = value; }
        }

        public string FormatoAnoLetivo
        {
            get { return _formatoAnoLetivo; }
            set { _formatoAnoLetivo = value; }
        }

        public string Materia
        {
            get { return _materia; }
            set { _materia = value; }
        }

        public string Professor
        {
            get { return _professor; }
            set { _professor = value; }
        }

        public float Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public string StatusMateria
        {
            get { return _statusMateria; }
            set { _statusMateria = value; }
        }

        public string ParteAnoLetivo
        {
            get { return _parteAnoLetivo; }
            set { _parteAnoLetivo = value; }
        }
    }
}