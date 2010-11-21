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
    public class NaturezaLancamentoDados : BaseConnection
    {
        /// <summary>
        /// Este método salva a NaturezaLancamento.
        /// </summary>
        /// <param name="objNaturezaLancamento"></param>
        /// <returns></returns>
        public NaturezaLancamento Salvar(NaturezaLancamento objNaturezaLancamento)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objNaturezaLancamento.CodigoNatureza.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO NaturezaLancamento (NomeNatureza)
                    VALUES (@nomeNatureza)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE NaturezaLancamento SET NomeNatureza = @nomeNatureza
                      WHERE (CodigoNatureza = @codigoNatureza)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objNaturezaLancamento.CodigoNatureza.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoNatureza", objNaturezaLancamento.CodigoNatureza.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

           
            SqlParameter parametroNomeNatureza = new SqlParameter("@nomeNatureza", objNaturezaLancamento.NomeNatureza);
            parametroNomeNatureza.DbType = System.Data.DbType.String;

            comando.Parameters.Add(parametroNomeNatureza);

            comando.ExecuteNonQuery();

            //TODO: retorno entidade NaturezaLancamento com o Código Preenchido
            return objNaturezaLancamento;
        }

        /// <summary>
        /// Obtém as Naturezas de Lancamento  pelo Código da entidade.
        /// </summary>
        /// <param name="codigoNatureza"></param>
        /// <returns></returns>
        public NaturezaLancamento Obter(int codigoNatureza)
        {
            SqlCommand comando = new SqlCommand("select * from NaturezaLancamento where CodigoNatureza = @codigoNatureza", base.Conectar());
            SqlParameter parametroCodigoNatureza = new SqlParameter("@codigoNatureza", codigoNatureza);
            parametroCodigoNatureza.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoNatureza);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            NaturezaLancamento objNaturezaLancamento = null;

            if (leitorDados.Read())
            {
                objNaturezaLancamento = new NaturezaLancamento();

                objNaturezaLancamento.CodigoNatureza = codigoNatureza;
                objNaturezaLancamento.NomeNatureza = leitorDados["NomeNatureza"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objNaturezaLancamento;
        }

        /// <summary>
        /// Exclui um DadoBancario pelo seu código
        /// </summary>
        public bool Excluir(int codigoNatureza)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from NaturezaLancamento where CodigoNatureza = @codigoNatureza", base.Conectar());

            SqlParameter parametroCodigoNatureza = new SqlParameter("@codigoNatureza", codigoNatureza);
            parametroCodigoNatureza.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoNatureza);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;

        }

        /// <summary>
        /// Retorna a lista de natureza de lancamento.
        /// </summary>
        /// <returns></returns>

        public List<NaturezaLancamento> Listar()
        {
            SqlCommand comando = new SqlCommand("select * from NaturezaLancamento ORDER BY NomeNatureza", base.Conectar());

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            List<NaturezaLancamento> listNaturezaLancamento = new List<NaturezaLancamento> ();
            NaturezaLancamento objNaturezaLancamento = null;

            while (leitorDados.Read())
            {
                objNaturezaLancamento = new NaturezaLancamento();

                objNaturezaLancamento.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
                objNaturezaLancamento.NomeNatureza = leitorDados["NomeNatureza"].ToString();
                
                listNaturezaLancamento.Add(objNaturezaLancamento);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return listNaturezaLancamento;
        }
    }
}