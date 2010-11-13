﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using SGS.Entidades;
using System.Data.SqlClient;
using SGS.Entidades.DTO;

namespace SGS.CamadaDados
{
    public class AlimentacaoDados : BaseConnection
    {
 
    /// <summary>
    /// Este método salva a Alimentacao.
    /// </summary>
    /// <param name="objAlimentacao"></param>
    /// <returns></returns>
        public Alimentacao Salvar(Alimentacao objAlimentacao)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objAlimentacao.CodigoAlimentacao.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Alimentacao (DiaSemana, Periodo, Horario, Alimento, Diretiva)
                    VALUES (@diaSemana, @periodo, @horario, @alimento, @diretiva)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Alimentacao SET DiaSemana = @diaSemana,
                        Periodo = @periodo, Horario = @horario, Alimento = @alimento, Diretiva = @diretiva
                        WHERE (CodigoAlimentacao = @CodigoAlimentacao)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objAlimentacao.CodigoAlimentacao.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@CodigoAlimentacao", objAlimentacao.CodigoAlimentacao.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroDiaSemana = new SqlParameter("@diaSemana", objAlimentacao.DiaSemana);
            parametroDiaSemana.DbType = System.Data.DbType.String;

            SqlParameter parametroPeriodo = new SqlParameter("@periodo", objAlimentacao.Periodo);
            parametroPeriodo.DbType = System.Data.DbType.String;

            SqlParameter parametroHorario = new SqlParameter("@horario", objAlimentacao.Horario);
            parametroHorario.DbType = System.Data.DbType.String;

            SqlParameter parametroAlimento = new SqlParameter("@alimento", objAlimentacao.Alimento);
            parametroAlimento.DbType = System.Data.DbType.String;

            SqlParameter parametroDiretiva = new SqlParameter("@diretiva", objAlimentacao.Diretiva);
            parametroAlimento.DbType = System.Data.DbType.String;

            comando.Parameters.Add(parametroDiaSemana);
            comando.Parameters.Add(parametroPeriodo);
            comando.Parameters.Add(parametroHorario);
            comando.Parameters.Add(parametroAlimento);
            comando.Parameters.Add(parametroDiretiva);

            comando.ExecuteNonQuery();

            //Pega o código gerado no banco de Alimentação
            //List<AlimentacaoAlimento> alimentacaoAlimentoLista = objAlimentacao.AlimentacaoAlimentoLista;

            if (!objAlimentacao.CodigoAlimentacao.HasValue)
            {
                Alimentacao AlimentacaoClone = ObterUltimaAlimentacaoInserida();
                objAlimentacao.CodigoAlimentacao = AlimentacaoClone.CodigoAlimentacao;
            }

            //Salva os alimentos da Alimentação
            foreach (AlimentacaoAlimento item in objAlimentacao.AlimentacaoAlimentoLista)
            {
                item.CodigoAlimentacao = objAlimentacao.CodigoAlimentacao;
            }

            AlimentacaoAlimentoDados objAlimentacaoAlimentoDados = new AlimentacaoAlimentoDados();
            objAlimentacaoAlimentoDados.Salvar(objAlimentacao.AlimentacaoAlimentoLista);

            return objAlimentacao;
        
        }

            /// <summary>
            /// Obtém a Alimentacao pelo seu Código de Alimentacao
        /// </summary>
        /// <param name="codigoAlimentacao"></param>
        /// <returns></returns>
        public Alimentacao ObterAlimentacao(int CodigoAlimentacao)
        {
            SqlCommand comando = new SqlCommand("select * from Alimentacao where CodigoAlimentacao = @CodigoAlimentacao", base.Conectar());
            SqlParameter parametroCodigoAlimentacao = new SqlParameter("@CodigoAlimentacao", CodigoAlimentacao);
            parametroCodigoAlimentacao.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAlimentacao);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Alimentacao objAlimentacao = null;

            if (leitorDados.Read())
            {
                objAlimentacao = new Alimentacao();

                objAlimentacao.CodigoAlimentacao = CodigoAlimentacao;
                objAlimentacao.DiaSemana = leitorDados["DiaSemana"].ToString();
                objAlimentacao.Periodo = leitorDados["Periodo"].ToString();
                objAlimentacao.Horario = Convert.ToString(leitorDados["Horario"]);
                objAlimentacao.Alimento = leitorDados["Alimento"].ToString();
                objAlimentacao.Diretiva = leitorDados["Diretiva"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objAlimentacao;
        }

        public Alimentacao ObterUltimaAlimentacaoInserida()
        {
            SqlCommand comando = new SqlCommand(@"SELECT TOP (1) * FROM Alimentacao ORDER BY CodigoAlimentacao DESC", base.Conectar());

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Alimentacao objAlimentacao = null;

            if (leitorDados.Read())
            {
                objAlimentacao = new Alimentacao();
                objAlimentacao.CodigoAlimentacao = Convert.ToInt32(leitorDados["CodigoAlimentacao"]);
                objAlimentacao.DiaSemana = leitorDados["DiaSemana"].ToString();
                objAlimentacao.Periodo = leitorDados["Periodo"].ToString();
                objAlimentacao.Horario = Convert.ToString(leitorDados["Horario"]);
                objAlimentacao.Diretiva = leitorDados["Diretiva"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objAlimentacao;
        }

        /// <summary>
        /// Exclui uma Alimentacao pelo seu código
        /// </summary>
        public bool ExcluirAlimentacao(int CodigoAlimentacao)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Alimentacao where CodigoAlimentacao = @CodigoAlimentacao", base.Conectar());

            SqlParameter parametroCodigoAlimentacao = new SqlParameter("@CodigoAlimentacao", CodigoAlimentacao);
            parametroCodigoAlimentacao.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAlimentacao);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

        public List<Alimento> Listar()
        {
            List<Alimento> AlimentoLista = new List<Alimento>();
            Alimento objAlimento = null;

            SqlCommand comando = new SqlCommand(@"select * from Alimento ORDER BY NomeAlimento ASC", base.Conectar());

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (leitorDados.Read())
            {
                objAlimento = new Alimento();

                //Dados Tabela Alimento
                objAlimento.CodigoAlimento = Convert.ToInt32(leitorDados["CodigoAlimento"]);
                objAlimento.NomeAlimento = leitorDados["NomeAlimento"].ToString();

                AlimentoLista.Add(objAlimento);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return AlimentoLista;
        }
 
    }
}

