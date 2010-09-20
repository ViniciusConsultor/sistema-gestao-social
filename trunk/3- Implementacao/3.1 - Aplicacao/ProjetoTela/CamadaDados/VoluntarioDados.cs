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
    public class VoluntarioDados : BaseConnection
    {

        public Voluntario Salvar(Voluntario objVoluntario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objVoluntario.CodigoVoluntario.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Voluntario (Pessoa_CodigoPessoa, MotivoVoluntariado, TempoDisponivel, Especialidades, GrauEscolaridade,
                                  CursoFormacao, Profissao, ExperienciaProfissional)
                    VALUES (@pessoa_CodigoPessoa, @motivoVoluntariado, @tempoDisponivel, @especialidades, @grauEscolaridade, @cursoFormacao,
                           @profissao, @experienciaProfissional)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Voluntario SET Pessoa_CodigoPessoa = @pessoa_CodigoPessoa, MotivoVoluntariado = @motivoVoluntariado,
                             TempoDisponivel = @tempoDisponivel, Especialidades = @especialidades, GrauEscolaridade = @grauEscolaridade,
                             CursoFormacao = @cursoFormacao, Profissao = @profissao, ExperienciaProfissional = @experienciaProfissional)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objVoluntario.CodigoVoluntario.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoVoluntario", objVoluntario.CodigoVoluntario.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroPessoa_CodigoPessoa = new SqlParameter();
            if (objVoluntario.Pessoa_CodigoPessoa.HasValue)
            {
                parametroPessoa_CodigoPessoa.Value = objVoluntario.Pessoa_CodigoPessoa.Value;
                parametroPessoa_CodigoPessoa.ParameterName = "@pessoa_CodigoPessoa";
                parametroPessoa_CodigoPessoa.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroPessoa_CodigoPessoa.Value = DBNull.Value;
                parametroPessoa_CodigoPessoa.ParameterName = "@pessoa_CodigoPessoa";
                parametroPessoa_CodigoPessoa.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroMotivoVoluntariado = new SqlParameter("@motivoVoluntariado", objVoluntario.MotivoVoluntariado);
            parametroMotivoVoluntariado.DbType = System.Data.DbType.String;

            SqlParameter parametroTempoDisponivel = new SqlParameter("@tempoDisponivel", objVoluntario.TempoDisponivel);
            parametroTempoDisponivel.DbType = System.Data.DbType.String;

            SqlParameter parametroEspecialidades = new SqlParameter("@especialidades", objVoluntario.Especialidades);
            parametroEspecialidades.DbType = System.Data.DbType.String;

            SqlParameter parametroProfissao = new SqlParameter("@profissao", objVoluntario.Profissao);
            parametroProfissao.DbType = System.Data.DbType.String;

            SqlParameter parametroGrauEscolaridade = new SqlParameter("@grauEscolaridade", objVoluntario.GrauEscolaridade);
            parametroGrauEscolaridade.DbType = System.Data.DbType.String;

            SqlParameter parametroCursoFormacao = new SqlParameter("@cursoFormacao", objVoluntario.CursoFormacao);
            parametroCursoFormacao.DbType = System.Data.DbType.String;

            SqlParameter parametroExperienciaProfissional = new SqlParameter("@experienciaProfissional", objVoluntario.ExperienciaProfissional);
            parametroExperienciaProfissional.DbType = System.Data.DbType.String;



            comando.Parameters.Add(parametroPessoa_CodigoPessoa);
            comando.Parameters.Add(parametroMotivoVoluntariado);
            comando.Parameters.Add(parametroTempoDisponivel);
            comando.Parameters.Add(parametroEspecialidades);
            comando.Parameters.Add(parametroGrauEscolaridade);
            comando.Parameters.Add(parametroProfissao);
            comando.Parameters.Add(parametroCursoFormacao);
            comando.Parameters.Add(parametroExperienciaProfissional);


            comando.ExecuteNonQuery();

            //TODO: retorno entidade Voluntario com o Código do Voluntario Preenchido
            return objVoluntario;
        }

        /// <summary>
        /// Obtém o Voluntario pelo Código do Voluntario
        /// </summary>
        /// <param name="codigoVoluntario"></param>
        /// <returns></returns>
        public Voluntario ObterVoluntario(int codigoVoluntario)
        {
            SqlCommand comando = new SqlCommand("select * from Voluntario where CodigoVoluntario = @codigoVoluntario", base.Conectar());
            SqlParameter parametroCodigoVoluntario = new SqlParameter("@codigoVoluntario", codigoVoluntario);
            parametroCodigoVoluntario.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoVoluntario);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Voluntario objVoluntario = null;

            if (leitorDados.Read())
            {
                objVoluntario = new Voluntario();

                objVoluntario.CodigoVoluntario = codigoVoluntario;
                objVoluntario.Pessoa_CodigoPessoa = Convert.ToInt32(leitorDados["Pessoa_CodigoPessoa"]);
                objVoluntario.MotivoVoluntariado = leitorDados["MotivoVoluntariado"].ToString();
                objVoluntario.TempoDisponivel = leitorDados["TempoDisponivel"].ToString();
                objVoluntario.Especialidades = leitorDados["Especialidades"].ToString();
                objVoluntario.GrauEscolaridade = leitorDados["GrauEscolaridade"].ToString();
                objVoluntario.CursoFormacao = leitorDados["CursoFormacao"].ToString();
                objVoluntario.Profissao = leitorDados["Profissao"].ToString();
                objVoluntario.ExperienciaProfissional = leitorDados["ExperienciaProfissional"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objVoluntario;
        }

        /// <summary>
        /// Exclui um Voluntario pelo seu código
        /// </summary>
        public bool ExcluirVoluntario(int codigoVoluntario)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Voluntario where CodigoVoluntario = @codigoVoluntario", base.Conectar());

            SqlParameter parametroCodigoVoluntario = new SqlParameter("@codigoVoluntario", codigoVoluntario);
            parametroCodigoVoluntario.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoVoluntario);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

    }
}