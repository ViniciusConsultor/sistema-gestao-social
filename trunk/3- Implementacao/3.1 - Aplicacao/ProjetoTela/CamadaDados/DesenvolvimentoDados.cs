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
                    @"INSERT INTO Desenvolvimento (CodigoAssistido, Atividade, TipoAtividade,  DescricaoAtividade,
                                  Valor, DataInicio, DataFim, CargaHoraria, StatusAtividade)
                    VALUES (@codigoAssistido, @atividade, @tipoAtividade, @descricaoAtividade, @valor,
                           @dataInicio,@dataFim, @cargaHoraria, @statusAtividade)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Desenvolvimento SET CodigoAssistido = @codigoAssistido, Atividade = @atividade,
                             TipoAtividade = @tipoAtividade, DescricaoAtividade = @descricaoAtividade, Valor = @valor,
                             DataInicio = @dataInicio, DataFim = @dataFim, CargaHoraria = @cargaHoraria, StatusAtividade = @statusAtividade
                             WHERE (CodigoDesenvolvimento = @codigoDesenvolvimento)"; 
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objDesenvolvimento.CodigoDesenvolvimento.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoDesenvolvimento", objDesenvolvimento.CodigoDesenvolvimento.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroCodigoAssistido = new SqlParameter();
            if (objDesenvolvimento.CodigoAssistido.HasValue)
            {
                parametroCodigoAssistido.Value = objDesenvolvimento.CodigoAssistido.Value;
                parametroCodigoAssistido.ParameterName = "@codigoAssistido";
                parametroCodigoAssistido.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroCodigoAssistido.Value = DBNull.Value;
                parametroCodigoAssistido.ParameterName = "@codigoAssistido";
                parametroCodigoAssistido.DbType = System.Data.DbType.Int32;
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



            comando.Parameters.Add(parametroCodigoAssistido);
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
            return ObterUltimoDesenvolvimentoInserido();
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
                objDesenvolvimento.CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
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

        public Desenvolvimento ObterUltimoDesenvolvimentoInserido()
        {
            SqlCommand comando = new SqlCommand(@"SELECT TOP (1) * FROM Desenvolvimento ORDER BY CodigoDesenvolvimento DESC", base.Conectar());
            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Desenvolvimento objDesenvolvimento = null;

            if (leitorDados.Read())
            {
                objDesenvolvimento = new Desenvolvimento();

                objDesenvolvimento.CodigoDesenvolvimento = Convert.ToInt32(leitorDados["CodigoDesenvolvimento"]);
                objDesenvolvimento.CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                objDesenvolvimento.Atividade = leitorDados["Atividade"].ToString();
                objDesenvolvimento.TipoAtividade = leitorDados["TipoAtividade"].ToString();
                objDesenvolvimento.DescricaoAtividade = leitorDados["DescricaoAtividade"].ToString();
                objDesenvolvimento.Valor = Convert.ToDecimal(leitorDados["Valor"]);
                objDesenvolvimento.CargaHoraria = leitorDados["CargaHoraria"].ToString();
                objDesenvolvimento.StatusAtividade = leitorDados["StatusAtividade"].ToString();

                if (leitorDados["DataInicio"] != DBNull.Value)
                    objDesenvolvimento.DataInicio = Convert.ToDateTime(leitorDados["DataInicio"]);

                if (leitorDados["DataFim"] != DBNull.Value)
                    objDesenvolvimento.DataFim = Convert.ToDateTime(leitorDados["DataFim"]);



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

        public List<DesenvolvimentoAssistidoDTO> ConsultarDesenvolvimento(DesenvolvimentoDTO objDesenvolvimentoDTO)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            SqlDataReader leitorDados;

            SqlParameter paramAssistidoValor = new SqlParameter("@assistidoValor", System.Data.SqlDbType.Int);
            if (objDesenvolvimentoDTO.AssistidoValor.HasValue)
                paramAssistidoValor.Value = objDesenvolvimentoDTO.AssistidoValor.Value;
            else
                paramAssistidoValor.Value = DBNull.Value;

            SqlParameter paramDataInicioValor = new SqlParameter("@dataInicioValor", System.Data.SqlDbType.DateTime);
            if (objDesenvolvimentoDTO.DataInicioValor.HasValue)
                paramDataInicioValor.Value = objDesenvolvimentoDTO.DataInicioValor.Value;
            else
                paramDataInicioValor.Value = DBNull.Value;

            SqlParameter paramDataFimValor = new SqlParameter("@dataFimValor", System.Data.SqlDbType.DateTime);
            if (objDesenvolvimentoDTO.DataFimValor.HasValue)
                paramDataFimValor.Value = objDesenvolvimentoDTO.DataFimValor.Value;
            else
                paramDataFimValor.Value = DBNull.Value;


            String sql = "select * from Desenvolvimento PR inner join Pessoa P on P.CodigoPessoa = PR.CodigoAssistido";

            //Se o Assistido, Data Inicio e Data Fim preenchidos
            if (objDesenvolvimentoDTO.AssistidoValor.HasValue && objDesenvolvimentoDTO.DataInicioValor.HasValue && objDesenvolvimentoDTO.DataFimValor.HasValue)
                sql += @" where CodigoAssistido = @assistidoValor and DataInicio >= @dataInicioValor and DataFim <= @dataFimValor";

            //Se apenas Assistido  e Data Inicio preenchidos
            else if (objDesenvolvimentoDTO.AssistidoValor.HasValue && objDesenvolvimentoDTO.DataInicioValor.HasValue)
                sql += @" where CodigoAssistido = @assistidoValor and DataInicio >= @dataInicioValor";

            //Se apenas Data Inicio e Data Fim preenchidos
            else if (objDesenvolvimentoDTO.DataInicioValor.HasValue && objDesenvolvimentoDTO.DataFimValor.HasValue)
                sql += @" where DataInicio >= @dataInicioValor and DataFim <= @dataFimValor";

            //Se apenas Data Fim e Assistidos preenchidos
            else if (objDesenvolvimentoDTO.DataFimValor.HasValue && objDesenvolvimentoDTO.AssistidoValor.HasValue)
                sql += @" where DataFim <= @dataFimValor and CodigoAssistido = @assistidoValor";

            //Se apenas Data Fim preenchido
            else if (objDesenvolvimentoDTO.DataFimValor.HasValue)
                sql += @" where DataFim <= @dataFimValor";

            //Se apenas Assistido preenchido
            else if (objDesenvolvimentoDTO.AssistidoValor.HasValue)
                sql += @" where CodigoAssistido = @assistidoValor";

            //Se apenas Data Inicio
            else if (objDesenvolvimentoDTO.DataInicioValor.HasValue)
                sql += @" where DataInicio >= @dataInicioValor";

            comando.CommandText = sql;
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.Add(paramAssistidoValor);
            comando.Parameters.Add(paramDataInicioValor);
            comando.Parameters.Add(paramDataFimValor);

            leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



            List<DesenvolvimentoAssistidoDTO> procedimentosAssistidoDTOLista = new List<DesenvolvimentoAssistidoDTO>();
            DesenvolvimentoAssistidoDTO objDesenvolvimentoAssistidoDTO;

            while (leitorDados.Read())
            {
                objDesenvolvimentoAssistidoDTO = new DesenvolvimentoAssistidoDTO();

                objDesenvolvimentoAssistidoDTO.NomeAssistido = leitorDados["Nome"].ToString();
                objDesenvolvimentoAssistidoDTO.CodigoDesenvolvimento = Convert.ToInt32(leitorDados["CodigoDesenvolvimento"]);
                objDesenvolvimentoAssistidoDTO.CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                objDesenvolvimentoAssistidoDTO.TipoAtividade = leitorDados["TipoAtividade"].ToString();
                objDesenvolvimentoAssistidoDTO.Atividade = leitorDados["Atividade"].ToString();
                objDesenvolvimentoAssistidoDTO.DescricaoAtividade = leitorDados["DescricaoAtividade"].ToString();
                objDesenvolvimentoAssistidoDTO.StatusAtividade = leitorDados["StatusAtividade"].ToString();
                objDesenvolvimentoAssistidoDTO.Valor = Convert.ToDecimal(leitorDados["Valor"]);
                objDesenvolvimentoAssistidoDTO.CargaHoraria = leitorDados["CargaHoraria"].ToString();

                if (leitorDados["DataInicio"] != DBNull.Value)
                    objDesenvolvimentoAssistidoDTO.DataInicio = Convert.ToDateTime(leitorDados["DataInicio"]);

                if (leitorDados["DataFim"] != DBNull.Value)
                    objDesenvolvimentoAssistidoDTO.DataFim = Convert.ToDateTime(leitorDados["DataFim"]);


                procedimentosAssistidoDTOLista.Add(objDesenvolvimentoAssistidoDTO);
            }

            return procedimentosAssistidoDTOLista;
        }

    }
}