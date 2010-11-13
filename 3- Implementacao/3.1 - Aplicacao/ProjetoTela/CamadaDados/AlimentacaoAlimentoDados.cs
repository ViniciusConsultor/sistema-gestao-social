using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;
using System.Data.SqlClient;
using SGS.Entidades.DTO;
using SGS.Entidades.Adaptador;

namespace SGS.CamadaDados
{
    public class AlimentacaoAlimentoDados : BaseConnection
    {

        /// <summary>
        /// Cadastra um AlimentacaoAlimento
        /// </summary>
        /// <param name="objAlimentacaoAlimento"></param>
        /// <returns></returns>
        public AlimentacaoAlimento Salvar(AlimentacaoAlimento objAlimentacaoAlimento)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            comando.CommandText =
                    @"INSERT INTO AlimentacaoAlimento  (CodigoAlimentacao, CodigoAlimento)
                     VALUES ( @codigoAlimentacao, @codigoAlimento)";  

            comando.CommandType = System.Data.CommandType.Text;
           
            SqlParameter parametroCodigoAlimentacao = new SqlParameter("@codigoAlimentacao", objAlimentacaoAlimento.CodigoAlimentacao.Value);
            parametroCodigoAlimentacao.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAlimentacao);

            SqlParameter parametroCodigoAlimento = new SqlParameter("@codigoAlimento", objAlimentacaoAlimento.CodigoAlimento.Value);
            parametroCodigoAlimento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAlimento);

            comando.ExecuteNonQuery();

            return objAlimentacaoAlimento;
        }


        /// <summary>
        /// Salva uma lista de AlimentacaoAlimento
        /// </summary>
        /// <param name="objAlimentacaoAlimentoLista"></param>
        /// <returns></returns>
        public List<AlimentacaoAlimento> Salvar(List<AlimentacaoAlimento> objAlimentacaoAlimentoLista)
        {
            AlimentacaoAlimento alimentacaoAlimento = objAlimentacaoAlimentoLista[0];

            this.Excluir(alimentacaoAlimento.CodigoAlimentacao.Value);

            foreach (AlimentacaoAlimento objAlimentacaoAlimento in objAlimentacaoAlimentoLista)
            {
                this.Salvar(objAlimentacaoAlimento);
            }

            return objAlimentacaoAlimentoLista;
        }

        /// <summary>
        /// Exclui todos os Alimentos de uma Alimentacao
        /// </summary>
        /// <param name="codigoAlimentacao"></param>
        public bool Excluir(int codigoAlimentacao)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            comando.CommandText =
                @"delete from AlimentacaoAlimento where CodigoAlimentacao = @codigoAlimentacao";

            comando.CommandType = System.Data.CommandType.Text;

            SqlParameter parametroCodigoAlimentacao = new SqlParameter("@codigoAlimentacao", codigoAlimentacao);
            parametroCodigoAlimentacao.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAlimentacao);

            return Convert.ToBoolean(comando.ExecuteNonQuery());
        }
    }
}