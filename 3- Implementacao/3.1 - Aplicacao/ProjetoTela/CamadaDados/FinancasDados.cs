using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;
using System.Data.SqlClient;

namespace SGS.CamadaDados
{
    public class FinancasDados : BaseConnection
    {

       
            ///<sumary>
            ///Este metodo salva Finanças
           ///</sumary>
           ///<param name="objFinancas"></param>
           ///<returns></returns>
   public Financas Salvar (Financas objFinancas)
    {
        SqlCommand comando = new SqlCommand();
        comando.Connection = base.Conectar();

        if (!objFinancas.codFinancas.HasValue)
        {
            comando.CommandText = 
                @"INSERT INTO FINANCAS (DataLancamento, DataCriacao, TipoLancamento, Valor, LancadoPor, Observacao)
                VALUES (@dataLancamento, @dataCriacao, @tipoLancamento, @valor, @lancadoPor, @observacao)";
        }
        else
        {
            comando.CommandText = 
            @"UPDATE FINANCAS SET DataLancamento = @dataLancamento, DataCriacao = @dataCriacao, TipoLancamento = @tipoLancamento,
            Valor = @valor, LancadoPor = @lancadoPor, Observacao = @observacao
            WHERE (CodigoCasaLar = @codigoCasaLar)";
        }
        
        comando.CommandType = System.Data.CommandType.Text;

        if (objFinancas.codFinancas.HasValue)
        {
            SqlParameter parametroCodigo = new SqlParameter ("@codFinancas", objFinancas.codFinancas.Value);
            parametroCodigo.DbType  = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigo);
        }

        SqlParameter parametroDataLancamento = new SqlParameter("@dataLancamento", objFinancas.dataLancamento);
        parametroDataLancamento.DbType = System.Data.DbType.DateTime;

        SqlParameter parametroDataCriacao = new SqlParameter("@dataCriacao", objFinancas.dataCriacao);
        parametroDataCriacao.DbType = System.Data.DbType.DateTime;
       
        SqlParameter parametroTipoLancamento = new SqlParameter("@tipoLancamento", objFinancas.tipoLancamento);
        parametroTipoLancamento.DbType = System.Data.DbType.String;

        SqlParameter parametroValor = new SqlParameter("@valor", objFinancas.valor);
        parametroValor.DbType = System.Data.DbType.Decimal;

        SqlParameter parametroLancadoPor = new SqlParameter("@lancadoPor", objFinancas.lancadoPor);
        parametroLancadoPor.DbType  = System.Data.DbType.String;

        SqlParameter parametroObservacao = new SqlParameter("@observacao", objFinancas.observacao);
        parametroObservacao.DbType = System.Data.DbType.String;


        comando.Parameters.Add(parametroDataLancamento);
        comando.Parameters.Add(parametroDataCriacao);
        comando.Parameters.Add(parametroTipoLancamento);
        comando.Parameters.Add(parametroValor);
        comando.Parameters.Add(parametroLancadoPor);
        comando.Parameters.Add(parametroObservacao);
       
        comando.ExecuteNonQuery();

        return objFinancas;
   }



    }
}