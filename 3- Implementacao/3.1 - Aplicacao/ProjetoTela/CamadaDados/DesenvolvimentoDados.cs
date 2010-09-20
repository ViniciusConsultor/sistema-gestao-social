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
    public class DesenvolvimentoDados : BaseConnection
    {

        public Desenvolvimento Salvar(Desenvolvimento objDesenvolvimento)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objDesenvolvimento.CodigoDesenvolvimento.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Desenvolvimento (Assistido_CodigoAssistido, Atividade, TipoAtividade,  DescricaoAtividade,
                                  Valor, DataInicio, DataFim, CargaHoraria, StatusAtividade)
                    VALUES (@assistido_CodigoAssistido, @atividade, @tipoAtividade, @descricaoAtividade, @valor,
                           @dataInicio,@dataFim, @lcargaHoraria, @statusAtividade)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Desenvolvimento SET Assistido_CodigoAssistido = @sssistido_CodigoAssistido, Atividade = @atividade,
                             TipoAtividade = @tipoAtividade, DescricaoAtividade = @descricaoAtividade, Valor = @valor,
                             DataInicio = @dataInicio, DataFim = @dataFim, CargaHoraria = @cargaHoraria, StatusAtividade = @statusAtividade)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objDesenvolvimento.CodigoDesenvolvimento.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoDesenvolvimento", objDesenvolvimento.CodigoDesenvolvimento.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroAssistido_CodigoAssistido = new SqlParameter();
            if (objDesenvolvimento.Assistido_CodigoAssistido.HasValue)
            {
                parametroAssistido_CodigoAssistido.Value = objDesenvolvimento.Assistido_CodigoAssistido.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroAssistido_CodigoAssistido.Value = DBNull.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroAtividade = new SqlParameter("@atividade", objDesenvolvimento.Atividade);
            parametroAtividade.DbType = System.Data.DbType.String;

            SqlParameter parametroTipoAtividade = new SqlParameter("@tipoAtividade", objDesenvolvimento.TipoAtividade);
            parametroTipoAtividade.DbType = System.Data.DbType.String;

            SqlParameter parametroDescricaoAtividade = new SqlParameter("@descricaoAtividade", objDesenvolvimento.DescricaoAtividade);
            parametroDescricaoAtividade.DbType = System.Data.DbType.String;

            SqlParameter parametroValor = new SqlParameter("@valor", objDesenvolvimento.Valor);
            parametroValor.DbType = System.Data.DbType.Decimal;


            SqlParameter parametroDataInicio = new SqlParameter("@dataInicio", objDesenvolvimento.DataInicio);
            parametroDataInicio.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroDataFim = new SqlParameter("@dataFim", objDesenvolvimento.DataFim);
            parametroDataFim.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroCargaHoraria = new SqlParameter("@cargaHoraria", objDesenvolvimento.CargaHoraria);
            parametroCargaHoraria.DbType = System.Data.DbType.String;

            SqlParameter parametroStatusAtividade = new SqlParameter("@statusAtividade", objDesenvolvimento.StatusAtividade);
            parametroStatusAtividade.DbType = System.Data.DbType.String;



            comando.Parameters.Add(parametroAssistido_CodigoAssistido);
            comando.Parameters.Add(parametroAtividade);
            comando.Parameters.Add(parametroTipoAtividade);
            comando.Parameters.Add(parametroDescricaoAtividade);
            comando.Parameters.Add(parametroValor);
            comando.Parameters.Add(parametroDataInicio);
            comando.Parameters.Add(parametroDataFim);
            comando.Parameters.Add(parametroCargaHoraria);
            comando.Parameters.Add(parametroStatusAtividade);


            comando.ExecuteNonQuery();

            //TODO: retorno entidade Desenvolvimento com o Código do Desenvolvimento Preenchido
            return objDesenvolvimento;
        }

        /// <summary>
        /// Obtém o Desenvolvimento pelo Código do Desenvolvimento
        /// </summary>
        /// <param name="codigoDesenvolvimento"></param>
        /// <returns></returns>
        public Desenvolvimento ObterDesenvolvimento(int codigoDesenvolvimento)
        {
            SqlCommand comando = new SqlCommand("select * from Desenvolvimento where CodigoDesenvolvimento = @codigoDesenvolvimento", base.Conectar());
            SqlParameter parametroCodigoDesenvolvimento = new SqlParameter("@codigoDesenvolvimento", codigoDesenvolvimento);
            parametroCodigoDesenvolvimento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoDesenvolvimento);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Desenvolvimento objDesenvolvimento = null;

            if (leitorDados.Read())
            {
                objDesenvolvimento = new Desenvolvimento();

                objDesenvolvimento.CodigoDesenvolvimento = codigoDesenvolvimento;
                objDesenvolvimento.Assistido_CodigoAssistido = Convert.ToInt32(leitorDados["Assistido_CodigoAssistido"]);
                objDesenvolvimento.Atividade = leitorDados["Atividade"].ToString();
                objDesenvolvimento.TipoAtividade = leitorDados["TipoAtividade"].ToString();
                objDesenvolvimento.DescricaoAtividade = leitorDados["DescricaoAtividade"].ToString();
                objDesenvolvimento.Valor = Convert.ToDecimal(leitorDados["Valor"]);
                objDesenvolvimento.DataInicio = Convert.ToDateTime(leitorDados["DataInicio"]);
                objDesenvolvimento.DataFim = Convert.ToDateTime(leitorDados["DataFim"]);
                objDesenvolvimento.CargaHoraria = leitorDados["CargaHoraria"].ToString();
                objDesenvolvimento.StatusAtividade = leitorDados["StatusAtividade"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objDesenvolvimento;
        }

        /// <summary>
        /// Exclui um Desenvolvimento pelo seu código
        /// </summary>
        public bool ExcluirDesenvolvimento(int codigoDesenvolvimento)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Desenvolvimento where CodigoDesenvolvimento = @codigoDesenvolvimento", base.Conectar());

            SqlParameter parametroCodigoDesenvolvimento = new SqlParameter("@codigoDesenvolvimento", codigoDesenvolvimento);
            parametroCodigoDesenvolvimento.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoDesenvolvimento);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

    }
}