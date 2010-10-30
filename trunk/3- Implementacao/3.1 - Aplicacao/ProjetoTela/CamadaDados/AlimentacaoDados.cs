using System;
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
                    @"INSERT INTO Alimentacao (Assistido_CodigoAssistido, DiaSemana, Periodo, Horario, Alimento, PorcaoAlimento, Diretiva)
                    VALUES (@assistido_CodigoAssistido, @diaSemana, @periodo, @horario, @alimento, @porcaoAlimento, @diretiva)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Alimentacao SET Assistido_CodigoAssistido = @assistido_CodigoAssistido, DiaSemana = @diaSemana,
                        Periodo = @periodo, Horario = @horario, Alimento = @alimento, PorcaoAlimento = @porcaoAlimento, Diretiva = @diretiva
                        WHERE (CodigoAlimentacao = @codigoAlimentacao)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objAlimentacao.CodigoAlimentacao.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoAlimentacao", objAlimentacao.CodigoAlimentacao.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroAssistido_CodigoAssistido = new SqlParameter();
            if (objAlimentacao.Assistido_CodigoAssistido.HasValue)
            {
                parametroAssistido_CodigoAssistido.Value = objAlimentacao.Assistido_CodigoAssistido.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroAssistido_CodigoAssistido.Value = DBNull.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroDiaSemana = new SqlParameter("@diaSemana", objAlimentacao.DiaSemana);
            parametroDiaSemana.DbType = System.Data.DbType.String;

            SqlParameter parametroPeriodo = new SqlParameter("@periodo", objAlimentacao.Periodo);
            parametroPeriodo.DbType = System.Data.DbType.String;

            SqlParameter parametroHorario = new SqlParameter("@horario", objAlimentacao.Horario);
            parametroHorario.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroAlimento = new SqlParameter("@alimento", objAlimentacao.Alimento);
            parametroAlimento.DbType = System.Data.DbType.String;

            SqlParameter parametroPorcaoAlimento = new SqlParameter("@porcaoAlimento", objAlimentacao.PorcaoAlimento);
            parametroAlimento.DbType = System.Data.DbType.String;

            SqlParameter parametroDiretiva = new SqlParameter("@diretiva", objAlimentacao.PorcaoAlimento);
            parametroAlimento.DbType = System.Data.DbType.String;

            comando.Parameters.Add(parametroAssistido_CodigoAssistido);
            comando.Parameters.Add(parametroDiaSemana);
            comando.Parameters.Add(parametroPeriodo);
            comando.Parameters.Add(parametroHorario);
            comando.Parameters.Add(parametroAlimento);
            comando.Parameters.Add(parametroPorcaoAlimento);
            comando.Parameters.Add(parametroDiretiva);

            comando.ExecuteNonQuery();

            //TODO: retorno entidade alimentacao com o Código da Alimentacao Preenchido
            return objAlimentacao;
        }

            /// <summary>
            /// Obtém a Alimentacao pelo seu Código de Alimentacao
        /// </summary>
        /// <param name="codigoAlimentacao"></param>
        /// <returns></returns>
        public Alimentacao ObterAlimentacao(int codigoAlimentacao)
        {
            SqlCommand comando = new SqlCommand("select * from Alimentacao where CodigoAlimentacao = @codigoAlimentacao", base.Conectar());
            SqlParameter parametroCodigoAlimentacao = new SqlParameter("@codigoAlimentacao", codigoAlimentacao);
            parametroCodigoAlimentacao.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAlimentacao);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Alimentacao objAlimentacao = null;

            if (leitorDados.Read())
            {
                objAlimentacao = new Alimentacao();

                objAlimentacao.CodigoAlimentacao = codigoAlimentacao;
                objAlimentacao.Assistido_CodigoAssistido = Convert.ToInt32(leitorDados["Assistido_CodigoAssistido"]);
                objAlimentacao.DiaSemana = leitorDados["DiaSemana"].ToString();
                objAlimentacao.Periodo = leitorDados["Periodo"].ToString();
                objAlimentacao.Horario = Convert.ToDateTime(leitorDados["Horario"]);
                objAlimentacao.Alimento = leitorDados["Alimento"].ToString();
                objAlimentacao.PorcaoAlimento = leitorDados["PorcaoAlimento"].ToString();
                objAlimentacao.Diretiva = leitorDados["Diretiva"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objAlimentacao;
        }

        /// <summary>
        /// Exclui uma Alimentacao pelo seu código
        /// </summary>
        public bool ExcluirAlimentacao(int codigoAlimentacao)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Alimentacao where CodigoAlimentacao = @codigoAlimentacao", base.Conectar());

            SqlParameter parametroCodigoAlimentacao = new SqlParameter("@codigoAlimentacao", codigoAlimentacao);
            parametroCodigoAlimentacao.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAlimentacao);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());
            
            return execucao;

        }
    
    }
}