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
    public class ProcedimentosDados : BaseConnection
    {

        public Procedimentos Salvar(Procedimentos objProcedimentos)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objProcedimentos.CodigoProcedimento.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Procedimento (CodigoAssistido, TipoProcedimento, Procedimento, Descricao, StatusProcedimento,
                                  PessoaAtendente, DataMarcada, DataRealizada, LaudoAtendente)
                    VALUES (@codigoAssistido, @tipoProcedimento, @procedimento, @descricao, @statusProcedimento, @pessoaAtendente,
                           @dataMarcada,@dataRealizada, @laudoAtendente)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Procedimento SET CodigoAssistido = @codigoAssistido, TipoProcedimento = @tipoProcedimento,
                             Procedimento = @procedimento, Descricao = @descricao, StatusProcedimento = @statusProcedimento,
                             PessoaAtendente = @pessoaAtendente, DataMarcada = @dataMarcada, DataRealizada = @dataRealizada,
                             LaudoAtendente = @laudoAtendente
                    WHERE (CodigoProcedimento = @codigoProcedimento)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objProcedimentos.CodigoProcedimento.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoProcedimento", objProcedimentos.CodigoProcedimento.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroCodigoAssistido = new SqlParameter();
            if (objProcedimentos.CodigoAssistido.HasValue)
            {
                parametroCodigoAssistido.Value = objProcedimentos.CodigoAssistido.Value;
                parametroCodigoAssistido.ParameterName = "@codigoAssistido";
                parametroCodigoAssistido.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroCodigoAssistido.Value = DBNull.Value;
                parametroCodigoAssistido.ParameterName = "@codigoAssistido";
                parametroCodigoAssistido.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroTipoProcedimento = new SqlParameter("@tipoProcedimento", objProcedimentos.TipoProcedimento);
            parametroTipoProcedimento.DbType = System.Data.DbType.String;

            SqlParameter parametroProcedimento = new SqlParameter("@procedimento", objProcedimentos.Procedimento);
            parametroProcedimento.DbType = System.Data.DbType.String;

            SqlParameter parametroDescricao = new SqlParameter("@descricao", objProcedimentos.Descricao);
            parametroDescricao.DbType = System.Data.DbType.String;

            SqlParameter parametroStatusProcedimento = new SqlParameter("@statusProcedimento", objProcedimentos.StatusProcedimento);
            parametroStatusProcedimento.DbType = System.Data.DbType.String;

            SqlParameter parametroPessoaAtendente = new SqlParameter("@pessoaAtendente", objProcedimentos.PessoaAtendente);
            parametroPessoaAtendente.DbType = System.Data.DbType.String;

            SqlParameter parametroDataMarcada = new SqlParameter("@dataMarcada", objProcedimentos.DataMarcada);
            parametroDataMarcada.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroDataRealizada = new SqlParameter("@dataRealizada", objProcedimentos.DataRealizada);
            parametroDataRealizada.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroLaudoAtendente = new SqlParameter("@laudoAtendente", objProcedimentos.LaudoAtendente);
            parametroLaudoAtendente.DbType = System.Data.DbType.String;



            comando.Parameters.Add(parametroCodigoAssistido);
            comando.Parameters.Add(parametroTipoProcedimento);
            comando.Parameters.Add(parametroProcedimento);
            comando.Parameters.Add(parametroDescricao);
            comando.Parameters.Add(parametroStatusProcedimento);
            comando.Parameters.Add(parametroPessoaAtendente);
            comando.Parameters.Add(parametroDataMarcada);
            comando.Parameters.Add(parametroDataRealizada);
            comando.Parameters.Add(parametroLaudoAtendente);


            comando.ExecuteNonQuery();


            return ObterUltimoProcedimentoInserido();
        }

        /// <summary>
        /// Obtém o Procedimentos pelo Código do Procedimento
        /// </summary>
        /// <param name="codigoProcedimento"></param>
        /// <returns></returns>
        public Procedimentos ObterProcedimentos(int codigoProcedimento)
        {
            SqlCommand comando = new SqlCommand("select * from Procedimento where CodigoProcedimento = @codigoProcedimento", base.Conectar());
            SqlParameter parametroCodigoProcedimento = new SqlParameter("@codigoProcedimento", codigoProcedimento);
            parametroCodigoProcedimento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoProcedimento);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Procedimentos objProcedimentos = null;

            if (leitorDados.Read())
            {
                objProcedimentos = new Procedimentos();

                objProcedimentos.CodigoProcedimento = codigoProcedimento;
                objProcedimentos.CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                objProcedimentos.TipoProcedimento = leitorDados["TipoProcedimento"].ToString();
                objProcedimentos.Procedimento = leitorDados["Procedimento"].ToString();
                objProcedimentos.Descricao = leitorDados["Descricao"].ToString();
                objProcedimentos.StatusProcedimento = leitorDados["StatusProcedimento"].ToString();
                objProcedimentos.PessoaAtendente = leitorDados["PessoaAtendente"].ToString();
                objProcedimentos.DataMarcada = Convert.ToDateTime(leitorDados["DataMarcada"]);
                objProcedimentos.DataRealizada = Convert.ToDateTime(leitorDados["DataRealizada"]);
                objProcedimentos.LaudoAtendente = leitorDados["LaudoAtendente"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objProcedimentos;
        }

        /// <summary>
        /// Obter o ultimo procedimento inserido na tabela
        /// </summary>
        /// <returns></returns>
        public Procedimentos ObterUltimoProcedimentoInserido()
        {
            SqlCommand comando = new SqlCommand(@"SELECT TOP (1) * FROM Procedimento ORDER BY CodigoProcedimento DESC", base.Conectar());
            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Procedimentos objProcedimentos = null;

            if (leitorDados.Read())
            {
                objProcedimentos = new Procedimentos();

                objProcedimentos.CodigoProcedimento = Convert.ToInt32(leitorDados["CodigoProcedimento"]);
                objProcedimentos.CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                objProcedimentos.TipoProcedimento = leitorDados["TipoProcedimento"].ToString();
                objProcedimentos.Procedimento = leitorDados["Procedimento"].ToString();
                objProcedimentos.Descricao = leitorDados["Descricao"].ToString();
                objProcedimentos.StatusProcedimento = leitorDados["StatusProcedimento"].ToString();
                objProcedimentos.PessoaAtendente = leitorDados["PessoaAtendente"].ToString();
                objProcedimentos.DataMarcada = Convert.ToDateTime(leitorDados["DataMarcada"]);
                objProcedimentos.DataRealizada = Convert.ToDateTime(leitorDados["DataRealizada"]);
                objProcedimentos.LaudoAtendente = leitorDados["LaudoAtendente"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objProcedimentos;
        }

        /// <summary>
        /// Exclui um Procedimento pelo seu código
        /// </summary>
        public bool ExcluirProcedimentos(int codigoProcedimento)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Procedimento where CodigoProcedimento = @codigoProcedimento", base.Conectar());

            SqlParameter parametroCodigoProcedimento = new SqlParameter("@codigoProcedimento", codigoProcedimento);
            parametroCodigoProcedimento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoProcedimento);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

    }
}