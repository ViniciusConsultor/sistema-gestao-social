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
        /// Este método salva e atualiza a tabela de Alimentação
        /// </summary>
        /// <param name="objAlimentacao"></param>
        /// <returns></returns>
        public Alimentacao SalvarAlimentacao(Alimentacao objAlimentacao)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();

            objAlimentacao = objAlimentacaoDados.Salvar(objAlimentacao);

            return objAlimentacao;
        }

        /// <summary>
        /// Este método obtem uma alimentação pelo seu código
        /// </summary>
        /// <param name="codigoAlimentacao"></param>
        /// <returns></returns>
        public Alimentacao ObterAlimentacao(int codigoAlimentacao)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();

            return objAlimentacaoDados.ObterAlimentacao(codigoAlimentacao);
        }


        /// <summary>
        /// Este método exclui todos os dados de uma Alimentação pelo seu código
        /// </summary>
        /// <param name="codigoAlimentacao"></param>
        /// <returns></returns>
        public bool ExcluirAlimentacao(int codigoAlimentacao)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();

            return objAlimentacaoDados.ExcluirAlimentacao(codigoAlimentacao);
        }

        
        /// <summary>
        /// Este método retorna uma lista de Alimento
        /// </summary>
        /// <returns></returns>
        public List<Alimento> ListarAlimento()
        {
            AlimentoDados objAlimentoDados = new AlimentoDados();

            return objAlimentoDados.Listar();
            
        }

        /// <summary>
        /// Este método retorna uma Alimentação pelo dia da semana e pelo período 
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="periodo"></param>
        /// <returns></returns>
        public Alimentacao ListarAlimentacaoPorDiaPeriodo(string dia, string periodo)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();

            //objAlimentacaoDado

            //Todo Maycon Desenvolver
            return new Alimentacao();
        }


       /// <summary>
       /// Consulta a tabela Alimentacao e retorna resultados de acordo com o preenchimento do filtro - Terminar o Consultar Primeiro.depois descomentar
       /// </summary>

        /*public AlimentacaoDTO ConsultarAlimentacao(AlimentacaoDTO objAlimentacaoDTO)
        /// <summary>
        /// Consulta a tabela Alimentacao e retorna resultados de acordo com o preenchimento do filtro
        /// </summary>
  /*      public AlimentacaoDTO ConsultarAlimentacao(AlimentacaoDTO objAlimentacaoDTO)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();
            //objAlimentacaoDTO.AlimentacaoLista = objAlimentacaoDados.ConsultarAlimentacao(objAlimentacaoDTO);

            return objAlimentacaoDTO;

        }*/


    }
}