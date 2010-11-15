using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;

namespace SGS.Entidades.DTO
{
    [Serializable]
    public class ConsultarAssistidoDTO
    {

        private List<Assistido> _assistidoLista;
        public List<Assistido> AssistidoLista
        {
            get { return _assistidoLista; }
            set { _assistidoLista = value;  }
        }

        private int? _codigoAssisitoValor;
        public int? CodigoAssisitoValor
        {
            get { return _codigoAssisitoValor; }
            set { _codigoAssisitoValor = value; }
        }

        private string _statusAssistidoValor;
        public string StatusAssistidoValor
        {
            get { return _statusAssistidoValor; }
            set { _statusAssistidoValor = value; }
        }

        private bool? _statusCadastroValor;
        public bool? StatusCadastroValor
        {
            get { return _statusCadastroValor; }
            set { _statusCadastroValor = value; }
        }

        private string _nomeAssistidoValor;
        public string NomeAssistidoValor
        {
            get { return _nomeAssistidoValor; }
            set { _nomeAssistidoValor = value; }
        }

    }
}