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
    public class AlimentacaoDados : BaseConnection
    {
 
    /// <summary>
    /// Este método salva a Alimentacao.
    /// </summary>
    /// <param name="objAlimentacao"></param>
    /// <returns></returns>
        public Alimentacao Salvar(Alimentacao objAlimentacao)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objAlimentacao.CodigoAlimentacao.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Alimentacao (Assistido_CodigoAssistido, DiaSemana, Periodo, Horario, Alimento, PorcaoAlimento, Diretiva)
                    VALUES (@assistido_CodigoAssistido, @diaSemana, @periodo, @horario, @alimento, @porcaoAlimento, @diretiva)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Alimentacao SET Assistido_CodigoAssistido = @assistido_CodigoAssistido, DiaSemana = @diaSemana,
                        Periodo = @periodo, Horario = @horario, Alimento = @alimento, PorcaoAlimento = @porcaoAlimento, Diretiva = @diretiva
                        WHERE (CodigoAlimentacao = @codigoAlimentacao)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objAlimentacao.CodigoAlimentacao.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoAlimentacao", objAlimentacao.CodigoAlimentacao.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroAssistido_CodigoAssistido = new SqlParameter();
            if (objAlimentacao.Assistido_CodigoAssistido.HasValue)
            {
                parametroAssistido_CodigoAssistido.Value = objAlimentacao.Assistido_CodigoAssistido.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroAssistido_CodigoAssistido.Value = DBNull.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroDiaSemana = new SqlParameter("@diaSemana", objAlimentacao.DiaSemana);
            parametroDiaSemana.DbType = System.Data.DbType.String;

            SqlParameter parametroPeriodo = new SqlParameter("@periodo", objAlimentacao.Periodo);
            parametroPeriodo.DbType = System.Data.DbType.String;

            SqlParameter parametroHorario = new SqlParameter("@horario", objAlimentacao.Horario);
            parametroHorario.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroAlimento = new SqlParameter("@alimento", objAlimentacao.Alimento);
            parametroAlimento.DbType = System.Data.DbType.String;

            SqlParameter parametroPorcaoAlimento = new SqlParameter("@porcaoAlimento", objAlimentacao.PorcaoAlimento);
            parametroAlimento.DbType = System.Data.DbType.String;

            SqlParameter parametroDiretiva = new SqlParameter("@diretiva", objAlimentacao.PorcaoAlimento);
            parametroAlimento.DbType = System.Data.DbType.String;

            comando.Parameters.Add(parametroAssistido_CodigoAssistido);
            comando.Parameters.Add(parametroDiaSemana);
            comando.Parameters.Add(parametroPeriodo);
            comando.Parameters.Add(parametroHorario);
            comando.Parameters.Add(parametroAlimento);
            comando.Parameters.Add(parametroPorcaoAlimento);
            comando.Parameters.Add(parametroDiretiva);

            comando.ExecuteNonQuery();

            //TODO: retorno entidade alimentacao com o Código da Alimentacao Preenchido
            return objAlimentacao;
        }

            /// <summary>
            /// Obtém a Alimentacao pelo seu Código de Alimentacao
        /// </summary>
        /// <param name="codigoAlimentacao"></param>
        /// <returns></returns>
        public Alimentacao ObterAlimentacao(int codigoAlimentacao)
        {
            SqlCommand comando = new SqlCommand("select * from Alimentacao where CodigoAlimentacao = @codigoAlimentacao", base.Conectar());
            SqlParameter parametroCodigoAlimentacao = new SqlParameter("@codigoAlimentacao", codigoAlimentacao);
            parametroCodigoAlimentacao.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAlimentacao);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Alimentacao objAlimentacao = null;

            if (leitorDados.Read())
            {
                objAlimentacao = new Alimentacao();

                objAlimentacao.CodigoAlimentacao = codigoAlimentacao;
                objAlimentacao.Assistido_CodigoAssistido = Convert.ToInt32(leitorDados["Assistido_CodigoAssistido"]);
                objAlimentacao.DiaSemana = leitorDados["DiaSemana"].ToString();
                objAlimentacao.Periodo = leitorDados["Periodo"].ToString();
                objAlimentacao.Horario = Convert.ToDateTime(leitorDados["Horario"]);
                objAlimentacao.Alimento = leitorDados["Alimento"].ToString();
                objAlimentacao.PorcaoAlimento = leitorDados["PorcaoAlimento"].ToString();
                objAlimentacao.Diretiva = leitorDados["Diretiva"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objAlimentacao;
        }

        /// <summary>
        /// Exclui uma Alimentacao pelo seu código
        /// </summary>
        public bool ExcluirAlimentacao(int codigoAlimentacao)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Alimentacao where CodigoAlimentacao = @codigoAlimentacao", base.Conectar());

            SqlParameter parametroCodigoAlimentacao = new SqlParameter("@codigoAlimentacao", codigoAlimentacao);
            parametroCodigoAlimentacao.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAlimentacao);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;

            /* }
       
            /// <summary>
            /// Consulta uma Alimentacao -Terminar. Procurar entendimento.
            /// </summary>
            public List<Alimentacao> ConsultarAlimentacao(AlimentacaoDTO objAlimentacaoDTO)
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

           String sql = "select * from Alimentacao";

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

           return financasLista;*/
   }
 
    }
}

