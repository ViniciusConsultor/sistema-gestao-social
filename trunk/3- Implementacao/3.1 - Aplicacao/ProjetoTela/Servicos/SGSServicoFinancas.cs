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
      /// Este método salva e atualiza a tabela de finanças
      /// </summary>
      /// <param name="objFinancas"></param>
      /// <returns></returns>
        public Financas SalvarFinancas(Financas objFinancas)
        {
            FinancasDados objFinancasDados = new FinancasDados();

            objFinancas = objFinancasDados.Salvar(objFinancas);

            return objFinancas;
        }

        /// <summary>
        /// Obtem uma Finança
        /// </summary>
        /// <param name="codigoFinancas"></param>
        /// <returns></returns>
        public Financas ObterFinancas(int codigoFinancas)
        {
            FinancasDados objFinancasDados = new FinancasDados();

            return objFinancasDados.Obter(codigoFinancas);
        }

        /// <summary>
        /// Excluir uma Finanças
        /// </summary>
        /// <param name="codigoFinancas"></param>
        /// <returns></returns>
        public bool ExcluirFinancas(int codigoFinancas)
        {
            FinancasDados objFinancasDados = new FinancasDados();

            return objFinancasDados.Excluir(codigoFinancas);
        }

       /// <summary>
       /// Consulta a tabela Financas e retorna resultados de acordo com o preenchimento do filtro
       /// </summary>
        public FinancasDTO ConsultarFinancas(FinancasDTO objFinancasDTO)
        {
            FinancasDados objFinancasDados = new FinancasDados();
            objFinancasDTO.FinancasLista = objFinancasDados.Consultar(objFinancasDTO);

            return objFinancasDTO;

        }

        /// <summary>
        /// Retorna uma lista de natureza de de lancamento.
        /// </summary>
        public List<NaturezaLancamento> ListarNaturezaLancamento()
        {
            NaturezaLancamentoDados objNaturezaLancamentoDados = new NaturezaLancamentoDados();
            
            return objNaturezaLancamentoDados.Listar();

        }

        /// <summary>
        /// Retorna uma lista de casa lar.
        /// </summary>
        public List<CasaLar> ListarCasaLar()
        {
            CasaLarDados objCasaLarDados = new CasaLarDados();

            return objCasaLarDados.Listar();

        }

        /// <summary>
        /// Retorna uma lista de finanças pelo relatório do Filtro do Financeiro
        /// </summary>
        /// <param name="objFinanceiroRelatorioDTO"></param>
        /// <returns></returns>
        public List<Financas> ConsultarFinancasRelatorio(FinanceiroRelatorioDTO objFinanceiroRelatorioDTO)
        {
            FinancasDados objFinancasDados = new FinancasDados();

            return objFinancasDados.Consultar(objFinanceiroRelatorioDTO);
        }

    }
}