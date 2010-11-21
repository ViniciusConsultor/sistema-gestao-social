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
                    @"INSERT INTO Orcamento (CodigoCasaLar, NomePlano, StatusPlano, ValorOrcamento, InicioVigencia, FimVigencia)
                    VALUES (@codigoCasaLar, @nomePlano, @statusPlano, @valorOrcamento, @inicioVigencia, @fimVigencia )";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Orcamento SET  CodigoCasaLar = @codigoCasaLar, NomePlano = @nomePlano, StatusPlano = @statusPlano, 
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

            SqlParameter parametroInicioVigencia = new SqlParameter("@inicioVigencia", objOrcamento.InicioVigencia);
            parametroInicioVigencia.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroFimVigencia = new SqlParameter("@fimVigencia", objOrcamento.FimVigencia);
            parametroFimVigencia.DbType = System.Data.DbType.DateTime;


            comando.Parameters.Add(parametroCodigoCasaLar);
            comando.Parameters.Add(parametroNomePlano);
            comando.Parameters.Add(parametroStatusPlano);
            comando.Parameters.Add(parametroValorOrcamento);
            comando.Parameters.Add(parametroInicioVigencia);
            comando.Parameters.Add(parametroFimVigencia);


            comando.ExecuteNonQuery();

            if (!objOrcamento.CodigoOrcamento.HasValue)
            {
                return ObterUltimo();
            }
            else
            {
                return objOrcamento;
            }

        }

        /// <summary>
        /// Obtém os orçamentos pelo Código do Orcamento.
        /// </summary>
        /// <param name="codigoOrcamento"></param>
        /// <returns></returns>
        public Orcamento Obter(int codigoOrcamento)
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

        public Orcamento Obter()
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
        public Orcamento ObterUltimo()
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
        public bool Excluir(int codigoOrcamento)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Orcamento where CodigoOrcamento = @codigoOrcamento", base.Conectar());

            SqlParameter parametroCodigoOrcamento = new SqlParameter("@codigoOrcamento", codigoOrcamento);
            parametroCodigoOrcamento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoOrcamento);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }



        public List<Orcamento> Consultar(OrcamentoDTO objOrcamentoDTO)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            SqlDataReader leitorDados;


            SqlParameter paramCodigoOrcamentoValor = new SqlParameter("@codigoOrcamentoValor", System.Data.DbType.Int32);
            if (objOrcamentoDTO.CodigoOrcamentoValor.HasValue)
                paramCodigoOrcamentoValor.Value = objOrcamentoDTO.CodigoOrcamentoValor.Value;
            else
                paramCodigoOrcamentoValor.Value = DBNull.Value;


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

            String sql = "select * from Orcamento";


            //Se o Nome do Plano, Inicio de Vigência e Fim de Vigência preenchidos
            if (objOrcamentoDTO.CodigoOrcamentoValor.HasValue && objOrcamentoDTO.InicioVigenciaValor.HasValue && objOrcamentoDTO.FimVigenciaValor.HasValue)
                sql += @" where CodigoOrcamento = @codigoOrcamentoValor and InicioVigencia >= @inicioVigenciaValor and FimVigencia <= @fimVigenciaValor";

            //Se apenas Nome do Plano e Inicio de Vigência preenchidos
            else if (objOrcamentoDTO.CodigoOrcamentoValor.HasValue && objOrcamentoDTO.InicioVigenciaValor.HasValue)
                sql += @" where CodigoOrcamento = @codigoOrcamentoValor and InicioVigencia >= @inicioVigenciaValor";

            //Se apenas Inicio de Vigência e Fim de Vigência preenchidos
            else if (objOrcamentoDTO.InicioVigenciaValor.HasValue && objOrcamentoDTO.FimVigenciaValor.HasValue)
                sql += @" where InicioVigencia >= @inicioVigenciaValor and FimVigencia <= @fimVigenciaValor";

            //Se apenas Fim de Vigência e Nome do Plano preenchidos
            else if (objOrcamentoDTO.FimVigenciaValor.HasValue && objOrcamentoDTO.CodigoOrcamentoValor.HasValue)
                sql += @" where FimVigencia <= @fimVigenciaValor and CodigoOrcamento = @codigoOrcamentoValor";

            //Se NomePlano preenchido
            else if (objOrcamentoDTO.CodigoOrcamentoValor.HasValue)
                sql += @" where CodigoOrcamento = @codigoOrcamentoValor";

            //Se apenas Inicio de Vigencia preenchido
            else if (objOrcamentoDTO.InicioVigenciaValor.HasValue)
                sql += @" where InicioVigencia >= @inicioVigenciaValor";

            //Se apenas Fim de Vigência preenchido
            else if (objOrcamentoDTO.FimVigenciaValor.HasValue)
                sql += @" where FimVigencia <= @fimVigenciaValor";

            sql += @" order by InicioVigencia asc, FimVigencia asc";

            comando.CommandText = sql;
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.Add(paramCodigoOrcamentoValor);
            comando.Parameters.Add(paramInicioVigenciaValor);
            comando.Parameters.Add(paramFimVigenciaValor);

            leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



            List<Orcamento> orcamentoLista = new List<Orcamento>();
            Orcamento objOrcamento;

            while (leitorDados.Read())
            {
                objOrcamento = new Orcamento();

                objOrcamento.CodigoOrcamento = Convert.ToInt32(leitorDados["CodigoOrcamento"]);
                //bjOrcamento.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objOrcamento.NomePlano = leitorDados["NomePlano"].ToString();
                objOrcamento.StatusPlano = leitorDados["StatusPlano"].ToString();
                objOrcamento.ValorOrcamento = Convert.ToDecimal(leitorDados["ValorOrcamento"]);
                objOrcamento.InicioVigencia = Convert.ToDateTime(leitorDados["InicioVigencia"]);
                objOrcamento.FimVigencia = Convert.ToDateTime(leitorDados["FimVigencia"]);


                orcamentoLista.Add(objOrcamento);
            }

            return orcamentoLista;

        }

        /// <summary>
        /// Retorna a lista de natureza de lancamento.
        /// </summary>
        /// <returns></returns>

        public List<Orcamento> Listar()
        {
            SqlCommand comando = new SqlCommand("select * from Orcamento ORDER BY NomePlano", base.Conectar());

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            List<Orcamento> listOrcamento = new List<Orcamento>();
            Orcamento objOrcamento = null;

            while (leitorDados.Read())
            {
                objOrcamento = new Orcamento();

                objOrcamento.CodigoOrcamento = Convert.ToInt32(leitorDados["CodigoOrcamento"]);
                objOrcamento.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objOrcamento.NomePlano = leitorDados["NomePlano"].ToString();
                objOrcamento.StatusPlano = leitorDados["StatusPlano"].ToString();
                objOrcamento.ValorOrcamento = Convert.ToDecimal(leitorDados["ValorOrcamento"]);
                objOrcamento.InicioVigencia = Convert.ToDateTime(leitorDados["InicioVigencia"]);
                objOrcamento.FimVigencia = Convert.ToDateTime(leitorDados["FimVigencia"]);

                listOrcamento.Add(objOrcamento);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return listOrcamento;
        }

    }
}