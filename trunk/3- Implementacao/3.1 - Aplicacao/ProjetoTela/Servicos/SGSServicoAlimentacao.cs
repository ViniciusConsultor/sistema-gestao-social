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

            return objAlimentacaoDados.Obter(codigoAlimentacao);
        }


        /// <summary>
        /// Este método exclui todos os dados de uma Alimentação pelo seu código
        /// </summary>
        /// <param name="codigoAlimentacao"></param>
        /// <returns></returns>
        public bool ExcluirAlimentacao(int codigoAlimentacao)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();

            return objAlimentacaoDados.Excluir(codigoAlimentacao);
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
        public Alimentacao ObterAlimentacaoPorDiaPeriodo(string dia, string periodo)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();

            return objAlimentacaoDados.ObterPorDiaPeriodo(dia, periodo);
        }


        /// <summary>
        /// Consulta a Alimentação conforme o Dia Escolhido
        /// </summary>
        /// <param name="diaSemana"></param>
        public List<ConsultarAlimentacaoDTO.DiaSemanaDTO> ConsultarAlimentacao(string diaSemana)
        {
            AlimentacaoDados objAlimentacaoDados = new AlimentacaoDados();
            List<Alimentacao> objalimentacaoLista = new List<Alimentacao>();
            List<ConsultarAlimentacaoDTO.DiaSemanaDTO> objDiaSemanaDTOLista = new List<ConsultarAlimentacaoDTO.DiaSemanaDTO>();
            ConsultarAlimentacaoDTO.DiaSemanaDTO objDiaSemanaDTO = new ConsultarAlimentacaoDTO.DiaSemanaDTO();

            //Obtem a Alimentação lista por um dia da semana
            objalimentacaoLista = objAlimentacaoDados.ListarPorDia(diaSemana);


            if (objalimentacaoLista.Count > 0)
            {
                //Todas as alimentações são do mesmo dia
                objDiaSemanaDTO.DiaSemana = objalimentacaoLista[0].DiaSemana;

                //Adiciona os Períodos de Alimentação do dia
                ConsultarAlimentacaoDTO.PeriodoDTO objPeriodoDTO = null; 
                foreach (Alimentacao itemAlimentacao in objalimentacaoLista)
                {
                    objPeriodoDTO = new ConsultarAlimentacaoDTO.PeriodoDTO();

                    objPeriodoDTO.Diretiva = itemAlimentacao.Diretiva;
                    objPeriodoDTO.Horario = itemAlimentacao.Horario;
                    objPeriodoDTO.NomePeriodo = itemAlimentacao.Periodo;

                    if (objPeriodoDTO.NomePeriodo == "Colacao")
                        objPeriodoDTO.NomePeriodo = "Colação";
                    else if (objPeriodoDTO.NomePeriodo == "Almoco")
                        objPeriodoDTO.NomePeriodo = "Almoço";


                    //Concatena os alimentos da alimentação
                    foreach (AlimentacaoAlimento itemAlimentacaoAlimento in itemAlimentacao.AlimentacaoAlimentoLista)
                    {
                        objPeriodoDTO.Alimentos += itemAlimentacaoAlimento.NomeAlimento + ", ";
                    }
                    //Apaga a última vírgula
                    objPeriodoDTO.Alimentos = objPeriodoDTO.Alimentos.Remove(objPeriodoDTO.Alimentos.Length - 2);

                    //Insere os períodos do dia
                    objDiaSemanaDTO.PeriodoDTOLista.Add(objPeriodoDTO);
                }

                objDiaSemanaDTOLista.Add(objDiaSemanaDTO);
            }

            return objDiaSemanaDTOLista;
        }


    }
}