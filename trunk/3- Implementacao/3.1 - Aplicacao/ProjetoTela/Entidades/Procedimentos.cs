using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Procedimentos
    {
        private int _codProcedimentos;
        private string _tipoProcedimento;
        private string _procedimento;
        private string _descrição;
        private string _statusProcedimento;
        private string _pessoaAtendente;
        private DateTime _dataMarcada;
        private DateTime _dataRealizada;
        private string _laudoAtendente;


        public int codProcedimentos
        {
            get { return _codProcedimentos; }
            set { _codProcedimentos = value; }
        }

        public string tipoProcedimento
        {
            get { return _tipoProcedimento; }
            set { _tipoProcedimento = value; }
        }

        public string procedimento
        {
            get { return _procedimento; }
            set { _procedimento = value; }
        }

        public string descricao
        {
            get { return _descrição; }
            set { _descrição = value; }
        }

        public string statusProcedimento
        {
            get { return _statusProcedimento; }
            set { _statusProcedimento = value; }
        }

        public string pessoaAtendente
        {
            get { return _pessoaAtendente; }
            set { _pessoaAtendente = value; }
        }

        public DateTime dataMarcada
        {
            get { return _dataMarcada; }
            set { _dataMarcada = value; }
        }

        public DateTime dataRealizada
        {
            get { return _dataRealizada; }
            set { _dataRealizada = value; }
        }

        public string laudoAtendente
        {
            get { return _laudoAtendente; }
            set { _laudoAtendente = value; }
        }
    }
}