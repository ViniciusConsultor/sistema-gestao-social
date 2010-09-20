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
    public class VisitacaoDados : BaseConnection
    {

        public Visitacao Salvar(Visitacao objVisitacao)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objVisitacao.CodigoVisitacao.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Visitacao (Assistido_CodigoAssistido, PessoaVisitante, AssistidoVisitado, DataVisita, HoraInicioVisita,
                                  HoraFimVisita, MotivoVisita, FeedBackVisita, StatusVisita)
                    VALUES (@assistido_CodigoAssistido, @pessoaVisitante, @assistidoVisitado, @dataVisita, @horaInicioVisita,
                           @horaFimVisita, @motivoVisita, @feedBackVisita, @statusVisita )";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Visitacao SET Assistido_CodigoAssistido = @sssistido_CodigoAssistido, PessoaVisitante = @pessoaVisitante,
                             AssistidoVisitado = @assistidoVisitado, DataVisita = @dataVisita, HoraInicioVisita = @horaInicioVisita,
                             HoraFimVisita = @horaFimVisita, MotivoVisita = @motivoVisita, FeedBackVisita = @feedBackVisita,
                             StatusVisita = @statusVisita)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objVisitacao.CodigoVisitacao.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoVisitacao", objVisitacao.CodigoVisitacao.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroAssistido_CodigoAssistido = new SqlParameter();
            if (objVisitacao.Assistido_CodigoAssistido.HasValue)
            {
                parametroAssistido_CodigoAssistido.Value = objVisitacao.Assistido_CodigoAssistido.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroAssistido_CodigoAssistido.Value = DBNull.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroPessoaVisitante = new SqlParameter("@pessoaVisitante", objVisitacao.PessoaVisitante);
            parametroPessoaVisitante.DbType = System.Data.DbType.String;

            SqlParameter parametroAssistidoVisitado = new SqlParameter("@assistidoVisitado", objVisitacao.AssistidoVisitado);
            parametroAssistidoVisitado.DbType = System.Data.DbType.String;

            SqlParameter parametroDataVisita = new SqlParameter("@dataVisita", objVisitacao.DataVisita);
            parametroDataVisita.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroHoraInicioVisita = new SqlParameter("@horaInicioVisita", objVisitacao.HoraInicioVisita);
            parametroHoraInicioVisita.DbType = System.Data.DbType.DateTime;


            SqlParameter parametroHoraFimVisita = new SqlParameter("@horaFimVisita", objVisitacao.HoraFimVisita);
            parametroHoraFimVisita.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroMotivoVisita = new SqlParameter("@motivoVisita", objVisitacao.MotivoVisita);
            parametroMotivoVisita.DbType = System.Data.DbType.String;


            SqlParameter parametroFeedBackVisita = new SqlParameter("@feedBackVisita", objVisitacao.FeedBackVisita);
            parametroFeedBackVisita.DbType = System.Data.DbType.String;

            SqlParameter parametroStatusVisita = new SqlParameter("@statusVisita", objVisitacao.StatusVisita);
            parametroStatusVisita.DbType = System.Data.DbType.String;



            comando.Parameters.Add(parametroAssistido_CodigoAssistido);
            comando.Parameters.Add(parametroPessoaVisitante);
            comando.Parameters.Add(parametroAssistidoVisitado);
            comando.Parameters.Add(parametroDataVisita);
            comando.Parameters.Add(parametroHoraInicioVisita);
            comando.Parameters.Add(parametroHoraFimVisita);
            comando.Parameters.Add(parametroMotivoVisita);
            comando.Parameters.Add(parametroFeedBackVisita);
            comando.Parameters.Add(parametroStatusVisita);


            comando.ExecuteNonQuery();

            //TODO: retorno entidade Visitacao com o Código do Visitacao Preenchido
            return objVisitacao;
        }

        /// <summary>
        /// Obtém a visita pelo Código da visita.
        /// </summary>
        /// <param name="codigoVisitacao"></param>
        /// <returns></returns>
        public Visitacao ObterVisitacao(int codigoVisitacao)
        {
            SqlCommand comando = new SqlCommand("select * from Visitacao where CodigoVisitacao = @codigoVisitacao", base.Conectar());
            SqlParameter parametroCodigoVisitacao = new SqlParameter("@codigoVisitacao", codigoVisitacao);
            parametroCodigoVisitacao.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoVisitacao);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Visitacao objVisitacao = null;

            if (leitorDados.Read())
            {
                objVisitacao = new Visitacao();

                objVisitacao.CodigoVisitacao = codigoVisitacao;
                objVisitacao.Assistido_CodigoAssistido = Convert.ToInt32(leitorDados["Assistido_CodigoAssistido"]);
                objVisitacao.PessoaVisitante = leitorDados["PessoaVisitante"].ToString();
                objVisitacao.AssistidoVisitado = leitorDados["AssistidoVisitado"].ToString();
                objVisitacao.DataVisita = Convert.ToDateTime(leitorDados["DataVisita"]);
                objVisitacao.HoraInicioVisita = Convert.ToDateTime(leitorDados["HoraInicioVisita"]);
                objVisitacao.HoraFimVisita = Convert.ToDateTime(leitorDados["HoraFimVisita"]);
                objVisitacao.MotivoVisita = leitorDados["MotivoVisita"].ToString();
                objVisitacao.FeedBackVisita = leitorDados["FeedBackVisita"].ToString();
                objVisitacao.StatusVisita = leitorDados["StatusVisita"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objVisitacao;
        }

        /// <summary>
        /// Exclui uma Visita pelo seu código
        /// </summary>
        public bool ExcluirVisitacao(int codigoVisitacao)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Visitacao where CodigoVisitacao = @codigoVisitacao", base.Conectar());

            SqlParameter parametroCodigoVisitacao = new SqlParameter("@codigoVisitacao", codigoVisitacao);
            parametroCodigoVisitacao.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoVisitacao);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

    }
}