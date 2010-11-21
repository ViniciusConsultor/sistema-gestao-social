using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;
using SGS.CamadaDados;
using SGS.Entidades.DTO;

namespace SGS.Servicos
{
    public partial class SGSServico
    {

        /// <summary>
      /// Este método salva e atualiza a tabela orcamento
      /// </summary>
      /// <param name="objOrcamento"></param>
      /// <returns></returns>
        public Orcamento SalvarOrcamento(Orcamento objOrcamento)
        {
            OrcamentoDados objOrcamentoDados = new OrcamentoDados();

            objOrcamento = objOrcamentoDados.Salvar(objOrcamento);

            return objOrcamento;
        }

        /// <summary>
        /// Este método obtém um Orçamento pelo seu código
        /// </summary>
        /// <param name="codigoOrcamento"></param>
        /// <returns></returns>
        public Orcamento ObterOrcamento(int codigoOrcamento)
        {
            OrcamentoDados objOrcamentoDados = new OrcamentoDados();

            return objOrcamentoDados.ObterOrcamento(codigoOrcamento);
        }

        /// <summary>
        /// Este método exclui um Orçamento pelo seu código
        /// </summary>
        /// <param name="codigoOrcamento"></param>
        /// <returns></returns>
        public bool ExcluirOrcamento(int codigoOrcamento)
        {
            OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();
            OrcamentoDados objOrcamentoDados = new OrcamentoDados();

            //Exclui todos os itens do orçamento
            objOrcamentoNaturezaDados.ExcluirPorCodigoOrcamento(codigoOrcamento);

            //Exclui o orçamento
            return objOrcamentoDados.ExcluirOrcamento(codigoOrcamento);
        }

        /// <summary>
        /// Este método exclui um OrçamentoNatureza pelo seu código orçamento e código natureza
        /// </summary>
        /// <param name="codigoOrcamento"></param>
        /// <returns></returns>
        public bool ExcluirOrcamentoNatureza(int codigoOrcamento, int codigoNatureza)
        {
            OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();

            return objOrcamentoNaturezaDados.Excluir(codigoOrcamento, codigoNatureza);
        }

        /// <summary>
        /// Este método inclui um Item de Orçamento no Orçamento Geral
        /// </summary>
        /// <param name="objOrcamentoNatureza"></param>
        /// <returns></returns>
        public OrcamentoNatureza IncluirItemOrcamento(OrcamentoNatureza objOrcamentoNatureza)
        {
            OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();

            objOrcamentoNatureza = objOrcamentoNaturezaDados.Salvar(objOrcamentoNatureza);

            return objOrcamentoNatureza;
        }

        public bool RemoverItemOrcamento(int codigoOrcamento, int codigoNatureza)
        {
            OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();

            return objOrcamentoNaturezaDados.Excluir(codigoOrcamento, codigoNatureza);
        }

        /// <summary>
        /// Consulta a tabela Orcamento e retorna resultados de acordo com o preenchimento do filtro
        /// </summary>
        public OrcamentoDTO ConsultarOrcamento(OrcamentoDTO objOrcamentoDTO)
        {
            OrcamentoDados objOrcamentoDados = new OrcamentoDados();
            objOrcamentoDTO.OrcamentoLista = objOrcamentoDados.ConsultarOrcamento(objOrcamentoDTO);

            return objOrcamentoDTO;

        }

        /// <summary>
        /// Retorna uma lista de natureza de de lancamento.
        /// </summary>
        public List<NaturezaLancamento> ListarNaturezaDespesa()
        {
            NaturezaLancamentoDados objNaturezaLancamentoDados = new NaturezaLancamentoDados();

            return objNaturezaLancamentoDados.ListarNaturezaLancamento();

        }

        /// <summary>
        /// Retorna uma lista de casa lar.
        /// </summary>
        public List<CasaLar> ListarCasaLarOrcamento()
        {
            CasaLarDados objCasaLarDados = new CasaLarDados();

            return objCasaLarDados.Listar();

        }

        /// <summary>
        /// Retorna uma lista de orcamento.
        /// </summary>
        public List<Orcamento> ListarOrcamento()
        {
            OrcamentoDados objOrcamentoDados = new OrcamentoDados();

            return objOrcamentoDados.ListarOrcamento();

        }

        /// <summary>
        /// Este método obtém um ObterOrcamentoNatureza pelo codigoNaturezaLancamento e codigoOrcamento
        /// </summary>
        /// <param name="codigoNaturezaLancamento"></param>
        /// <param name="codigoOrcamento"></param>
        /// <returns></returns>
        public OrcamentoNatureza ObterOrcamentoNatureza(int codigoNaturezaLancamento, int codigoOrcamento)
        {
            OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();

            return objOrcamentoNaturezaDados.ObterOrcamentoNatureza(codigoNaturezaLancamento, codigoOrcamento);
        }

        /// <summary>
        /// Lista o OrcamentoNatureza pelo código orçamento
        /// </summary>
        /// <param name="codigoOrcamento"></param>
        /// <returns></returns>
        public List<OrcamentoNatureza> ListarOrcamentoNatureza(int codigoOrcamento)
        {
            OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();
            
            return objOrcamentoNaturezaDados.ListarPorCodigoOrcamento(codigoOrcamento);
        }

        
    }
    
}