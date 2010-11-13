﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.CamadaDados;
using SGS.Entidades;
using SGS.Entidades.DTO;

namespace SGS.Servicos
{
    
    public partial class SGSServico
    {
        /// <summary>
        /// Este método retorna uma Escolar conforme o código do parâmetro
        /// </summary>
        /// <param name="codigoEscolar"> Representa o código de Escolar</param>
        /// <returns></returns>

        public Escolar SalvarEscolar(Escolar objEscolar)
        {
            EscolarDados objEscolarDados = new EscolarDados();

            objEscolar = objEscolarDados.Salvar(objEscolar);

            return objEscolar;
        }

        /// <summary>
        /// Este método obtém uma Escolar pelo seu código
        /// </summary>
        /// <param name="codigoEscolar"></param>
        /// <returns></returns>
        public Escolar ObterEscolar(int codigoEscolar)
        {
            EscolarDados objEscolarDados = new EscolarDados();

            return objEscolarDados.ObterEscolar(codigoEscolar);
        }

        /// <summary>
        /// Este método exclui a Escolar e o seu respectivo contato.
        /// </summary>
        /// <param name="codigoEscolar"></param>
        /// <param name="codigoContato"></param>
        /// <returns></returns>
        public bool ExcluirEscolar(int codigoEscolar, int codigoContato)
        {
            EscolarDados objEscolarDados = new EscolarDados();

            return objEscolarDados.ExcluirEscolar(codigoEscolar, codigoContato);
        }

        /// <summary>
        /// Este Serviço retorna uma lista de assistido
        /// </summary>
        /// <returns></returns>
        public List<Assistido> ListarAssistido(bool assistidoAtivado)
        {
            AssistidoDados objAssistidoDados = new AssistidoDados();

            return objAssistidoDados.Listar(assistidoAtivado);
            
        }

        /// <summary>
        /// Consulta a tabela Escolar e retorna resultados de acordo com o preenchimento do filtro 
        /// </summary>
        public List<GradeConsultarEscolarDTO> ConsultarEscolar(ParametroConsultarEscolarDTO objParametroConsultarEscolarDTO)
        {
            EscolarDados objEscolarDados = new EscolarDados();
            
            return objEscolarDados.ConsultarEscolar(objParametroConsultarEscolarDTO);
        }

    }
}