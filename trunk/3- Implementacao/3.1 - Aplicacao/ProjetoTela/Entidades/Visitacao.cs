using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Visitacao
    {
        private int _codigoVisitacao;
        private int _assistido_CodigoAssistido;
        private string _pessoaVisitante;
        private string _assistidoVisitado;
        private DateTime? _dataVisita;
        private DateTime? _horaInicioVisita;
        private DateTime? _horaFimVisita;
        private string _motivoVisita;
        private string _feedBackVisita;
        private string _statusVisita;


        public int CodigoVisitacao
        {
            get { return _codigoVisitacao; }
            set { _codigoVisitacao = value; }
        }

        public int Assistido_CodigoAssistido
        {
            get { return _assistido_CodigoAssistido; }
            set { _assistido_CodigoAssistido = value; }
        }

        public string PessoaVisitante
        {
            get { return _pessoaVisitante; }
            set { _pessoaVisitante = value; }
        }

        public string AssistidoVisitado
        {
            get { return _assistidoVisitado; }
            set { _assistidoVisitado = value; }
        }

        public DateTime? DataVisita
        {
            get { return _dataVisita; }
            set { _dataVisita = value; }
        }

        public DateTime? HoraInicioVisita
        {
            get { return _horaInicioVisita; }
            set { _horaInicioVisita = value; }
        }

        public DateTime? HoraFimVisita
        {
            get { return _horaFimVisita; }
            set { _horaFimVisita = value; }
        }

        public string MotivoVisita
        {
            get { return _motivoVisita; }
            set { _motivoVisita = value; }
        }

        public string FeedBackVisita
        {
            get { return _feedBackVisita; }
            set { _feedBackVisita = value; }
        }

        public string StatusVisita
        {
            get { return _statusVisita; }
            set { _statusVisita = value; }
        }

    }
}