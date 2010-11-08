using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using SGS.Entidades;
using System.Data.SqlClient;
using SGS.Entidades.DTO;
using SGS.Componentes;

namespace SGS.CamadaDados
{
    public class OrcamentoNaturezaDados : BaseConnection
    {


        public bool ValidarOrcamentoNatureza(OrcamentoNatureza objOrcamentoNatureza)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            //TODO: Chamar método de validação


            comando.CommandText = @"SELECT * FROM OrcamentoNatureza 
                                    WHERE CodigoNatureza = @codigoNatureza and CodigoOrcamento = @codigoOrcamento";

            comando.CommandType = System.Data.CommandType.Text;

            SqlParameter parametroCodigoNatureza = new SqlParameter("@codigoNatureza", objOrcamentoNatureza.CodigoNatureza.Value);
            parametroCodigoNatureza.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoNatureza);

            SqlParameter parametroCodigoOrcamento = new SqlParameter("@codigoOrcamento", objOrcamentoNatureza.CodigoOrcamento.Value);
            parametroCodigoOrcamento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoOrcamento);


            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);


            if (leitorDados.Read())
            {
                leitorDados.Close();
                leitorDados.Dispose();
                return true;

            }
            else
            {
                leitorDados.Close();
                leitorDados.Dispose();
                return false;
            }

        }

        /// <summary>
        /// Este método salva a OrcamentoNatureza.
        /// </summary>
        /// <param name="objOrcamentoNatureza"></param>
        /// <returns></returns>
        public OrcamentoNatureza Salvar(OrcamentoNatureza objOrcamentoNatureza)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            bool orcamentoNaturezaCadastrado = ValidarOrcamentoNatureza(objOrcamentoNatureza);

            if (!orcamentoNaturezaCadastrado)
            {
                comando.CommandText =
                    @"INSERT INTO OrcamentoNatureza (CodigoNatureza, CodigoOrcamento, Valor, DataCriacao)
                    VALUES (@codigoNatureza, @codigoOrcamento, @valor, @dataCriacao)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE OrcamentoNatureza SET Valor = @valor, DataCriacao = @dataCriacao
                      WHERE (CodigoNatureza = @codigoNatureza and CodigoOrcamento = @codigoOrcamento)";
            }

            comando.CommandType = System.Data.CommandType.Text;

            SqlParameter parametroCodigoNatureza = new SqlParameter("@codigoNatureza", objOrcamentoNatureza.CodigoNatureza.Value);
            parametroCodigoNatureza.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoNatureza);

            SqlParameter parametroCodigoOrcamento = new SqlParameter("@codigoOrcamento", objOrcamentoNatureza.CodigoOrcamento.Value);
            parametroCodigoOrcamento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoOrcamento);
            
            SqlParameter parametroValor = new SqlParameter("@valor", objOrcamentoNatureza.Valor);
            parametroValor.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroDataCriacao = new SqlParameter("@dataCriacao", objOrcamentoNatureza.DataCriacao);
            parametroDataCriacao.DbType = System.Data.DbType.DateTime;

            comando.Parameters.Add(parametroValor);
            comando.Parameters.Add(parametroDataCriacao);

            comando.ExecuteNonQuery();

            return objOrcamentoNatureza;
        }

        /// <summary>
        /// Obtém as Naturezas de Lancamento  pelo Código da entidade.
        /// </summary>
        /// <param name="codigoNatureza"></param>
        /// <returns></returns>
        public OrcamentoNatureza ObterOrcamentoNatureza(int codigoNatureza, int codigoOrcamento)
        {
            SqlCommand comando = new SqlCommand("select * from OrcamentoNatureza where CodigoNatureza = @codigoNatureza and CodigoOrcamento = @codigoOrcamento", base.Conectar());
            SqlParameter parametroCodigoNatureza = new SqlParameter("@codigoNatureza", codigoNatureza);
            parametroCodigoNatureza.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoNatureza);

            SqlParameter parametroCodigoOrcamento = new SqlParameter("@codigoOrcamento", codigoOrcamento);
            parametroCodigoOrcamento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoOrcamento);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            OrcamentoNatureza objOrcamentoNatureza = null;

            if (leitorDados.Read())
            {
                objOrcamentoNatureza = new OrcamentoNatureza();

                objOrcamentoNatureza.CodigoNatureza = codigoNatureza;
                objOrcamentoNatureza.CodigoOrcamento = codigoOrcamento;
                objOrcamentoNatureza.Valor = Convert.ToDecimal(leitorDados["Valor"]);
                objOrcamentoNatureza.DataCriacao = Convert.ToDateTime(leitorDados["DataCriacao"]);

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objOrcamentoNatureza;
        }

        /// <summary>
        /// Exclui um DadoBancario pelo seu código
        /// </summary>
        public bool ExcluirOrcamentoNatureza(int codigoOrcamento, int codigoNatureza)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from OrcamentoNatureza where CodigoNatureza = @codigoNatureza and CodigoOrcamento = @codigoOrcamento", base.Conectar());

            SqlParameter parametroCodigoNatureza = new SqlParameter("@codigoNatureza", codigoNatureza);
            parametroCodigoNatureza.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoNatureza);

            SqlParameter parametroCodigoOrcamento = new SqlParameter("@codigoOrcamento", codigoOrcamento);
            parametroCodigoOrcamento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoOrcamento);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;

        }

        /// <summary>
        /// Retorna a lista de natureza de lancamento.
        /// </summary>
        /// <returns></returns>

        public List<OrcamentoNatureza> ListarOrcamentoNatureza()
        {
            SqlCommand comando = new SqlCommand("select * from OrcamentoNatureza ORDER BY CodigoOrcamento", base.Conectar());

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            List<OrcamentoNatureza> listOrcamento = new List<OrcamentoNatureza>();
            OrcamentoNatureza objOrcamentoNatureza = null;

            while (leitorDados.Read())
            {
                objOrcamentoNatureza = new OrcamentoNatureza();

                objOrcamentoNatureza.CodigoOrcamento = Convert.ToInt32(leitorDados["CodigoOrcamento"]);
                objOrcamentoNatureza.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
                objOrcamentoNatureza.Valor = Convert.ToDecimal(leitorDados["NomePlano"]);
                objOrcamentoNatureza.DataCriacao = Convert.ToDateTime(leitorDados["StatusPlano"]);

                listOrcamento.Add(objOrcamentoNatureza);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return listOrcamento;
        }
    }
}