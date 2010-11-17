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
        /// Valida se um OrcamentoNatureza já está cadastrado
        /// </summary>
        /// <param name="objOrcamentoNatureza"></param>
        /// <returns></returns>
        public bool ValidarOrcamentoNatureza(OrcamentoNatureza objOrcamentoNatureza)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

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
        public bool Excluir(int codigoOrcamento, int codigoNatureza)
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
        /// Exclui um OrcamentoNatureza pelo código do orçamento
        /// </summary>
        public bool ExcluirPorCodigoOrcamento(int codigoOrcamento)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from OrcamentoNatureza where CodigoOrcamento = @codigoOrcamento", base.Conectar());

            SqlParameter parametroCodigoOrcamento = new SqlParameter("@codigoOrcamento", codigoOrcamento);
            parametroCodigoOrcamento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoOrcamento);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

        /// <summary>
        /// Retorna a lista de OrcamentoNatureza.
        /// </summary>
        /// <returns></returns>
        public List<OrcamentoNatureza> Listar()
        {
            SqlCommand comando = new SqlCommand("select * from OrcamentoNatureza ORDER BY NomePlano", base.Conectar());

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            List<OrcamentoNatureza> listOrcamento = new List<OrcamentoNatureza>();
            OrcamentoNatureza objOrcamentoNatureza = null;

            while (leitorDados.Read())
            {
                objOrcamentoNatureza = new OrcamentoNatureza();

                objOrcamentoNatureza.CodigoOrcamento = Convert.ToInt32(leitorDados["CodigoOrcamento"]);
                objOrcamentoNatureza.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
                objOrcamentoNatureza.Valor = Convert.ToDecimal(leitorDados["Valor"]);
                objOrcamentoNatureza.DataCriacao = Convert.ToDateTime(leitorDados["DataCriacao"]);

                listOrcamento.Add(objOrcamentoNatureza);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return listOrcamento;
        }

        /// <summary>
        /// Lista por código do orçamento
        /// </summary>
        /// <param name="codigoOrcamento"></param>
        public List<OrcamentoNatureza> ListarPorCodigoOrcamento(int codigoOrcamento)
        {
            string sql = @"SELECT OrcNat.CodigoNatureza, NL.NomeNatureza, OrcNat.CodigoOrcamento, OrcNat.Valor AS ValorOrcamento, SUM(F.Valor) AS BalancoFinancas, 
                     OrcNat.Valor + SUM(F.Valor) AS SaldoOrcamento
              FROM OrcamentoNatureza AS OrcNat 
                         INNER JOIN Financas AS F ON F.CodigoNatureza = OrcNat.CodigoNatureza 
                         INNER JOIN NaturezaLancamento AS NL ON NL.CodigoNatureza = OrcNat.CodigoNatureza 
                         INNER JOIN Orcamento AS O ON O.CodigoOrcamento = OrcNat.CodigoOrcamento
              WHERE        (F.DataLancamento BETWEEN O.InicioVigencia AND O.FimVigencia) and O.CodigoOrcamento = @codigoOrcamento
              GROUP BY NL.NomeNatureza, OrcNat.CodigoOrcamento, OrcNat.CodigoNatureza, OrcNat.Valor";

            SqlCommand comando = new SqlCommand(sql, base.Conectar());
            SqlParameter paramentoCodigoOrcamento = new SqlParameter("@codigoOrcamento", System.Data.DbType.Int32);
            paramentoCodigoOrcamento.Value = codigoOrcamento;
            comando.Parameters.Add(paramentoCodigoOrcamento);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            List<OrcamentoNatureza> listOrcamento = new List<OrcamentoNatureza>();
            OrcamentoNatureza objOrcamentoNatureza = null;

            while (leitorDados.Read())
            {
                objOrcamentoNatureza = new OrcamentoNatureza();

                objOrcamentoNatureza.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
                objOrcamentoNatureza.NomeNatureza = leitorDados["NomeNatureza"].ToString();
                objOrcamentoNatureza.CodigoOrcamento = Convert.ToInt32(leitorDados["CodigoOrcamento"]);
                objOrcamentoNatureza.Valor = Convert.ToDecimal(leitorDados["ValorOrcamento"]);
                objOrcamentoNatureza.BalancoFinancas = Convert.ToDecimal(leitorDados["BalancoFinancas"]);
                objOrcamentoNatureza.SaldoOrcamento = Convert.ToDecimal(leitorDados["SaldoOrcamento"]);

                listOrcamento.Add(objOrcamentoNatureza);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return listOrcamento;
        }

    }
}