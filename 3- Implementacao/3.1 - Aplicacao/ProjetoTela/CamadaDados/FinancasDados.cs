﻿using System;
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
        public Financas Salvar(Financas objFinancas)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            if (!objFinancas.CodigoFinancas.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO FINANCAS ( CodigoCasaLar, CodigoNatureza, DataLancamento, DataCriacao, TipoLancamento, Valor, LancadoPor, Observacao)
                VALUES (@codigoCasaLar, @codigoNatureza, @dataLancamento, @dataCriacao, @tipoLancamento, @valor, @lancadoPor, @observacao)";
            }
            else
            {
                comando.CommandText =
                @"UPDATE FINANCAS SET CodigoCasaLar = @codigoCasaLar, CodigoNatureza = @codigoNatureza, DataLancamento = @dataLancamento, DataCriacao = @dataCriacao, TipoLancamento = @tipoLancamento,
            Valor = @valor, LancadoPor = @lancadoPor, Observacao = @observacao
            WHERE (CodigoFinancas = @codigoFinancas)";
            }

            comando.CommandType = System.Data.CommandType.Text;

            if (objFinancas.CodigoFinancas.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoFinancas", objFinancas.CodigoFinancas.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
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

            SqlParameter parametroCodigoNatureza = new SqlParameter();
            if (objFinancas.CodigoNatureza.HasValue)
            {
                parametroCodigoNatureza.Value = objFinancas.CodigoNatureza.Value;
                parametroCodigoNatureza.ParameterName = "@codigoNatureza";
                parametroCodigoNatureza.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroCodigoNatureza.Value = DBNull.Value;
                parametroCodigoNatureza.ParameterName = "@codigoNatureza";
                parametroCodigoNatureza.DbType = System.Data.DbType.Int32;
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
            parametroLancadoPor.DbType = System.Data.DbType.String;

            SqlParameter parametroObservacao = new SqlParameter("@observacao", objFinancas.Observacao);
            parametroObservacao.DbType = System.Data.DbType.String;

            comando.Parameters.Add(parametroCodigoCasaLar);
            comando.Parameters.Add(parametroCodigoNatureza);
            comando.Parameters.Add(parametroDataLancamento);
            comando.Parameters.Add(parametroDataCriacao);
            comando.Parameters.Add(parametroTipoLancamento);
            comando.Parameters.Add(parametroValor);
            comando.Parameters.Add(parametroLancadoPor);
            comando.Parameters.Add(parametroObservacao);

            comando.ExecuteNonQuery();


            if (!objFinancas.CodigoFinancas.HasValue)
            {
                return ObterUltima();
            }
            else
            {
                return objFinancas;
            }
        }

        public Financas Obter(int codigoFinancas)
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
                objFinancas.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
                objFinancas.DataLancamento = Convert.ToDateTime(leitorDados["DataLancamento"]);
                objFinancas.DataCriacao = Convert.ToDateTime(leitorDados["DataCriacao"]);
                objFinancas.TipoLancamento = leitorDados["TipoLancamento"].ToString();
                objFinancas.Valor = Convert.ToDecimal(leitorDados["Valor"]);
                objFinancas.LancadoPor = leitorDados["LancadoPor"].ToString();
                objFinancas.Observacao = leitorDados["Observacao"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objFinancas;
        }

        /// <summary>
        /// Obtém a última finanaça inserida
        /// </summary>
        /// <returns></returns>
        public Financas ObterUltima()
        {
            SqlCommand comando = new SqlCommand(@"SELECT TOP (1) * FROM Financas ORDER BY CodigoFinancas DESC", base.Conectar());
            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Financas objFinancas = null;

            if (leitorDados.Read())
            {
                objFinancas = new Financas();

                objFinancas.CodigoFinancas = Convert.ToInt32(leitorDados["CodigoFinancas"]);
                objFinancas.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objFinancas.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
                objFinancas.DataLancamento = Convert.ToDateTime(leitorDados["DataLancamento"]);
                objFinancas.DataCriacao = Convert.ToDateTime(leitorDados["DataCriacao"]);
                objFinancas.TipoLancamento = leitorDados["TipoLancamento"].ToString();
                objFinancas.Valor = Convert.ToDecimal(leitorDados["Valor"]);
                objFinancas.LancadoPor = leitorDados["LancadoPor"].ToString();
                objFinancas.Observacao = leitorDados["Observacao"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objFinancas;
        }

        public bool Excluir(int codigoFinancas)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Financas where CodigoFinancas = @codigoFinancas", base.Conectar());

            SqlParameter parametroCodigoFinancas = new SqlParameter("@codigoFinancas", codigoFinancas);
            parametroCodigoFinancas.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoFinancas);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;

        }

        public List<Financas> Consultar(FinancasDTO objFinancasDTO)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            SqlDataReader leitorDados;

            SqlParameter paramTipoLancamentoValor = new SqlParameter("@tipoLancamentoValor", objFinancasDTO.TipoLancamentoValor);
            paramTipoLancamentoValor.DbType = System.Data.DbType.String;

            SqlParameter paramDataLancamentoValor = new SqlParameter("@dataLancamentoValor", System.Data.SqlDbType.DateTime);
            if (objFinancasDTO.DataLancamentoValor.HasValue)
                paramDataLancamentoValor.Value = objFinancasDTO.DataLancamentoValor.Value;
            else
                paramDataLancamentoValor.Value = DBNull.Value;

            SqlParameter paramDescricaoValor = new SqlParameter("@descricaoValor", "%" + objFinancasDTO.DescricaoValor + "%");
            paramDescricaoValor.DbType = System.Data.DbType.String;

            String sql = "select * from Financas";

            //Se o Tipo de Lancamento, Data Lancamento e Descricao preenchidos
            if (objFinancasDTO.TipoLancamentoValor != "Selecione" && objFinancasDTO.DataLancamentoValor.HasValue && objFinancasDTO.DescricaoValor != "")
                sql += @" where TipoLancamento = @tipoLancamentoValor and DataLancamento = @dataLancamentoValor and Observacao like @descricaoValor";

            //Se apenas TipoLancamento e DataLancamento preenchido
            else if (objFinancasDTO.TipoLancamentoValor != "Selecione" && objFinancasDTO.DataLancamentoValor.HasValue)
                sql += @" where TipoLancamento = @tipoLancamentoValor and DataLancamento = @dataLancamentoValor";

            //Se apenas DataLancamento e DescricaoValor preenchido
            else if (objFinancasDTO.DataLancamentoValor.HasValue && objFinancasDTO.DescricaoValor != "")
                sql += @" where DataLancamento = @dataLancamentoValor and Observacao like @descricaoValor";

            //Se apenas Descricao e TipoLancamento preenchido
            else if (objFinancasDTO.DescricaoValor != "" && objFinancasDTO.TipoLancamentoValor != "Selecione")
                sql += @" where Observacao like @descricaoValor and TipoLancamento = @tipoLancamentoValor";

            //Se apenas Descricao preenchido
            else if (objFinancasDTO.DescricaoValor != "")
                sql += @" where Observacao like @descricaoValor";

            //Se apenas TipoLancamento preenchido
            else if (objFinancasDTO.TipoLancamentoValor != "Selecione")
                sql += @" where TipoLancamento = @tipoLancamentoValor";

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
                //objFinancas.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                //objFinancas.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
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

        /// <summary>
        /// Consulta as Financas pelo Relatório do Financeiro
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Financas> Consultar(FinanceiroRelatorioDTO filtro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            SqlDataReader leitorDados;

            String sql = "select * from Financas where ";

            SqlParameter paramTipoLancamento = new SqlParameter("@tipoLancamento", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(filtro.TipoLancamentoValor))
            {
                paramTipoLancamento.Value = filtro.TipoLancamentoValor;
                sql += @"TipoLancamento = @tipoLancamento and ";
            }
            else
                paramTipoLancamento.Value = DBNull.Value;

            SqlParameter paramNaturezaLancamento = new SqlParameter("@naturezaLancamento", System.Data.DbType.Int32);
            if (filtro.NaturezaLancamentoValor.HasValue)
            {
                paramNaturezaLancamento.Value = filtro.NaturezaLancamentoValor.Value;
                sql += @"CodigoNatureza = @naturezaLancamento and ";
            }
            else
                paramNaturezaLancamento.Value = DBNull.Value;

            SqlParameter paramDtInicioLancamento = new SqlParameter("@DdtInicioLancamento", System.Data.DbType.DateTime);
            if (filtro.DtInicioValor.HasValue)
            {
                paramDtInicioLancamento.Value = filtro.DtInicioValor.Value;
                sql += @"DataLancamento >= @DdtInicioLancamento and ";
            }
            else
                paramDtInicioLancamento.Value = DBNull.Value;

            SqlParameter paramDtFimLancamento = new SqlParameter("@dtFimLancamento", System.Data.DbType.DateTime);
            if (filtro.DtFimValor.HasValue)
            {
                paramDtFimLancamento.Value = filtro.DtFimValor.Value;
                sql += @"DataLancamento <= @dtFimLancamento and ";
            }
            else
                paramDtFimLancamento.Value = DBNull.Value;

            if (sql.EndsWith("where "))
                sql = sql.Replace("where ", "");
            else if (sql.EndsWith("and "))
                sql = sql.Remove(sql.Length - 4);

            sql += " order by DataLancamento";
            comando.CommandText = sql;
            comando.CommandType = System.Data.CommandType.Text;

            comando.Parameters.Add(paramTipoLancamento);
            comando.Parameters.Add(paramNaturezaLancamento);
            comando.Parameters.Add(paramDtInicioLancamento);
            comando.Parameters.Add(paramDtFimLancamento);

            leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            List<Financas> financasLista = new List<Financas>();
            Financas objFinancas;

            NaturezaLancamentoDados objNaturezaLancamentoDados = new NaturezaLancamentoDados();
            while (leitorDados.Read())
            {
                objFinancas = new Financas();

                objFinancas.CodigoFinancas = Convert.ToInt32(leitorDados["CodigoFinancas"]);
                objFinancas.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objFinancas.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
                objFinancas.NaturezaLancamento = objNaturezaLancamentoDados.Obter(objFinancas.CodigoNatureza.Value);
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

        /// <summary>
        /// Lista as financas pela Data de Início de Fim de seu lançamento
        /// </summary>
        /// <param name="dataInicioLancamento"></param>
        /// <param name="dataFimLancamento"></param>
        /// <returns></returns>
        public List<Financas> Listar(DateTime dataInicioLancamento, DateTime dataFimLancamento)
        {
            SqlCommand comando = new SqlCommand("select * from Financas where DataLancamento between @dataInicioLancamento and @dataFimLancamento", base.Conectar());

            SqlParameter parametroDataInicioLancamento = new SqlParameter("@dataInicioLancamento", dataInicioLancamento);
            parametroDataInicioLancamento.DbType = System.Data.DbType.DateTime;
            comando.Parameters.Add(parametroDataInicioLancamento);

            SqlParameter parametroDataFimLancamento = new SqlParameter("@dataFimLancamento", dataFimLancamento);
            parametroDataFimLancamento.DbType = System.Data.DbType.DateTime;
            comando.Parameters.Add(parametroDataFimLancamento);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            List<Financas> objFinancasLista = new List<Financas>();
            Financas objFinancas = null;

            while (leitorDados.Read())
            {
                objFinancas = new Financas();

                objFinancas.CodigoFinancas = Convert.ToInt32(leitorDados["CodigoFinancas"]);
                objFinancas.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objFinancas.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
                objFinancas.DataLancamento = Convert.ToDateTime(leitorDados["DataLancamento"]);
                objFinancas.DataCriacao = Convert.ToDateTime(leitorDados["DataCriacao"]);
                objFinancas.TipoLancamento = leitorDados["TipoLancamento"].ToString();
                objFinancas.Valor = Convert.ToDecimal(leitorDados["Valor"]);
                objFinancas.LancadoPor = leitorDados["LancadoPor"].ToString();
                objFinancas.Observacao = leitorDados["Observacao"].ToString();

                objFinancasLista.Add(objFinancas);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objFinancasLista;
        }

    }
}
