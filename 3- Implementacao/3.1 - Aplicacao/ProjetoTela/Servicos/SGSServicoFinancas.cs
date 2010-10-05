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

      
        public Financas SalvarFinancas(Financas objFinancas)
        {
            FinancasDados objFinancasDados = new FinancasDados();

            objFinancas = objFinancasDados.Salvar(objFinancas);

            return objFinancas;
        }

        public Financas ObterFinancas(int codigoFinancas)
        {
            FinancasDados objFinancasDados = new FinancasDados();

            return objFinancasDados.ObterFinancas(codigoFinancas);
        }

        public bool ExcluirFinancas(int codigoFinancas)
        {
            FinancasDados objFinancasDados = new FinancasDados();

            return objFinancasDados.ExcluirFinancas(codigoFinancas);
        }

        /// <summary>
        /// Consulta a tabela Financas e retorna resultados de acordo com o preenchimento do filtro 
        /// </summary>
  ///      public FinancasDTO ConsultarFinancas(FinancasDTO objFinancasDTO)
 ///       {
 ///           FinancasDados objFinancasDados = new FinancasDados();
 ///           objFinancasDTO.FinancasLista = objFinancasDados.ConsultarFinancas(objFinancasDTO);

 ///           return objFinancasDTO;

  ///      }

    }
}