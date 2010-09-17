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
    public class DadosBancariosDados : BaseConnection
    {
        /// <summary>
        /// Este método salva os DadosBancarios
        /// </summary>
        /// <param name="objDadosBancarios"></param>
        /// <returns></returns>
        public DadosBancarios Salvar(DadosBancarios objDadosBancarios)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objDadosBancarios.CodigoDadosBancarios.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO DadosBancarios (Patrocinador_CodigoPatrocinador, Voluntario_CodigoVoluntario, 
                        Funcionario_CodigoFuncionario, Agencia, ContaBancaria, Banco)
                    VALUES (@patrocinador_CodigoPatrocinador, @voluntario_CodigoVoluntario, @funcionario_CodigoVoluntario,
                            @agencia, @contaBancaria, @banco)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE DadosBancarios SET Patrocinador_CodigoPatrocinador = @patrocinador_CodigoPatrocinador,
                                Voluntario_CodigoVoluntario = @voluntario_CodigoVoluntario,
                                Funcionario_CodigoFuncionario = @funcionario_CodigoFuncionario, Agencia = @agencia,
                                ContaBancaria = @contaBancaria
                      WHERE (CodigoDadosBancarios = @codigoDadosBancarios)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objDadosBancarios.CodigoDadosBancarios.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoDadosBancarios", objDadosBancarios.CodigoDadosBancarios.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroPatrocinador_CodigoPatrocinador = new SqlParameter();
            if (objDadosBancarios.Patrocinador_CodigoPatrocinador.HasValue)
            {
                parametroPatrocinador_CodigoPatrocinador.Value = objDadosBancarios.Patrocinador_CodigoPatrocinador.Value;
                parametroPatrocinador_CodigoPatrocinador.ParameterName = "@patrocinador_CodigoPatrocinador";
                parametroPatrocinador_CodigoPatrocinador.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroPatrocinador_CodigoPatrocinador.Value = DBNull.Value;
                parametroPatrocinador_CodigoPatrocinador.ParameterName = "@patrocinador_CodigoPatrocinador";
                parametroPatrocinador_CodigoPatrocinador.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroVoluntario_CodigoVoluntario = new SqlParameter();
            if (objDadosBancarios.Voluntario_CodigoVoluntario.HasValue)
            {
                parametroVoluntario_CodigoVoluntario.Value = objDadosBancarios.Voluntario_CodigoVoluntario.Value;
                parametroVoluntario_CodigoVoluntario.ParameterName = "@voluntario_CodigoVoluntario";
                parametroVoluntario_CodigoVoluntario.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroVoluntario_CodigoVoluntario.Value = DBNull.Value;
                parametroVoluntario_CodigoVoluntario.ParameterName = "@voluntario_CodigoVoluntario";
                parametroVoluntario_CodigoVoluntario.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroFuncionario_CodigoFuncionario = new SqlParameter();
            if (objDadosBancarios.Funcionario_CodigoFuncionario.HasValue)
            {
                parametroFuncionario_CodigoFuncionario.Value = objDadosBancarios.Funcionario_CodigoFuncionario.Value;
                parametroFuncionario_CodigoFuncionario.ParameterName = "@funcionario_CodigoFuncionario";
                parametroFuncionario_CodigoFuncionario.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroFuncionario_CodigoFuncionario.Value = DBNull.Value;
                parametroFuncionario_CodigoFuncionario.ParameterName = "@funcionario_CodigoFuncionario";
                parametroFuncionario_CodigoFuncionario.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroAgencia = new SqlParameter("@agencia", objDadosBancarios.Agencia);
            parametroAgencia.DbType = System.Data.DbType.String;

            SqlParameter parametroContaBancaria = new SqlParameter("@contaBancaria", objDadosBancarios.ContaBancaria);
            parametroContaBancaria.DbType = System.Data.DbType.String;

            SqlParameter parametroBanco = new SqlParameter("@banco", objDadosBancarios.Banco);
            parametroBanco.DbType = System.Data.DbType.String;

            comando.Parameters.Add(parametroPatrocinador_CodigoPatrocinador);
            comando.Parameters.Add(parametroVoluntario_CodigoVoluntario);
            comando.Parameters.Add(parametroFuncionario_CodigoFuncionario);
            comando.Parameters.Add(parametroAgencia);
            comando.Parameters.Add(parametroContaBancaria);
            comando.Parameters.Add(parametroBanco);

            comando.ExecuteNonQuery();

            //TODO: retorno entidade Dados com o Código dos dadosBancarios Preenchido
            return objDadosBancarios;
        }

        /// <summary>
        /// Obtém os DadosBancarios Código dos dadosbancarios
        /// </summary>
        /// <param name="codigoDadosBancarios"></param>
        /// <returns></returns>
        public DadosBancarios ObterDadosBancarios(int codigoDadosBancarios)
        {
            SqlCommand comando = new SqlCommand("select * from DadosBancarios where CodigoDadosBancarios = @codigoDadosBancarios", base.Conectar());
            SqlParameter parametroCodigoDadosBancarios = new SqlParameter("@codigoDadosBancarios", codigoDadosBancarios);
            parametroCodigoDadosBancarios.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoDadosBancarios);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            DadosBancarios objDadosBancarios = null;

            if (leitorDados.Read())
            {
                objDadosBancarios = new DadosBancarios();

                objDadosBancarios.CodigoDadosBancarios = codigoDadosBancarios;
                objDadosBancarios.Patrocinador_CodigoPatrocinador = Convert.ToInt32(leitorDados["Patrocinador_CodigoPatrocinador"]);
                objDadosBancarios.Voluntario_CodigoVoluntario = Convert.ToInt32(leitorDados["Voluntario_CodigoVoluntario"]);
                objDadosBancarios.Funcionario_CodigoFuncionario = Convert.ToInt32(leitorDados["Funcionario_CodigoFuncionario"]);
                objDadosBancarios.Agencia = leitorDados["Agencia"].ToString();
                objDadosBancarios.ContaBancaria = leitorDados["ContaBancaria"].ToString();
                objDadosBancarios.Banco = leitorDados["Banco"].ToString();
                
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objDadosBancarios;
        }

        /// <summary>
        /// Exclui um DadoBancario pelo seu código
        /// </summary>
        public bool ExcluirDadosBancarios(int codigoDadosBancarios)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from DadosBancarios where CodigoDadosBancarios = @codigoDadosBancarios", base.Conectar());

            SqlParameter parametroCodigoDadosBancarios = new SqlParameter("@codigoDadosBancarios", codigoDadosBancarios);
            parametroCodigoDadosBancarios.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoDadosBancarios);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;

        }
    }
}