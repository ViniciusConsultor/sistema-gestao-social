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

        if (!objFinancas.CodigoFinancas.HasValue)
        {
            comando.CommandText = 
                @"INSERT INTO FINANCAS ( CodigoCasaLar, DataLancamento, DataCriacao, TipoLancamento, Valor, LancadoPor, Observacao)
                VALUES (@codigoCasaLar, @dataLancamento, @dataCriacao, @tipoLancamento, @valor, @lancadoPor, @observacao)";
        }
        else
        {
            comando.CommandText = 
            @"UPDATE FINANCAS SET CodigoCasaLar = @codigoCasaLar, DataLancamento = @dataLancamento, DataCriacao = @dataCriacao, TipoLancamento = @tipoLancamento,
            Valor = @valor, LancadoPor = @lancadoPor, Observacao = @observacao
            WHERE (CodigoFinancas = @codigoFinancas)";
        }
        
        comando.CommandType = System.Data.CommandType.Text;

        if (objFinancas.CodigoFinancas.HasValue)
         {
            SqlParameter parametroCodigo = new SqlParameter ("@codigoFinancas", objFinancas.CodigoFinancas.Value);
            parametroCodigo.DbType  = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigo);
        }

            SqlParameter parametroCodigoCasaLar = new SqlParameter();
            if (objFinancas.CodigoCasaLar.HasValue)
            {
                parametroCodigoCasaLar.Value = objFinancas.CodigoCasaLar.Value;
                parametroCodigoCasaLar.ParameterName = "@codigoCasaLar";
                parametroCodigoCasaLar.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroCodigoCasaLar.Value = DBNull.Value;
                parametroCodigoCasaLar.ParameterName = "@codigoCasaLar";
                parametroCodigoCasaLar.DbType = System.Data.DbType.Int32;
            }

        SqlParameter parametroDataLancamento = new SqlParameter("@dataLancamento", objFinancas.DataLancamento);
        parametroDataLancamento.DbType = System.Data.DbType.DateTime;

        SqlParameter parametroDataCriacao = new SqlParameter("@dataCriacao", objFinancas.DataCriacao);
        parametroDataCriacao.DbType = System.Data.DbType.DateTime;
       
        SqlParameter parametroTipoLancamento = new SqlParameter("@tipoLancamento", objFinancas.TipoLancamento);
        parametroTipoLancamento.DbType = System.Data.DbType.String;

        SqlParameter parametroValor = new SqlParameter("@valor", objFinancas.Valor);
        parametroValor.DbType = System.Data.DbType.Decimal;

        SqlParameter parametroLancadoPor = new SqlParameter("@lancadoPor", objFinancas.LancadoPor);
        parametroLancadoPor.DbType  = System.Data.DbType.String;

        SqlParameter parametroObservacao = new SqlParameter("@observacao", objFinancas.Observacao);
        parametroObservacao.DbType = System.Data.DbType.String;

        comando.Parameters.Add(parametroCodigoCasaLar);
        comando.Parameters.Add(parametroDataLancamento);
        comando.Parameters.Add(parametroDataCriacao);
        comando.Parameters.Add(parametroTipoLancamento);
        comando.Parameters.Add(parametroValor);
        comando.Parameters.Add(parametroLancadoPor);
        comando.Parameters.Add(parametroObservacao);
       
        comando.ExecuteNonQuery();

        return objFinancas;
    }

   public Financas ObterFinancas(int codigoFinancas)
        {
            SqlCommand comando = new SqlCommand("select * from Financas where CodigoFinancas = @codigoFinancas", base.Conectar());
            SqlParameter parametroCodigo = new SqlParameter("@codigoFinancas", codigoFinancas);
            parametroCodigo.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigo);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Financas objFinancas = null;

            if (leitorDados.Read())
            {
                objFinancas = new Financas();

                objFinancas.CodigoFinancas = codigoFinancas;
                objFinancas.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objFinancas.DataLancamento = Convert.ToDateTime(leitorDados["DataLancamento"]);
                objFinancas.DataCriacao =  Convert.ToDateTime(leitorDados["DataCriacao"]);
                objFinancas.TipoLancamento = leitorDados["TipoLancamento"].ToString();
                objFinancas.Valor = Convert.ToDecimal(leitorDados["Valor"]);
                objFinancas.LancadoPor = leitorDados["LancadoPor"].ToString();
                objFinancas.Observacao = leitorDados["Observacao"].ToString();
                
            }
    
            leitorDados.Close();
            leitorDados.Dispose();

            return objFinancas;
        }

   public bool ExcluirFinancas(int codigoFinancas)
    {
        bool execucao;

        SqlCommand comando = new SqlCommand("delete from Financas where CodigoFinancas = @codigoFinancas", base.Conectar());

        SqlParameter parametroCodigoFinancas = new SqlParameter("@codigoFinancas", codigoFinancas);
        parametroCodigoFinancas.DbType = System.Data.DbType.Int32;
        comando.Parameters.Add(parametroCodigoFinancas);

        execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

        return execucao;

    }

   public List<Financas> ConsultarFinancas(FinancasDTO objFinancasDTO)
   {
       SqlCommand comando = new SqlCommand();
       comando.Connection = base.Conectar();

       SqlDataReader leitorDados;

       SqlParameter paramTipoLancamentoValor = new SqlParameter("@tipoLancamentoValor", objFinancasDTO.TipoLancamentoValor);
       paramTipoLancamentoValor.DbType = System.Data.DbType.String;

       SqlParameter paramDataLancamentoValor = new SqlParameter("@dataLancamentoValor", objFinancasDTO.DataLancamentoValor.HasValue);
       paramDataLancamentoValor.DbType = System.Data.DbType.DateTime;

       SqlParameter paramDescricaoValor = new SqlParameter("@descricaoValor", "%" + objFinancasDTO.DescricaoValor + "%");
       paramDescricaoValor.DbType = System.Data.DbType.String;

       String sql = "select * from Financas";

       //Se o Tipo de Lancamento, Data Lancamento e Descricao preenchidos
       if (objFinancasDTO.TipoLancamentoValor != "Selecione" && objFinancasDTO.DataLancamentoValor.HasValue && objFinancasDTO.DescricaoValor != "")
           sql += @" where TipoLancamento like @dataLancamentoValor or DataLancamento = @dataLancamentoValor or Observacao like @descricaoValor";
 
       //Se apenas TipoLancamento e DataLancamento preenchido
       else if (objFinancasDTO.TipoLancamentoValor != "Selecione" && objFinancasDTO.DataLancamentoValor.HasValue)
           sql += @" where TipoLancamento like @tipoLancamentoValor or DataLancamento = @dataLancamentoValor";
 
       //Se apenas DataLancamento e DescricaoValor preenchido
       else if (objFinancasDTO.DataLancamentoValor.HasValue && objFinancasDTO.DescricaoValor != "")
           sql += @" where DataLancamento = @dataLancamentoValor or Observacao like @descricaoValor";
 
       //Se apenas Descricao e TipoLancamento preenchido
       else if (objFinancasDTO.DescricaoValor != "" && objFinancasDTO.TipoLancamentoValor != "Selecione")
           sql += @" where Observacao like @descricaoValor or TipoLancamento like @tipoLancamentoValor";
 
       //Se apenas Descricao preenchido
       else if (objFinancasDTO.DescricaoValor != "")
           sql += @" where Observacao like @descricaoValor";
 
       //Se apenas TipoLancamento preenchido
       else if (objFinancasDTO.TipoLancamentoValor != "Selecione")
           sql += @" where TipoLancamento like @tipoLancamentoValor";
 
       //Se apenas DataLancamento e DescricaoValor preenchido

       else if (objFinancasDTO.DataLancamentoValor.HasValue)
           sql += @" where DataLancamento = @dataLancamentoValor";

       comando.CommandText = sql;
       comando.CommandType = System.Data.CommandType.Text;
       comando.Parameters.Add(paramTipoLancamentoValor);
       comando.Parameters.Add(paramDataLancamentoValor);
       comando.Parameters.Add(paramDescricaoValor);

       leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);





       List<Financas> financasLista = new List<Financas>();
       Financas objFinancas;

       while (leitorDados.Read())
       {
           objFinancas = new Financas();

           objFinancas.CodigoFinancas = Convert.ToInt32(leitorDados["CodigoFinancas"]);
           ///objFinancas.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
           objFinancas.DataLancamento = Convert.ToDateTime(leitorDados["DataLancamento"]);
           objFinancas.DataCriacao = Convert.ToDateTime(leitorDados["DataCriacao"]);
           objFinancas.TipoLancamento = leitorDados["TipoLancamento"].ToString();
           objFinancas.Valor = Convert.ToDecimal(leitorDados["Valor"]);
           objFinancas.LancadoPor = leitorDados["LancadoPor"].ToString();
           objFinancas.Observacao = leitorDados["Observacao"].ToString();
                

           financasLista.Add(objFinancas);
       }

       return financasLista;
   }
 
    }
}
