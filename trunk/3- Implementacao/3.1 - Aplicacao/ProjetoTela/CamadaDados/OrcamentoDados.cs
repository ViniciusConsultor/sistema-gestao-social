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
                    @"UPDATE Orcamento SET  CodigoCasaLar = @codigoCasaLar, NomePlano = @nomePlano, StatusPlano = @statusPlano, SaldoDisponivel = @saldoDisponivel,
                             ValorOrcamento = @valorOrcamento, InicioVigencia = @inicioVigencia, FimVigencia = @fimVigencia
                        WHERE (CodigoOrcamento = @codigoOrcamento) ";
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

            if (!objOrcamento.CodigoOrcamento.HasValue)
            {
                return ObterUltimoOrcamentoInserido();
            }

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

            SqlParameter parametroCodigo = new SqlParameter("@codigoOrcamento", codigoOrcamento);
            parametroCodigo.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigo);

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
                objOrcamento.InicioVigencia = Convert.ToDateTime(leitorDados["InicioVigencia"]);
                objOrcamento.FimVigencia = Convert.ToDateTime(leitorDados["FimVigencia"]);

            }

            if (objOrcamento != null && objOrcamento.CodigoCasaLar != null)
            {
                CasaLarDados objCasaLarDados = new CasaLarDados();
                objOrcamento.CasaLar = objCasaLarDados.ObterCasaLar(objOrcamento.CodigoCasaLar.Value);
            }


            leitorDados.Close();
            leitorDados.Dispose();

            return objOrcamento;
        }

        public Orcamento ObterOrcamento()
        {
            SqlCommand comando = new SqlCommand("select TOP(1) * from Orcamento ORDER BY codigoOrcamento ASC", base.Conectar());

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
                objOrcamento.InicioVigencia = Convert.ToDateTime(leitorDados["InicioVigencia"]);
                objOrcamento.FimVigencia = Convert.ToDateTime(leitorDados["FimVigencia"]);




            }

            if (objOrcamento != null && objOrcamento.CodigoCasaLar != null)
            {
                CasaLarDados objCasaLarDados = new CasaLarDados();
                objOrcamento.CasaLar = objCasaLarDados.ObterCasaLar(objOrcamento.CodigoCasaLar.Value);
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
                objOrcamento.InicioVigencia = Convert.ToDateTime(leitorDados["InicioVigencia"]);
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



        public List<Orcamento> ConsultarOrcamento(OrcamentoDTO objOrcamentoDTO)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            SqlDataReader leitorDados;


            SqlParameter paramNomePlanoValor = new SqlParameter("@nomePlanoValor", "%" + objOrcamentoDTO.NomePlanoValor + "%");
            paramNomePlanoValor.DbType = System.Data.DbType.String;

            String sql = "select * from Orcamento";


            //Se NomePlano preenchido
            if (objOrcamentoDTO.NomePlanoValor != "Selecione")
                sql = @" where NomePlano = @nomePlanoValor";

            comando.CommandText = sql;
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.Add(paramNomePlanoValor);

            leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



            List<Orcamento> orcamentoLista = new List<Orcamento>();
            Orcamento objOrcamento;

            while (leitorDados.Read())
            {
                objOrcamento = new Orcamento();

                objOrcamento.CodigoOrcamento = Convert.ToInt32(leitorDados["CodigoOrcamento"]);
                //objOrcamento.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                //objOrcamento.CodigoNatureza = Convert.ToInt32(leitorDados["CodigoNatureza"]);
                objOrcamento.NomePlano = leitorDados["NomePlano"].ToString();
                objOrcamento.StatusPlano = leitorDados["StatusPlano"].ToString();
                objOrcamento.ValorOrcamento = Convert.ToDecimal(leitorDados["ValorOrcamento"]);
                objOrcamento.SaldoDisponivel = Convert.ToDecimal(leitorDados["SaldoDisponivel"]);
                objOrcamento.InicioVigencia = Convert.ToDateTime(leitorDados["InicioVigencia"]);
                objOrcamento.FimVigencia = Convert.ToDateTime(leitorDados["FimVigencia"]);


                orcamentoLista.Add(objOrcamento);
            }

            return orcamentoLista;



        }

    }
}