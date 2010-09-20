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
    public class PatrocinadorDados : BaseConnection
    {

        public Patrocinador Salvar(Patrocinador objPatrocinador)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objPatrocinador.CodigoPatrocinador.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Patrocinador (Pessoa_CodigoPessoa, Empresa, CNPJ, RamoAtividade, ValorContribuicao, PeriodicidadeContribuicao)
                    VALUES (@pessoa_CodigoPessoa, @empresa, @cnpj, @ramoAtividade, @valorContribuicao, @periodicidadeContribuicao)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Patrocinador SET Pessoa_CodigoPessoa = @pessoa_CodigoPessoa, Empresa = @empresa, CNPJ = @cnpj,
                                RamoAtividade = @ramoAtividade, ValorContribuicao = @valorContribuicao,
                                PeriodicidadeContribuicao = @periodicidadeContribuicao)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objPatrocinador.CodigoPatrocinador.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoPatrocinador", objPatrocinador.CodigoPatrocinador.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroPessoa_CodigoPessoa = new SqlParameter();
            if (objPatrocinador.Pessoa_CodigoPessoa.HasValue)
            {
                parametroPessoa_CodigoPessoa.Value = objPatrocinador.Pessoa_CodigoPessoa.Value;
                parametroPessoa_CodigoPessoa.ParameterName = "@pessoa_CodigoPessoa";
                parametroPessoa_CodigoPessoa.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroPessoa_CodigoPessoa.Value = DBNull.Value;
                parametroPessoa_CodigoPessoa.ParameterName = "@pessoa_CodigoPessoa";
                parametroPessoa_CodigoPessoa.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroEmpresa = new SqlParameter("@empresa", objPatrocinador.Empresa);
            parametroEmpresa.DbType = System.Data.DbType.String;

            SqlParameter parametroCNPJ = new SqlParameter("@cnpj", objPatrocinador.CNPJ);
            parametroCNPJ.DbType = System.Data.DbType.String;

            SqlParameter parametroRamoAtividade = new SqlParameter("@ramoAtividade", objPatrocinador.RamoAtividade);
            parametroRamoAtividade.DbType = System.Data.DbType.String;

            SqlParameter parametroValorContribuicao = new SqlParameter("@valorContribuicao", objPatrocinador.ValorContribuicao);
            parametroValorContribuicao.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroPeriodicidadeContribuicao = new SqlParameter("@periodicidadeContribuicao", objPatrocinador.PeriodicidadeContribuicao);
            parametroPeriodicidadeContribuicao.DbType = System.Data.DbType.String;

                       
            comando.Parameters.Add(parametroPessoa_CodigoPessoa);
            comando.Parameters.Add(parametroEmpresa);
            comando.Parameters.Add(parametroCNPJ);
            comando.Parameters.Add(parametroRamoAtividade);
            comando.Parameters.Add(parametroValorContribuicao);
            comando.Parameters.Add(parametroPeriodicidadeContribuicao);


            comando.ExecuteNonQuery();

            //TODO: retorno entidade Patrocinador com o Código do patrocinador Preenchido
            return objPatrocinador;
        }

        /// <summary>
        /// Obtém o Patrocinador pelo Código do Patrocinador
        /// </summary>
        /// <param name="codigoPatrocinador"></param>
        /// <returns></returns>
        public Patrocinador ObterPatrocinador(int codigoPatrocinador)
        {
            SqlCommand comando = new SqlCommand("select * from Patrocinador where CodigoPatrocinador = @codigoPatrocinador", base.Conectar());
            SqlParameter parametroCodigoPatrocinador = new SqlParameter("@codigoPatrocinador", codigoPatrocinador);
            parametroCodigoPatrocinador.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoPatrocinador);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Patrocinador objPatrocinador = null;

            if (leitorDados.Read())
            {
                objPatrocinador = new Patrocinador();

                objPatrocinador.CodigoPatrocinador = codigoPatrocinador;
                objPatrocinador.Pessoa_CodigoPessoa = Convert.ToInt32(leitorDados["Pessoa_CodigoPessoa"]);
                objPatrocinador.Empresa = leitorDados["Empresa"].ToString();
                objPatrocinador.CNPJ = leitorDados["CNPJ"].ToString();
                objPatrocinador.RamoAtividade = leitorDados["RamoAtividade"].ToString();
                objPatrocinador.ValorContribuicao = Convert.ToDecimal(leitorDados["ValorContribuicao"]);
                objPatrocinador.PeriodicidadeContribuicao = leitorDados["PeriodicidadeContribuicao"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objPatrocinador;
        }

        /// <summary>
        /// Exclui um Patrocinador pelo seu código
        /// </summary>
        public bool ExcluirPatrocinador(int codigoPatrocinador)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Patrocinador where CodigoPatrocinador = @codigoPatrocinador", base.Conectar());

            SqlParameter parametroCodigoPatrocinador = new SqlParameter("@codigoPatrocinador", codigoPatrocinador);
            parametroCodigoPatrocinador.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoPatrocinador);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

    }
}