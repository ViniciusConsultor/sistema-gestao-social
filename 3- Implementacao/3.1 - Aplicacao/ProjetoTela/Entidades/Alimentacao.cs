using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SGS.Entidades
{
    [Serializable]
    public class Alimentacao
    {
        private int? _codigoAlimentacao;
        private string _diaSemana;
        private string _periodo;
        private string _horario;
        private string _alimento;
        private string _diretiva;

        public int? CodigoAlimentacao
        {
            get { return _codigoAlimentacao; }
            set { _codigoAlimentacao = value; }
        }

        public string DiaSemana
        {
            get { return _diaSemana; }
            set { _diaSemana = value; }
        }

        public string Periodo
        {
            get { return _periodo; }
            set { _periodo = value; }
        }

        public string Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

        public string Alimento
        {
            get { return _alimento; }
            set { _alimento = value; }
        }

        public string Diretiva
        {
            get { return _diretiva; }
            set { _diretiva = value; }
        }

        List<Alimento> _alimentoLista;

        /// <summary>
        /// Lista de Alimento
        /// </summary>
        public List<Alimento> AlimentoLista
        {
            get { return _alimentoLista; }
            set { _alimentoLista = value; }
        }

        List<AlimentacaoAlimento> _alimentacaoAlimentoLista;

        /// <summary>
        /// Lista de AlimetacaoAlimento
        /// </summary>
        public List<AlimentacaoAlimento> AlimentacaoAlimentoLista
        {
            get { return _alimentacaoAlimentoLista; }
            set { _alimentacaoAlimentoLista = value; }
        }

    }
}