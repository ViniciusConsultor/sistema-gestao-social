using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Procedimentos
    {
        private int? _codigoProcedimentos;
        private int? _assistido_CodigoAssistido;
        private string _tipoProcedimento;
        private string _procedimento;
        private string _descrição;
        private string _statusProcedimento;
        private string _pessoaAtendente;
        private DateTime? _dataMarcada;
        private DateTime _dataRealizada;
        private string _laudoAtendente;


        public int? CodigoProcedimentos
        {
            get { return _codigoProcedimentos; }
            set { _codigoProcedimentos = value; }
        }

        public int? Assistido_CodigoAssistido
        {
            get { return _assistido_CodigoAssistido; }
            set { _assistido_CodigoAssistido = value; }
        }

        public string TipoProcedimento
        {
            get { return _tipoProcedimento; }
            set { _tipoProcedimento = value; }
        }

        public string Procedimento
        {
            get { return _procedimento; }
            set { _procedimento = value; }
        }

        public string Descricao
        {
            get { return _descrição; }
            set { _descrição = value; }
        }

        public string StatusProcedimento
        {
            get { return _statusProcedimento; }
            set { _statusProcedimento = value; }
        }

        public string PessoaAtendente
        {
            get { return _pessoaAtendente; }
            set { _pessoaAtendente = value; }
        }

        public DateTime? DataMarcada
        {
            get { return _dataMarcada; }
            set { _dataMarcada = value; }
        }

        public DateTime DataRealizada
        {
            get { return _dataRealizada; }
            set { _dataRealizada = value; }
        }

        public string LaudoAtendente
        {
            get { return _laudoAtendente; }
            set { _laudoAtendente = value; }
        }
    }
}