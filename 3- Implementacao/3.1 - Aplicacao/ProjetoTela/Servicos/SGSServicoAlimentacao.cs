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

        public Alimentacao ObterAlimentacao(int codigoAlimentacao)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();

            return objAlimentacaoDados.ObterAlimentacao(codigoAlimentacao);
        }

        public bool ExcluirAlimentacao(int codigoAlimentacao)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();

            return objAlimentacaoDados.ExcluirAlimentacao(codigoAlimentacao);
        }

        /// <summary>
        /// Consulta a tabela Alimentacao e retorna resultados de acordo com o preenchimento do filtro
        /// </summary>
        public AlimentacaoDTO ConsultarAlimentacao(AlimentacaoDTO objAlimentacaoDTO)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();
            //objAlimentacaoDTO.AlimentacaoLista = objAlimentacaoDados.ConsultarAlimentacao(objAlimentacaoDTO);

            return objAlimentacaoDTO;

        }


    }
}