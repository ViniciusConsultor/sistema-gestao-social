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


            if (!objProcedimentos.CodigoProcedimentos.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Procedimentos (Assistido_CodigoAssistido, TipoProcedimento, Procedimento, Descricao, StatusProcedimento,
                                  PessoaAtendente, DataMarcada, DataRealizada, LaudoAtendente)
                    VALUES (@assistido_CodigoAssistido, @tipoProcedimento, @procedimento, @descricao, @statusProcedimento, @pessoaAtendente,
                           @dataMarcada,@dataRealizada, @laudoAtendente)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Procedimentos SET Assistido_CodigoAssistido = @sssistido_CodigoAssistido, TipoProcedimento = @tipoProcedimento,
                             Procedimento = @procedimento, Descricao = @descricao, StatusProcedimento = @statusProcedimento,
                             PessoaAtendente = @pessoaAtendente, DataMarcada = @dataMarcada, DataRealizada = @dataRealizada,
                             LaudoAtendente = @laudoAtendente)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objProcedimentos.CodigoProcedimentos.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoProcedimentos", objProcedimentos.CodigoProcedimentos.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroAssistido_CodigoAssistido = new SqlParameter();
            if (objProcedimentos.Assistido_CodigoAssistido.HasValue)
            {
                parametroAssistido_CodigoAssistido.Value = objProcedimentos.Assistido_CodigoAssistido.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroAssistido_CodigoAssistido.Value = DBNull.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
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



            comando.Parameters.Add(parametroAssistido_CodigoAssistido);
            comando.Parameters.Add(parametroTipoProcedimento);
            comando.Parameters.Add(parametroProcedimento);
            comando.Parameters.Add(parametroDescricao);
            comando.Parameters.Add(parametroStatusProcedimento);
            comando.Parameters.Add(parametroPessoaAtendente);
            comando.Parameters.Add(parametroDataMarcada);
            comando.Parameters.Add(parametroDataRealizada);
            comando.Parameters.Add(parametroLaudoAtendente);


            comando.ExecuteNonQuery();

            //TODO: retorno entidade Procedimentos com o Código do Procedimentos Preenchido
            return objProcedimentos;
        }

        /// <summary>
        /// Obtém o Procedimentos pelo Código do Procedimentos
        /// </summary>
        /// <param name="codigoProcedimentos"></param>
        /// <returns></returns>
        public Procedimentos ObterProcedimentos(int codigoProcedimentos)
        {
            SqlCommand comando = new SqlCommand("select * from Procedimentos where CodigoProcedimentos = @codigoProcedimentos", base.Conectar());
            SqlParameter parametroCodigoProcedimentos = new SqlParameter("@codigoProcedimentos", codigoProcedimentos);
            parametroCodigoProcedimentos.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoProcedimentos);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Procedimentos objProcedimentos = null;

            if (leitorDados.Read())
            {
                objProcedimentos = new Procedimentos();

                objProcedimentos.CodigoProcedimentos = codigoProcedimentos;
                objProcedimentos.Assistido_CodigoAssistido = Convert.ToInt32(leitorDados["Assistido_CodigoAssistido"]);
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
        /// Exclui um Procedimentos pelo seu código
        /// </summary>
        public bool ExcluirProcedimentos(int codigoProcedimentos)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Procedimentos where CodigoProcedimentos = @codigoProcedimentos", base.Conectar());

            SqlParameter parametroCodigoProcedimentos = new SqlParameter("@codigoProcedimentos", codigoProcedimentos);
            parametroCodigoProcedimentos.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoProcedimentos);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

    }
}