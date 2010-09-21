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

        public Orcamento Salvar(Orcamento objOrcamento)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objOrcamento.CodigoOrcamento.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Orcamento (CasaLar_CodigoCasaLar, NomePlano, StatusPlano, ValorTotal, ValorEstimado, ValorDisponivel
                                  NomeGasto, ValorGasto, DataGasto, QtdParcelas, GastoTotal, MediaGastoMensal, InicioVigencia, FimVigencia)
                    VALUES (@casaLar_CodigoCasaLar, @nomePlano, @statusPlano, @valorTotal, @valorEstimado, @valorDisponivel, @nomeGasto,
                            @valorGasto, @dataGasto, @qtdParcelas, @gastoTotal, @mediaGastoMensal, @inicioVigencia, @fimVigencia )";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Orcamento SET CasaLar_CodigoCasaLar = @casaLar_CodigoCasaLar, NomePlano = @nomePlano, StatusPlano = @statusPlano,
                             ValorTotal = @valorTotal, ValorEstimado = @valorEstimado, ValorDisponivel = @valorDisponivel,
                             NomeGasto = @nomeGasto, ValorGasto = @valorGasto, DataGasto = @dataGasto, QtdParcelas = @qtdParcelas,
                             GastoTotal = @gastoTotal, MediaGastoMensal = @mediaGastoMensal, InicioVigencia = @inicioVigencia,
                             FimVigencia = @fimVigencia)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objOrcamento.CodigoOrcamento.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoOrcamento", objOrcamento.CodigoOrcamento.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroCasaLar_CodigoCasaLar = new SqlParameter();
            if (objOrcamento.CasaLar_CodigoCasaLar.HasValue)
            {
                parametroCasaLar_CodigoCasaLar.Value = objOrcamento.CasaLar_CodigoCasaLar.Value;
                parametroCasaLar_CodigoCasaLar.ParameterName = "@casaLar_CodigoCasaLar";
                parametroCasaLar_CodigoCasaLar.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroCasaLar_CodigoCasaLar.Value = DBNull.Value;
                parametroCasaLar_CodigoCasaLar.ParameterName = "@casaLar_CodigoCasaLar";
                parametroCasaLar_CodigoCasaLar.DbType = System.Data.DbType.Int32;
            }


            SqlParameter parametroNomePlano = new SqlParameter("@nomePlano", objOrcamento.NomePlano);
            parametroNomePlano.DbType = System.Data.DbType.String;

            SqlParameter parametroStatusPlano = new SqlParameter("@statusPlano", objOrcamento.StatusPlano);
            parametroStatusPlano.DbType = System.Data.DbType.String;

            SqlParameter parametroValorTotal = new SqlParameter("@valorTotal", objOrcamento.ValorTotal);
            parametroValorTotal.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroValorEstimado = new SqlParameter("@valorEstimado", objOrcamento.ValorEstimado);
            parametroValorEstimado.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroValorDisponivel = new SqlParameter("@valorDisponivel", objOrcamento.ValorDisponivel);
            parametroValorDisponivel.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroNomeGasto = new SqlParameter("@nomeGasto", objOrcamento.NomeGasto);
            parametroNomeGasto.DbType = System.Data.DbType.String;

            SqlParameter parametroValorGasto = new SqlParameter("@valorGasto", objOrcamento.ValorGasto);
            parametroValorGasto.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroDataGasto = new SqlParameter("@dataGasto", objOrcamento.DataGasto);
            parametroDataGasto.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroQtdParcelas = new SqlParameter("@qtdParcelas", objOrcamento.QtdParcelas);
            parametroQtdParcelas.DbType = System.Data.DbType.Int32;

            SqlParameter parametroGastoTotal = new SqlParameter("@gastoTotal", objOrcamento.GastoTotal);
            parametroGastoTotal.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroMediaGastoMensal = new SqlParameter("@mediaGastoMensal", objOrcamento.MediaGastoMensal);
            parametroMediaGastoMensal.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroInicioVigencia = new SqlParameter("@inicioVigencia", objOrcamento.InicioVigencia);
            parametroInicioVigencia.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroFimVigencia = new SqlParameter("@fimVigencia", objOrcamento.FimVigencia);
            parametroFimVigencia.DbType = System.Data.DbType.DateTime;

           
            comando.Parameters.Add(parametroCasaLar_CodigoCasaLar);
            comando.Parameters.Add(parametroNomePlano);
            comando.Parameters.Add(parametroStatusPlano);
            comando.Parameters.Add(parametroValorTotal);
            comando.Parameters.Add(parametroValorEstimado);
            comando.Parameters.Add(parametroValorDisponivel);
            comando.Parameters.Add(parametroNomeGasto);
            comando.Parameters.Add(parametroValorGasto);
            comando.Parameters.Add(parametroDataGasto);
            comando.Parameters.Add(parametroQtdParcelas);
            comando.Parameters.Add(parametroGastoTotal);
            comando.Parameters.Add(parametroMediaGastoMensal);
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
                objOrcamento.CasaLar_CodigoCasaLar = Convert.ToInt32(leitorDados["CasaLar_CodigoCasaLar"]);
                objOrcamento.NomePlano = leitorDados["NomePlano"].ToString();
                objOrcamento.StatusPlano = leitorDados["StatusPlano"].ToString();
                objOrcamento.ValorTotal = Convert.ToDecimal(leitorDados["ValorTotal"]);
                objOrcamento.ValorEstimado = Convert.ToDecimal(leitorDados["ValorEstimado"]);
                objOrcamento.ValorDisponivel = Convert.ToDecimal(leitorDados["ValorDisponivel"]);
                objOrcamento.NomeGasto = leitorDados["NomeGasto"].ToString();
                objOrcamento.ValorGasto = Convert.ToDecimal(leitorDados["ValorGasto"]);
                objOrcamento.DataGasto = Convert.ToDateTime(leitorDados["DataGasto"]);
                objOrcamento.QtdParcelas = Convert.ToInt32(leitorDados["QtdParcelas"]);
                objOrcamento.GastoTotal = Convert.ToDecimal(leitorDados["GastoTotal"]);
                objOrcamento.MediaGastoMensal = Convert.ToDecimal(leitorDados["MediaGastoMensal"]);
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

    }
}