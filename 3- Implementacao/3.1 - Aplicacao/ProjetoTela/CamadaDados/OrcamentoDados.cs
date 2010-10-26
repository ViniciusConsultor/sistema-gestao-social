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
    public class OrcamentoDados : BaseConnection
    {
        /// <summary>
        /// Salva os orçamentos
        /// </summary>
        /// <param name="objOrcamento"></param>
        /// <returns></returns>
        public Orcamento Salvar(Orcamento objOrcamento)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objOrcamento.CodigoOrcamento.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Orcamento (CodigoCasaLar, NomePlano, StatusPlano, ValorOrcamento, SaldoDisponivel, InicioVigencia, FimVigencia)
                    VALUES (@codigoCasaLar, @nomePlano, @statusPlano, @valorOrcamento, @saldoDisponivel, @inicioVigencia, @fimVigencia )";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Orcamento SET CodigoCasaLar = @codigoCasaLar, NomePlano = @nomePlano, StatusPlano = @statusPlano, SaldoDisponivel = @saldoDisponivel,
                             ValorOrcamento = @valorOrcamento, InicioVigencia = @inicioVigencia, FimVigencia = @fimVigencia)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objOrcamento.CodigoOrcamento.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoOrcamento", objOrcamento.CodigoOrcamento.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroCodigoCasaLar = new SqlParameter();
            if (objOrcamento.CodigoCasaLar.HasValue)
            {
                parametroCodigoCasaLar.Value = objOrcamento.CodigoCasaLar.Value;
                parametroCodigoCasaLar.ParameterName = "@codigoCasaLar";
                parametroCodigoCasaLar.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroCodigoCasaLar.Value = DBNull.Value;
                parametroCodigoCasaLar.ParameterName = "@codigoCasaLar";
                parametroCodigoCasaLar.DbType = System.Data.DbType.Int32;
            }


            SqlParameter parametroNomePlano = new SqlParameter("@nomePlano", objOrcamento.NomePlano);
            parametroNomePlano.DbType = System.Data.DbType.String;

            SqlParameter parametroStatusPlano = new SqlParameter("@statusPlano", objOrcamento.StatusPlano);
            parametroStatusPlano.DbType = System.Data.DbType.String;

            SqlParameter parametroValorOrcamento = new SqlParameter("@valorOrcamento", objOrcamento.ValorOrcamento);
            parametroValorOrcamento.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroSaldoDisponivel = new SqlParameter("@saldoDisponivel", objOrcamento.SaldoDisponivel);
            parametroValorOrcamento.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroInicioVigencia = new SqlParameter("@inicioVigencia", objOrcamento.InicioVigencia);
            parametroInicioVigencia.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroFimVigencia = new SqlParameter("@fimVigencia", objOrcamento.FimVigencia);
            parametroFimVigencia.DbType = System.Data.DbType.DateTime;

           
            comando.Parameters.Add(parametroCodigoCasaLar);
            comando.Parameters.Add(parametroNomePlano);
            comando.Parameters.Add(parametroStatusPlano);
            comando.Parameters.Add(parametroValorOrcamento);
            comando.Parameters.Add(parametroSaldoDisponivel);
            comando.Parameters.Add(parametroInicioVigencia);
            comando.Parameters.Add(parametroFimVigencia);


            comando.ExecuteNonQuery();

            //TODO: retorno entidade Orcamento com o Código do Orcamento Preenchido
            return objOrcamento;
        }

        /// <summary>
        /// Obtém os orçamentos pelo Código do Orcamento.
        /// </summary>
        /// <param name="codigoOrcamento"></param>
        /// <returns></returns>
        public Orcamento ObterOrcamento(int codigoOrcamento)
        {
            SqlCommand comando = new SqlCommand("select * from Orcamento where CodigoOrcamento = @codigoOrcamento", base.Conectar());
            SqlParameter parametroCodigoOrcamento = new SqlParameter("@codigoOrcamento", codigoOrcamento);
            parametroCodigoOrcamento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoOrcamento);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Orcamento objOrcamento = null;

            if (leitorDados.Read())
            {
                objOrcamento = new Orcamento();

                objOrcamento.CodigoOrcamento = codigoOrcamento;
                objOrcamento.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objOrcamento.NomePlano = leitorDados["NomePlano"].ToString();
                objOrcamento.StatusPlano = leitorDados["StatusPlano"].ToString();
                objOrcamento.ValorOrcamento = Convert.ToDecimal(leitorDados["ValorOrcamento"]);
                objOrcamento.SaldoDisponivel = Convert.ToDecimal(leitorDados["SaldoDisponivel"]);
                objOrcamento.InicioVigencia = Convert.ToDateTime (leitorDados["InicioVigencia"]);
                objOrcamento.FimVigencia = Convert.ToDateTime(leitorDados["FimVigencia"]);

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objOrcamento;
        }

        /// <summary>
        /// Obtem o Ultimo plano cadastrado.
        /// </summary>
        /// <returns></returns>
        public Orcamento ObterUltimoOrcamentoInserido()
        { 

            SqlCommand comando = new SqlCommand("SELECT TOP (1)* from Orcamento ORDER BY CodigoOrcamento DESC", base.Conectar());
            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Orcamento objOrcamento = null;

            if (leitorDados.Read())
            {
                objOrcamento = new Orcamento();

                objOrcamento.CodigoOrcamento = Convert.ToInt32(leitorDados["CodigoOrcamento"]);
                objOrcamento.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objOrcamento.NomePlano = leitorDados["NomePlano"].ToString();
                objOrcamento.StatusPlano = leitorDados["StatusPlano"].ToString();
                objOrcamento.ValorOrcamento = Convert.ToDecimal(leitorDados["ValorOrcamento"]);
                objOrcamento.SaldoDisponivel = Convert.ToDecimal(leitorDados["SaldoDisponivel"]);
                objOrcamento.InicioVigencia = Convert.ToDateTime (leitorDados["InicioVigencia"]);
                objOrcamento.FimVigencia = Convert.ToDateTime(leitorDados["FimVigencia"]);

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objOrcamento;
        }
        
         /// <summary>
        /// Exclui o Orcamento pelo seu código
        /// </summary>
        public bool ExcluirOrcamento(int codigoOrcamento)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Orcamento where CodigoOrcamento = @codigoOrcamento", base.Conectar());

            SqlParameter parametroCodigoOrcamento = new SqlParameter("@codigoOrcamento", codigoOrcamento);
            parametroCodigoOrcamento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoOrcamento);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

/*

        public List<Orcamento> ConsultarOrcamento(OrcamentoDTO objOrcamentoDTO)
        {
       SqlCommand comando = new SqlCommand();
       comando.Connection = base.Conectar();

       SqlDataReader leitorDados;

       SqlParameter paramStatusPlanoValor = new SqlParameter("@statusPlanoValor", objOrcamentoDTO.StatusPlanoValor);
       paramStatusPlanoValor.DbType = System.Data.DbType.String;

       SqlParameter paramInicioVigenciaValor = new SqlParameter("@inicioVigenciaValor", System.Data.SqlDbType.DateTime);
       if (objOrcamentoDTO.InicioVigenciaValor.HasValue)
           paramInicioVigenciaValor.Value = objOrcamentoDTO.InicioVigenciaValor.Value;
       else
           paramInicioVigenciaValor.Value = DBNull.Value;

       SqlParameter paramFimVigenciaValor = new SqlParameter("@fimVigenciaValor", System.Data.SqlDbType.DateTime);
       if (objOrcamentoDTO.FimVigenciaValor.HasValue)
           paramFimVigenciaValor.Value = objOrcamentoDTO.FimVigenciaValor.Value;
       else
           paramFimVigenciaValor.Value = DBNull.Value;

       SqlParameter paramNomePlanoValor = new SqlParameter("@descricaoValor", "%" + objOrcamentoDTO.NomePlanoValor + "%");
       paramNomePlanoValor.DbType = System.Data.DbType.String;

       String sql = "select * from Orcamento";

       //Se o Tipo de Lancamento, Data Lancamento e Descricao preenchidos
       if (objOrcamentoDTO.TipoLancamentoValor != "Selecione" && objOrcamentoDTO.DataLancamentoValor.HasValue && objOrcamentoDTO.DescricaoValor != "")
           sql += @" where TipoLancamento = @tipoLancamentoValor and DataLancamento = @dataLancamentoValor and Observacao like @descricaoValor";
 
       //Se apenas TipoLancamento e DataLancamento preenchido
       else if (objOrcamentoDTO.TipoLancamentoValor != "Selecione" && objOrcamentoDTO.DataLancamentoValor.HasValue)
           sql += @" where TipoLancamento = @tipoLancamentoValor and DataLancamento = @dataLancamentoValor";
 
       //Se apenas DataLancamento e DescricaoValor preenchido
       else if (objOrcamentoDTO.DataLancamentoValor.HasValue && objOrcamentoDTO.DescricaoValor != "")
           sql += @" where DataLancamento = @dataLancamentoValor and Observacao like @descricaoValor";
 
       //Se apenas Descricao e TipoLancamento preenchido
       else if (objOrcamentoDTO.DescricaoValor != "" && objOrcamentoDTO.TipoLancamentoValor != "Selecione")
           sql += @" where Observacao like @descricaoValor and TipoLancamento = @tipoLancamentoValor";
 
       //Se apenas Descricao preenchido
       else if (objOrcamentoDTO.DescricaoValor != "")
           sql += @" where Observacao like @descricaoValor";
 
       //Se apenas TipoLancamento preenchido
       else if (objOrcamentoDTO.TipoLancamentoValor != "Selecione")
           sql += @" where TipoLancamento = @tipoLancamentoValor";
 
       //Se apenas DataLancamento e DescricaoValor preenchido
       else if (objOrcamentoDTO.DataLancamentoValor.HasValue)
           sql += @" where DataLancamento = @dataLancamentoValor";

       comando.CommandText = sql;
       comando.CommandType = System.Data.CommandType.Text;
       comando.Parameters.Add(paramStatusPlanoValor);
       comando.Parameters.Add(paramInicioVigenciaValor);
       comando.Parameters.Add(paramDescricaoValor);

       leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



       List<Orcamento> financasLista = new List<Orcamento>();
       Orcamento objOrcamento;

       while (leitorDados.Read())
       {
           objOrcamento = new Orcamento();

           objOrcamento.CodigoOrcamento = Convert.ToInt32(leitorDados["CodigoOrcamento"]);
           //objOrcamento.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
           //objOrcamento.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
           objOrcamento.DataLancamento = Convert.ToDateTime(leitorDados["DataLancamento"]);
           objOrcamento.DataCriacao = Convert.ToDateTime(leitorDados["DataCriacao"]);
           objOrcamento.TipoLancamento = leitorDados["TipoLancamento"].ToString();
           objOrcamento.Valor = Convert.ToDecimal(leitorDados["Valor"]);
           objOrcamento.LancadoPor = leitorDados["LancadoPor"].ToString();
           objOrcamento.Observacao = leitorDados["Observacao"].ToString();
           objOrcamento.NaturezaFinanca = leitorDados["NaturezaFinanca"].ToString();
                

           financasLista.Add(objOrcamento);
       }

       return financasLista;
        */
    }
}