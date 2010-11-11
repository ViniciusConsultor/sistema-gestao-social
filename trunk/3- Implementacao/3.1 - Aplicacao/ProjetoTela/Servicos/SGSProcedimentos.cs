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
        /// Este método salva e atualiza a tabela de Procedimentos
        /// </summary>
        /// <param name="objProcedimentos"></param>
        /// <returns></returns>
        public Procedimentos SalvarProcedimentos(Procedimentos objProcedimentos)
        {
            ProcedimentosDados objProcedimentosDados = new ProcedimentosDados();

            objProcedimentos = objProcedimentosDados.Salvar(objProcedimentos);

            return objProcedimentos;
        }

        public Procedimentos ObterProcedimentos(int codigoProcedimentos)
        {
            ProcedimentosDados objProcedimentosDados = new ProcedimentosDados();

            return objProcedimentosDados.ObterProcedimentos(codigoProcedimentos);
        }

        public bool ExcluirProcedimentos(int codigoProcedimentos)
        {
            ProcedimentosDados objProcedimentosDados = new ProcedimentosDados();

            return objProcedimentosDados.ExcluirProcedimentos(codigoProcedimentos);
        }

        /// <summary>
        /// Consulta a tabela Procedimentos e retorna resultados de acordo com o preenchimento do filtro
        /// </summary>

        public ProcedimentosDTO ConsultarProcedimentos(ProcedimentosDTO objProcedimentosDTO)
        {
            ProcedimentosDados objProcedimentosDados = new ProcedimentosDados();
            objProcedimentosDTO.ProcedimentosLista = objProcedimentosDados.ConsultarProcedimentos(objProcedimentosDTO);

            return objProcedimentosDTO;

        }
    }
}