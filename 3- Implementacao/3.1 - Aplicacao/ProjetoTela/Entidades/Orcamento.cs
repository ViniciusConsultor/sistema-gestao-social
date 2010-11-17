using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.CamadaDados;

namespace SGS.Entidades
{
    [Serializable]
    public class Orcamento
    {
        public Orcamento()
        {
        }

        private int? _codigoOrcamento;
        private int? _CodigoCasaLar;
        private string _nomePlano;
        private string _statusPlano;
        private Decimal? _valorOrcamento;
        private DateTime? _inicioVigencia;
        private DateTime? _fimVigencia;
        private List<OrcamentoNatureza> _orcamentoNaturezaLista;
        private CasaLar _casaLar;

        public int? CodigoOrcamento
        {
            get { return _codigoOrcamento; }
            set { _codigoOrcamento = value; }
        }

        public int? CodigoCasaLar
        {
            get { return _CodigoCasaLar; }
            set { _CodigoCasaLar = value; }
        }

        public string NomePlano
        {
            get { return _nomePlano; }
            set { _nomePlano = value; }
        }

        public string StatusPlano
        {
            get { return _statusPlano; }
            set { _statusPlano = value; }
        }

        public Decimal? ValorOrcamento
        {
            get { return _valorOrcamento; }
            set { _valorOrcamento = value; }
        }

        public DateTime? InicioVigencia
        {
            get { return _inicioVigencia; }
            set { _inicioVigencia = value; }
        }

        public DateTime? FimVigencia
        {
            get { return _fimVigencia; }
            set { _fimVigencia = value; }
        }

        
        public List<OrcamentoNatureza> OrcamentoNaturezaLista
        { 
                set { _orcamentoNaturezaLista = value; }
                get { return _orcamentoNaturezaLista; }
        }

        public CasaLar CasaLar
        {
            get { return _casaLar; }
            set { _casaLar = value; }
        }

        /// <summary>
        /// Esta propriedade retorna a soma de todos os Itens de um Crçamento
        /// </summary>
        public decimal ValorOrcado
        {
            get 
            {
                if (this.CodigoOrcamento.HasValue)
                {
                    OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();

                    List<OrcamentoNatureza> orcamentoNaturezaLista = objOrcamentoNaturezaDados.ListarPorCodigoOrcamento(this.CodigoOrcamento.Value);

                    decimal valor = 0;
                    foreach (OrcamentoNatureza item in orcamentoNaturezaLista)
                    {
                        valor += item.Valor.Value;
                    }

                    //retorna o somatório de todos os itens do orçamento
                    return valor;
                }
                else
                {
                    return 0;
                }
            }
        }


        /// <summary>
        /// Esta propriedade retorna o saldo disponível do orçamento
        /// </summary>
        public decimal SaldoDisponivelOrcamento
        {
            get
            {
                if (this.CodigoOrcamento.HasValue)
                {
                    OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();

                    List<OrcamentoNatureza> orcamentoNaturezaLista = objOrcamentoNaturezaDados.ListarPorCodigoOrcamento(this.CodigoOrcamento.Value);

                    decimal valorFinancas = 0;
                    foreach (OrcamentoNatureza item in orcamentoNaturezaLista)
                    {
                        valorFinancas += item.BalancoFinancas.Value;
                    }

                    //Retorna o saldo disponível do Orcamento
                    return (this.ValorOrcamento.Value - valorFinancas);
                }
                else
                {
                    return 0;
                }
            }
        }


        /// <summary>
        /// Esta propriedade retorna o verdadeiro valor que foi recebido e gasto de um determinado orçamento
        /// </summary>
        public decimal ValorFinanceiroReal
        {
            get
            {
                if (this.CodigoOrcamento.HasValue)
                {
                    OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();

                    List<OrcamentoNatureza> orcamentoNaturezaLista = objOrcamentoNaturezaDados.ListarPorCodigoOrcamento(this.CodigoOrcamento.Value);

                    decimal valorFinancas = 0;
                    foreach (OrcamentoNatureza item in orcamentoNaturezaLista)
                    {
                        valorFinancas += item.BalancoFinancas.Value;
                    }

                    //Retorna o valor financeiro que realmente foi recebido e gasto no mesmo período do Orçamento.
                    return (valorFinancas);
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}