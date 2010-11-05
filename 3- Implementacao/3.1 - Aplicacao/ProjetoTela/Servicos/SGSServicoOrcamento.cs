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

        public Orcamento ObterOrcamento(int codigoOrcamento)
        {
            OrcamentoDados objOrcamentoDados = new OrcamentoDados();

            return objOrcamentoDados.ObterOrcamento(codigoOrcamento);
        }

        public bool ExcluirOrcamento(int codigoOrcamento)
        {
            OrcamentoDados objOrcamentoDados = new OrcamentoDados();

            return objOrcamentoDados.ExcluirOrcamento(codigoOrcamento);
        }

        public OrcamentoNatureza IncluirItemOrcamento(OrcamentoNatureza objOrcamentoNatureza)
        {
            OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();

            objOrcamentoNatureza = objOrcamentoNaturezaDados.Salvar(objOrcamentoNatureza);

            return objOrcamentoNatureza;
        }

        public bool RemoverItemOrcamento(int codigoOrcamento)
        {
            OrcamentoNaturezaDados objOrcamentoNaturezaDados = new OrcamentoNaturezaDados();

            return objOrcamentoNaturezaDados.ExcluirOrcamentoNatureza(codigoOrcamento);
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

            return objCasaLarDados.ListarCasaLar();

        }


        
    }
    
}