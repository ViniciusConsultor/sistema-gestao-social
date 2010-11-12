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
      /// <param name="objDesenvolvimento"></param>
      /// <returns></returns>
        public Desenvolvimento SalvarDesenvolvimento(Desenvolvimento objDesenvolvimento)
        {
            DesenvolvimentoDados objDesenvolvimentoDados = new DesenvolvimentoDados();

            objDesenvolvimento = objDesenvolvimentoDados.Salvar(objDesenvolvimento);

            return objDesenvolvimento;
        }

        public Desenvolvimento ObterDesenvolvimento(int codigoDesenvolvimento)
        {
            DesenvolvimentoDados objDesenvolvimentoDados = new DesenvolvimentoDados();

            return objDesenvolvimentoDados.ObterDesenvolvimento(codigoDesenvolvimento);
        }

        public bool ExcluirDesenvolvimento(int codigoDesenvolvimento)
        {
            DesenvolvimentoDados objDesenvolvimentoDados = new DesenvolvimentoDados();

            return objDesenvolvimentoDados.ExcluirDesenvolvimento(codigoDesenvolvimento);
        }

       /// <summary>
       /// Consulta a tabela Desenvolvimento e retorna resultados de acordo com o preenchimento do filtro - Terminar o Consultar Primeiro.depois descomentar
       /// </summary>

        public DesenvolvimentoDTO ConsultarDesenvolvimento(DesenvolvimentoDTO objDesenvolvimentoDTO)
        {
            DesenvolvimentoDados objDesenvolvimentoDados = new DesenvolvimentoDados();
            objDesenvolvimentoDTO.DesenvolvimentoAssistidoDTOLista = objDesenvolvimentoDados.ConsultarDesenvolvimento(objDesenvolvimentoDTO);

            return objDesenvolvimentoDTO;

        }

    }
}