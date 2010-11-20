using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    [Serializable]
    public class Procedimentos
    {
        private int? _codigoProcedimento;
        private int? _codigoAssistido;
        private string _tipoProcedimento;
        private string _descrição;
        private string _statusProcedimento;
        private string _pessoaAtendente;
        private DateTime? _dataMarcada;
        private string _laudoAtendente;


        public int? CodigoProcedimento
        {
            get { return _codigoProcedimento; }
            set { _codigoProcedimento = value; }
        }

        public int? CodigoAssistido
        {
            get { return _codigoAssistido; }
            set { _codigoAssistido = value; }
        }

        public string TipoProcedimento
        {
            get { return _tipoProcedimento; }
            set { _tipoProcedimento = value; }
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

        public string LaudoAtendente
        {
            get { return _laudoAtendente; }
            set { _laudoAtendente = value; }
        }
    }
}