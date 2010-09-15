using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Escolar
    {
        private int _codInstituicao;
        private int _contato_CodContato;
        private int _assistido_CodAssistido;
        private int _numInscricaoInstituicao;
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


        public int codInstituicao
        {
            get { return _codInstituicao; }
            set { _codInstituicao = value; }
        }

        public int contato_CodContato
        {
            get { return _contato_CodContato; }
            set { _contato_CodContato = value; }
        }

        public int assistido_CodAssistido
        {
            get { return _assistido_CodAssistido; }
            set { _assistido_CodAssistido = value; }
        }

        public string instituicao
        {
            get { return _instituicao; }
            set { _instituicao = value; }
        }

        public int? numInscricaoInstituicao
        {
            get { return _numInscricaoInstituicao; }
            set { _numInscricaoInstituicao = value; }
        }

        public float mediaEscola
        {
            get { return _mediaEscola; }
            set { _mediaEscola = value; }
        }

        public string grauEscolaridade
        {
            get { return _grauEscolaridade; }
            set { _grauEscolaridade = value; }
        }

        public string serieCursada
        {
            get { return _serieCursada; }
            set { _serieCursada = value; }
        }

        public DateTime? dataMatricula
        {
            get { return _dataMatricula; }
            set { _dataMatricula = value; }
        }

        public DateTime? dataSaida
        {
            get { return _dataSaida; }
            set { _dataSaida = value; }
        }

        public string statusMatricula
        {
            get { return _statusMatricula; }
            set { _statusMatricula = value; }
        }

        public string formatoAnoLetivo
        {
            get { return _formatoAnoLetivo; }
            set { _formatoAnoLetivo = value; }
        }

        public string materia
        {
            get { return _materia; }
            set { _materia = value; }
        }

        public string professor
        {
            get { return _professor; }
            set { _professor = value; }
        }

        public float nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public string statusMateria
        {
            get { return _statusMateria; }
            set { _statusMateria = value; }
        }

        public string parteAnoLetivo
        {
            get { return _parteAnoLetivo; }
            set { _parteAnoLetivo = value; }
        }
    }
}