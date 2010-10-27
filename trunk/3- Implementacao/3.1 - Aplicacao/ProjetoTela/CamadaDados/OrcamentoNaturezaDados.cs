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
        /// <summary>
        /// Este método salva a OrcamentoNatureza.
        /// </summary>
        /// <param name="objOrcamentoNatureza"></param>
        /// <returns></returns>
        public OrcamentoNatureza Salvar(OrcamentoNatureza objOrcamentoNatureza)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objOrcamentoNatureza.CodigoNatureza.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO OrcamentoNatureza (CodigoNatureza, CodigoOrcamento, Valor, DataCriacao)
                    VALUES (@codigoNatureza, @codigoOrcamentoo, @valor, @dataCriacao)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE OrcamentoNatureza SET CodigoOrcamento = @codigoOrcamento, Valor = @valor, DataCriacao = @dataCriacao
                      WHERE (CodigoNatureza = @codigoNatureza)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objOrcamentoNatureza.CodigoNatureza.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoNatureza", objOrcamentoNatureza.CodigoNatureza.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }


            SqlParameter parametroValor = new SqlParameter("@valor", objOrcamentoNatureza.Valor);
            parametroValor.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroDataCriacao = new SqlParameter("@dataCriacao", objOrcamentoNatureza.DataCriacao);
            parametroDataCriacao.DbType = System.Data.DbType.Decimal;

            comando.Parameters.Add(parametroValor);
            comando.Parameters.Add(parametroDataCriacao);

            comando.ExecuteNonQuery();

            //TODO: retorno entidade OrcamentoNatureza com o Código Preenchido
            return objOrcamentoNatureza;
        }

        /// <summary>
        /// Obtém as Naturezas de Lancamento  pelo Código da entidade.
        /// </summary>
        /// <param name="codigoNatureza"></param>
        /// <returns></returns>
        public OrcamentoNatureza ObterOrcamentoNatureza(int codigoNatureza) 
        {
            SqlCommand comando = new SqlCommand("select * from OrcamentoNatureza where CodigoNatureza = @codigoNatureza", base.Conectar());
            SqlParameter parametroCodigoNatureza = new SqlParameter("@codigoNatureza", codigoNatureza);
            parametroCodigoNatureza.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoNatureza);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            OrcamentoNatureza objOrcamentoNatureza = null;

            if (leitorDados.Read())
            {
                objOrcamentoNatureza = new OrcamentoNatureza();

                objOrcamentoNatureza.CodigoNatureza = codigoNatureza;
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
        public bool ExcluirOrcamentoNatureza(int codigoNatureza)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from OrcamentoNatureza where CodigoNatureza = @codigoNatureza", base.Conectar());

            SqlParameter parametroCodigoNatureza = new SqlParameter("@codigoNatureza", codigoNatureza);
            parametroCodigoNatureza.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoNatureza);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;

        }
    }
}