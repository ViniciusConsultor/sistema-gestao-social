﻿using System;
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

            return objAssistidoDados.Obter(codigoAssistido);
        }

        /// <summary>
        /// Este Serviço retorna uma lista de assistido
        /// </summary>
        /// <returns></returns>
        public List<Assistido> ListarAssistido(bool? assistidoAtivado)
        {
            AssistidoDados objAssistidoDados = new AssistidoDados();

            return objAssistidoDados.Listar(assistidoAtivado);
        }

        /// <summary>
        /// Este Serviço consulta assistidos pelos dados do filtro
        /// </summary>
        /// <returns></returns>
        public List<Assistido> ConsultarAssistido(ConsultarAssistidoDTO objConsultarAssistidoDTO)
        {
            AssistidoDados objAssistidoDados = new AssistidoDados();

            return objAssistidoDados.Consultar(objConsultarAssistidoDTO);
        }

        /// <summary>
        /// Este Serviço consulta assistidos pelos dados do filtro do relatório
        /// </summary>
        /// <returns></returns>
        public List<Assistido> GerarRelatorioAssistido(ConsultarAssistidoDTO objConsultarAssistidoDTO)
        {
            AssistidoDados objAssistidoDados = new AssistidoDados();

            return objAssistidoDados.Consultar(objConsultarAssistidoDTO);
        }


    }
}