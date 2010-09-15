using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Visitacao
    {
        private int _codVisitacao;
        private int _assistido_CodAssistido;
        private string _pessoaVisitante;
        private string _assistidoVisitado;
        private DateTime? _dataVisita;
        private DateTime? _horaInicioVisita;
        private DateTime? _horaFimVisita;
        private string _motivoVisita;
        private string _feedBackVisita;
        private string _statusVisita;


        public int codVisitacao
        {
            get { return _codVisitacao; }
            set { _codVisitacao = value; }
        }

        public int assistido_CodAssistido
        {
            get { return _assistido_CodAssistido; }
            set { _assistido_CodAssistido = value; }
        }

        public string pessoaVisitante
        {
            get { return _pessoaVisitante; }
            set { _pessoaVisitante = value; }
        }

        public string assistidoVisitado
        {
            get { return _assistidoVisitado; }
            set { _assistidoVisitado = value; }
        }

        public DateTime? dataVisita
        {
            get { return _dataVisita; }
            set { _dataVisita = value; }
        }

        public DateTime? horaInicioVisita
        {
            get { return _horaInicioVisita; }
            set { _horaInicioVisita = value; }
        }

        public DateTime? horaFimVisita
        {
            get { return _horaFimVisita; }
            set { _horaFimVisita = value; }
        }

        public string motivoVisita
        {
            get { return _motivoVisita; }
            set { _motivoVisita = value; }
        }

        public string feedBackVisita
        {
            get { return _feedBackVisita; }
            set { _feedBackVisita = value; }
        }

        public string statusVisita
        {
            get { return _statusVisita; }
            set { _statusVisita = value; }
        }

    }
}