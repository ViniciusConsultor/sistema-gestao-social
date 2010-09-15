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
                @"INSERT INTO FINANCAS ( casaLar_CodCasaLar, DataLancamento, DataCriacao, TipoLancamento, Valor, LancadoPor, Observacao)
                VALUES (@casalar_CodCasaLar, @dataLancamento, @dataCriacao, @tipoLancamento, @valor, @lancadoPor, @observacao)";
        }
        else
        {
            comando.CommandText = 
            @"UPDATE FINANCAS SET casaLar_CodCasaLar = @casalar_CodCasaLar, DataLancamento = @dataLancamento, DataCriacao = @dataCriacao, TipoLancamento = @tipoLancamento,
            Valor = @valor, LancadoPor = @lancadoPor, Observacao = @observacao
            WHERE (casaLar_CodCasaLar = @casalar_CodCasaLar)";
        }
        
        comando.CommandType = System.Data.CommandType.Text;

        if (objFinancas.codFinancas.HasValue)
         {
            SqlParameter parametroCodigo = new SqlParameter ("@codFinancas", objFinancas.codFinancas.Value);
            parametroCodigo.DbType  = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigo);
        }

            SqlParameter parametrocasaLar_CodCasaLar = new SqlParameter();
            if (objFinancas.parametrocasaLar_CodCasaLar.HasValue)
            {
                parametrocasaLar_CodCasaLar.Value = objFinancas.casalar_CodCasaLar.Value;
                parametrocasaLar_CodCasaLar.ParameterName = "@casaLar_CodCasaLar";
                parametrocasaLar_CodCasaLar.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametrocasalar_CodCasaLar.Value = DBNull.Value;
                parametrocasaLar_CodCasaLar.ParameterName = "@casaLar_CodCasaLar";
                parametrocasaLar_CodCasaLar.DbType = System.Data.DbType.Int32;
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

        comando.Parameters.Add(parametrocasalar_CodCasaLar);
        comando.Parameters.Add(parametroDataLancamento);
        comando.Parameters.Add(parametroDataCriacao);
        comando.Parameters.Add(parametroTipoLancamento);
        comando.Parameters.Add(parametroValor);
        comando.Parameters.Add(parametroLancadoPor);
        comando.Parameters.Add(parametroObservacao);
       
        comando.ExecuteNonQuery();

        return objFinancas;
    }

   public Financas ObterFinancas(int codFinancas)
        {
            SqlCommand comando = new SqlCommand("select * from Financas where CodFinancas = @codFinancas", base.Conectar());
            SqlParameter parametroCodigo = new SqlParameter("@codFinancas", codFinancas);
            parametroCodigo.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigo);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Financas objFinancas = null;

            if (leitorDados.Read())
            {
                objFinancas = new Financas();

                objFinancas.codFinancas = codFinancas;
                objFinancas.casalar_CodCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objFinancas.dataLancamento = leitorDados["DataLancamento"].ToDateTime();
                objFinancas.dataCriacao = leitorDados["DataCriacao"].ToDateTime();
                objFinancas.tipoLancamento = leitorDados["TipoLancamento"].ToString();
                objFinancas.valor = leitorDados["Valor"].ToFloat();
                objFinancas.lancadoPor = leitorDados["LancadoPor"].ToString();
                objFinancas.observacao = leitorDados["Observacao"].ToString();
                
            }
    
            leitorDados.Close();
            leitorDados.Dispose();

            return objFinancas;
        }

   public bool ExcluirFinancas(int codFinancas)
    {
        bool execucao;

        SqlCommand comando = new SqlCommand("delete from Financas where CodFinancas = @codFinancas", base.Conectar());

        SqlParameter parametroCodFinancas = new SqlParameter("@codigoLogin", codFinancas);
        parametroCodFinancas.DbType = System.Data.DbType.Int32;
        comando.Parameters.Add(parametroCodFinancas);

        execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

        return execucao;

    }


    }
}
