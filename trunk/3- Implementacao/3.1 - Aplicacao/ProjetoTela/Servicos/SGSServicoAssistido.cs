using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;
using SGS.Entidades.DTO;
using SGS.CamadaDados;

namespace SGS.Servicos
{
    public partial class SGSServico
    {

        /// <summary>
        /// Este serviço Cadastra ou Atualiza um Assistido e seus demais dados 
        /// </summary>
        /// <returns></returns>
        public Assistido SalvarAssistido(Assistido objAssistido)
        {
            AssistidoDados objAssistidoDados = new AssistidoDados();

            return objAssistidoDados.Salvar(objAssistido);
        }

        /// <summary>
        /// Este serviço obtém um Assistido pelo seu código
        /// </summary>
        /// <param name="codigoAssistido"></param>
        /// <returns></returns>
        public Assistido ObterAssistido(int codigoAssistido)
        {
            AssistidoDados objAssistidoDados = new AssistidoDados();

            return objAssistidoDados.ObterAssistido(codigoAssistido);
        }

    }
}