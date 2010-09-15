using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Desenvolvimento
    {
        private int _codDesenvolvimento;
        private int _assistido_CodAssistido;
        private string _atividade;
        private string _tipoAtividade;
        private string _descricaoAtividade;
        private float _valor;
        private DateTime? _dataInicio;
        private DateTime? _dataFim;
        private int? _cargaHoraria;
        private string _statusAtividade;


        public int codDesenvolvimento
        {
            get { return _codDesenvolvimento; }
            set { _codDesenvolvimento = value; }
        }

        public int assistido_CodAssistido
        {
            get { return _assistido_CodAssistido; }
            set { _assistido_CodAssistido = value; }
        }

        public string atividade
        {
            get { return _atividade; }
            set { _atividade = value; }
        }

        public string tipoAtividade
        {
            get { return _tipoAtividade; }
            set { _tipoAtividade = value; }
        }

        public string descricaoAtividade
        {
            get { return _descricaoAtividade; }
            set { _descricaoAtividade = value; }
        }

        public float valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public DateTime? dataInicio
        {
            get { return _dataInicio; }
            set { _dataInicio = value; }
        }

        public DateTime? dataFim
        {
            get { return _dataFim; }
            set { _dataFim = value; }
        }

        public int? cargaHoraria
        {
            get { return _cargaHoraria; }
            set { _cargaHoraria = value; }
        }

        public string statusAtividade
        {
            get { return _statusAtividade; }
            set { _statusAtividade = value; }
        }


    }
}