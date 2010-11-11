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
                    @"INSERT INTO Procedimentos (CodigoAssistido, TipoProcedimento, Procedimento, Descricao, StatusProcedimento,
                                  PessoaAtendente, DataMarcada, DataRealizada, LaudoAtendente)
                    VALUES (@codigoAssistido, @tipoProcedimento, @procedimento, @descricao, @statusProcedimento, @pessoaAtendente,
                           @dataMarcada,@dataRealizada, @laudoAtendente)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Procedimentos SET CodigoAssistido = @codigoAssistido, TipoProcedimento = @tipoProcedimento,
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

            SqlParameter parametroLaudoAtendente = new SqlParameter("@laudoAtendente", objProcedimentos.LaudoAtendente);
            parametroLaudoAtendente.DbType = System.Data.DbType.String;

            SqlParameter parametroDataMarcada = new SqlParameter();
            if (objProcedimentos.DataMarcada.HasValue)
            {
                parametroDataMarcada.Value = objProcedimentos.DataMarcada.Value;
                parametroDataMarcada.ParameterName = "@dataMarcada";
                parametroDataMarcada.DbType = System.Data.DbType.DateTime;
            }
            else
            {
                parametroDataMarcada.Value = DBNull.Value;
                parametroDataMarcada.ParameterName = "@dataMarcada";
                parametroDataMarcada.DbType = System.Data.DbType.DateTime;
            }

            SqlParameter parametroDataRealizada = new SqlParameter();
            if (objProcedimentos.DataRealizada.HasValue)
            {
                parametroDataRealizada.Value = objProcedimentos.DataRealizada.Value;
                parametroDataRealizada.ParameterName = "@dataRealizada";
                parametroDataRealizada.DbType = System.Data.DbType.DateTime;
            }
            else
            {
                parametroDataRealizada.Value = DBNull.Value;
                parametroDataRealizada.ParameterName = "@dataRealizada";
                parametroDataRealizada.DbType = System.Data.DbType.DateTime;
            }


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
            SqlCommand comando = new SqlCommand("select * from Procedimentos where CodigoProcedimento = @codigoProcedimento", base.Conectar());
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
                objProcedimentos.LaudoAtendente = leitorDados["LaudoAtendente"].ToString();

                if (leitorDados["DataMarcada"] != DBNull.Value)
                    objProcedimentos.DataMarcada = Convert.ToDateTime(leitorDados["DataMarcada"]);

                if (leitorDados["DataRealizada"] != DBNull.Value)
                    objProcedimentos.DataRealizada = Convert.ToDateTime(leitorDados["DataRealizada"]);

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
            SqlCommand comando = new SqlCommand(@"SELECT TOP (1) * FROM Procedimentos ORDER BY CodigoProcedimento DESC", base.Conectar());
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
                objProcedimentos.LaudoAtendente = leitorDados["LaudoAtendente"].ToString();

                if (leitorDados["DataMarcada"] != DBNull.Value)
                    objProcedimentos.DataMarcada = Convert.ToDateTime(leitorDados["DataMarcada"]);

                if (leitorDados["DataRealizada"] != DBNull.Value)
                    objProcedimentos.DataRealizada = Convert.ToDateTime(leitorDados["DataRealizada"]);



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

            SqlCommand comando = new SqlCommand("delete from Procedimentos where CodigoProcedimento = @codigoProcedimento", base.Conectar());

            SqlParameter parametroCodigoProcedimento = new SqlParameter("@codigoProcedimento", codigoProcedimento);
            parametroCodigoProcedimento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoProcedimento);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

        public List<Procedimentos> ConsultarProcedimentos(ProcedimentosDTO objProcedimentosDTO)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            SqlDataReader leitorDados;

            SqlParameter paramAssistidoValor = new SqlParameter("@assistidoValor", System.Data.SqlDbType.Int);
            if (objProcedimentosDTO.AssistidoValor.HasValue)
                paramAssistidoValor.Value = objProcedimentosDTO.AssistidoValor.Value;
            else
                paramAssistidoValor.Value = DBNull.Value;

            SqlParameter paramDataMarcadaValor = new SqlParameter("@dataMarcadaValor", System.Data.SqlDbType.DateTime);
            if (objProcedimentosDTO.DataMarcadaValor.HasValue)
                paramDataMarcadaValor.Value = objProcedimentosDTO.DataMarcadaValor.Value;
            else
                paramDataMarcadaValor.Value = DBNull.Value;

            SqlParameter paramDataRealizadaValor = new SqlParameter("@dataRealizadaValor", System.Data.SqlDbType.DateTime);
            if (objProcedimentosDTO.DataRealizadaValor.HasValue)
                paramDataRealizadaValor.Value = objProcedimentosDTO.DataRealizadaValor.Value;
            else
                paramDataRealizadaValor.Value = DBNull.Value;


            String sql = "select * from Procedimentos";

            //Se o Assistido, Data Marcada e Data Realizada preenchidos
            if (objProcedimentosDTO.AssistidoValor.HasValue && objProcedimentosDTO.DataMarcadaValor.HasValue && objProcedimentosDTO.DataRealizadaValor.HasValue)
                sql += @" where CodigoAssistido = @assistidoValor and DataMarcada = @dataMarcadaValor and DataRealizada = @dataRealizadaValor";

            //Se apenas Assistido  e Data Marcada preenchidos
            else if (objProcedimentosDTO.AssistidoValor.HasValue && objProcedimentosDTO.DataMarcadaValor.HasValue)
                sql += @" where CodigoAssistido = @assistidoValor and DataMarcadaValor = @dataMarcadaValor";

            //Se apenas Data Marcada e Data Realizada preenchidos
            else if (objProcedimentosDTO.DataMarcadaValor.HasValue && objProcedimentosDTO.DataRealizadaValor.HasValue)
                sql += @" where DataMarcada = @dataMarcadaValor and DataRealizada = @dataRealizadaValor";

            //Se apenas Data Realizada e Assistidos preenchidos
            else if (objProcedimentosDTO.DataRealizadaValor.HasValue && objProcedimentosDTO.AssistidoValor.HasValue)
                sql += @" where DataRealizada = @dataRealizadaValor and CodigoAssistido = @assistidoValor";

            //Se apenas Data Realizada preenchido
            else if (objProcedimentosDTO.DataRealizadaValor.HasValue)
                sql += @" where DataRealizada = @dataRealizadaValor";

            //Se apenas Assistido preenchido
            else if (objProcedimentosDTO.AssistidoValor.HasValue)
                sql += @" where CodigoAssistido = @assistidoValor";

            //Se apenas Data Marcada
            else if (objProcedimentosDTO.DataMarcadaValor.HasValue)
                sql += @" where DataMarcada = @dataMarcadaValor";

            comando.CommandText = sql;
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.Add(paramAssistidoValor);
            comando.Parameters.Add(paramDataMarcadaValor);
            comando.Parameters.Add(paramDataRealizadaValor);

            leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



            List<Procedimentos> procedimentosLista = new List<Procedimentos>();
            Procedimentos objProcedimentos;

            while (leitorDados.Read())
            {
                objProcedimentos = new Procedimentos();

                objProcedimentos.CodigoProcedimento = Convert.ToInt32(leitorDados["CodigoProcedimento"]);
                objProcedimentos.CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                objProcedimentos.TipoProcedimento = leitorDados["TipoProcedimento"].ToString();
                objProcedimentos.Procedimento = leitorDados["Procedimento"].ToString();
                objProcedimentos.Descricao = leitorDados["Descricao"].ToString();
                objProcedimentos.StatusProcedimento = leitorDados["StatusProcedimento"].ToString();
                objProcedimentos.PessoaAtendente = leitorDados["PessoaAtendente"].ToString();
                objProcedimentos.LaudoAtendente = leitorDados["LaudoAtendente"].ToString();


                procedimentosLista.Add(objProcedimentos);
            }

            return procedimentosLista;
        }
            

    }
}