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
                    @"INSERT INTO Procedimentos (CodigoAssistido, TipoProcedimento, Descricao, StatusProcedimento,
                                  PessoaAtendente, DataMarcada, LaudoAtendente)
                    VALUES (@codigoAssistido, @tipoProcedimento, @descricao, @statusProcedimento, @pessoaAtendente,
                           @dataMarcada, @laudoAtendente)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Procedimentos SET CodigoAssistido = @codigoAssistido, TipoProcedimento = @tipoProcedimento,
                             Descricao = @descricao, StatusProcedimento = @statusProcedimento,
                             PessoaAtendente = @pessoaAtendente, DataMarcada = @dataMarcada, LaudoAtendente = @laudoAtendente
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

            SqlParameter parametroDescricao = new SqlParameter("@descricao", objProcedimentos.Descricao);
            parametroDescricao.DbType = System.Data.DbType.String;

            SqlParameter parametroStatusProcedimento = new SqlParameter("@statusProcedimento", objProcedimentos.StatusProcedimento);
            parametroStatusProcedimento.DbType = System.Data.DbType.String;

            SqlParameter parametroPessoaAtendente = new SqlParameter("@pessoaAtendente", objProcedimentos.PessoaAtendente);
            if (!String.IsNullOrEmpty(objProcedimentos.PessoaAtendente))
                parametroPessoaAtendente.Value = objProcedimentos.PessoaAtendente;
            else
                parametroPessoaAtendente.Value = DBNull.Value;

            SqlParameter parametroLaudoAtendente = new SqlParameter("@laudoAtendente", objProcedimentos.LaudoAtendente);
            if (!String.IsNullOrEmpty(objProcedimentos.LaudoAtendente))
                parametroLaudoAtendente.Value = objProcedimentos.LaudoAtendente;
            else
                parametroLaudoAtendente.Value = DBNull.Value;

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

            comando.Parameters.Add(parametroCodigoAssistido);
            comando.Parameters.Add(parametroTipoProcedimento);
            comando.Parameters.Add(parametroDescricao);
            comando.Parameters.Add(parametroStatusProcedimento);
            comando.Parameters.Add(parametroPessoaAtendente);
            comando.Parameters.Add(parametroDataMarcada);
            comando.Parameters.Add(parametroLaudoAtendente);

            comando.ExecuteNonQuery();

            if(!objProcedimentos.CodigoProcedimento.HasValue)
            {
                return ObterUltimo();
            }
            else
            {
                return objProcedimentos;
            }
        }

        /// <summary>
        /// Obtém o Procedimentos pelo Código do Procedimento
        /// </summary>
        /// <param name="codigoProcedimento"></param>
        /// <returns></returns>
        public Procedimentos Obter(int codigoProcedimento)
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
                objProcedimentos.Descricao = leitorDados["Descricao"].ToString();
                objProcedimentos.StatusProcedimento = leitorDados["StatusProcedimento"].ToString();
                objProcedimentos.PessoaAtendente = leitorDados["PessoaAtendente"].ToString();
                objProcedimentos.LaudoAtendente = leitorDados["LaudoAtendente"].ToString();

                if (leitorDados["DataMarcada"] != DBNull.Value)
                    objProcedimentos.DataMarcada = Convert.ToDateTime(leitorDados["DataMarcada"]);

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objProcedimentos;
        }

        /// <summary>
        /// Obter o ultimo procedimento inserido na tabela
        /// </summary>
        /// <returns></returns>
        public Procedimentos ObterUltimo()
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
                objProcedimentos.Descricao = leitorDados["Descricao"].ToString();
                objProcedimentos.StatusProcedimento = leitorDados["StatusProcedimento"].ToString();
                objProcedimentos.PessoaAtendente = leitorDados["PessoaAtendente"].ToString();
                objProcedimentos.LaudoAtendente = leitorDados["LaudoAtendente"].ToString();

                if (leitorDados["DataMarcada"] != DBNull.Value)
                    objProcedimentos.DataMarcada = Convert.ToDateTime(leitorDados["DataMarcada"]);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objProcedimentos;
        }

        /// <summary>
        /// Exclui um Procedimento pelo seu código
        /// </summary>
        public bool Excluir(int codigoProcedimento)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Procedimentos where CodigoProcedimento = @codigoProcedimento", base.Conectar());

            SqlParameter parametroCodigoProcedimento = new SqlParameter("@codigoProcedimento", codigoProcedimento);
            parametroCodigoProcedimento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoProcedimento);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

        /// <summary>
        /// Retorna uma lista de ProcedimentosAssistidoDTO conforme o Filtro
        /// </summary>
        /// <param name="objProcedimentosDTO"></param>
        /// <returns></returns>
        public List<ProcedimentosAssistidoDTO> Consultar(ProcedimentosDTO objProcedimentosDTO)
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


            String sql = "select * from Procedimentos PR inner join Pessoa P on P.CodigoPessoa = PR.CodigoAssistido";

            //Se apenas Assistido  e Data Marcada preenchidos
            if (objProcedimentosDTO.AssistidoValor.HasValue && objProcedimentosDTO.DataMarcadaValor.HasValue)
                sql += @" where CodigoAssistido = @assistidoValor and DataMarcada = @dataMarcadaValor";

            //Se apenas Assistido preenchido
            else if (objProcedimentosDTO.AssistidoValor.HasValue)
                sql += @" where CodigoAssistido = @assistidoValor";

            //Se apenas Data Marcada
            else if (objProcedimentosDTO.DataMarcadaValor.HasValue)
                sql += @" where DataMarcada = @dataMarcadaValor";

            if (sql.Contains("where"))
                sql += " and P.Ativo = 1";
            else
                sql += " where P.Ativo = 1";

            comando.CommandText = sql;
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.Add(paramAssistidoValor);
            comando.Parameters.Add(paramDataMarcadaValor);

            leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



            List<ProcedimentosAssistidoDTO> procedimentosAssistidoDTOLista = new List<ProcedimentosAssistidoDTO>();
            ProcedimentosAssistidoDTO objProcedimentosAssistidoDTO;

            while (leitorDados.Read())
            {
                objProcedimentosAssistidoDTO = new ProcedimentosAssistidoDTO();

                objProcedimentosAssistidoDTO.NomeAssistido = leitorDados["Nome"].ToString();
                objProcedimentosAssistidoDTO.CodigoProcedimento = Convert.ToInt32(leitorDados["CodigoProcedimento"]);
                objProcedimentosAssistidoDTO.CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                objProcedimentosAssistidoDTO.TipoProcedimento = leitorDados["TipoProcedimento"].ToString();
                objProcedimentosAssistidoDTO.Descricao = leitorDados["Descricao"].ToString();
                objProcedimentosAssistidoDTO.StatusProcedimento = leitorDados["StatusProcedimento"].ToString();
                objProcedimentosAssistidoDTO.PessoaAtendente = leitorDados["PessoaAtendente"].ToString();
                objProcedimentosAssistidoDTO.LaudoAtendente = leitorDados["LaudoAtendente"].ToString();

                if (leitorDados["DataMarcada"] != DBNull.Value)
                    objProcedimentosAssistidoDTO.DataMarcada = Convert.ToDateTime(leitorDados["DataMarcada"]);

                procedimentosAssistidoDTOLista.Add(objProcedimentosAssistidoDTO);
            }

            return procedimentosAssistidoDTOLista;
        }

    }
}