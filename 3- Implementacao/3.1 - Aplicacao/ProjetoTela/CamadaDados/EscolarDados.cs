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
    public class EscolarDados : BaseConnection
    {

        public Escolar Salvar(Escolar objEscolar)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            //Salva os dados de Contato do Escolar
            ContatoDados objContatoDados = new ContatoDados();
            objEscolar.Contato = objContatoDados.Salvar(objEscolar.Contato);

            objEscolar.Contato_CodigoContato = objEscolar.Contato.CodigoContato;

            if (!objEscolar.CodigoEscolar.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Escolar (CodigoAssistido, CodigoContato, Instituicao, NumInscricaoInstituicao, 
                                  MediaEscola, GrauEscolaridade, SerieCursada, DataMatricula, DataSaida, StatusSerie)
                    VALUES (@assistido_CodigoAssistido, @contato_CodigoContato, @instituicao, @numInscricaoInstituicao, @mediaEscola,
                            @grauEscolaridade, @serieCursada, @dataMatricula, @dataSaida, @statusSerie)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Escolar SET CodigoAssistido = @assistido_CodigoAssistido, 
                             CodigoContato = @contato_CodigoContato, Instituicao = @instituicao,
                             NumInscricaoInstituicao = @numInscricaoInstituicao, MediaEscola = @mediaEscola, 
                             GrauEscolaridade = @grauEscolaridade, SerieCursada = @serieCursada, DataMatricula = @dataMatricula,
                             DataSaida  = @dataSaida, StatusSerie = @statusSerie";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objEscolar.CodigoEscolar.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoEscolar", objEscolar.CodigoEscolar.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroAssistido_CodigoAssistido = new SqlParameter();
            if (objEscolar.Assistido_CodigoAssistido.HasValue)
            {
                parametroAssistido_CodigoAssistido.Value = objEscolar.Assistido_CodigoAssistido.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroAssistido_CodigoAssistido.Value = DBNull.Value;
                parametroAssistido_CodigoAssistido.ParameterName = "@assistido_CodigoAssistido";
                parametroAssistido_CodigoAssistido.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroContato_CodigoContato = new SqlParameter();
            if (objEscolar.Contato_CodigoContato.HasValue)
            {
                parametroContato_CodigoContato.Value = objEscolar.Contato.CodigoContato.Value;
                parametroContato_CodigoContato.ParameterName = "@contato_CodigoContato";
                parametroContato_CodigoContato.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroContato_CodigoContato.Value = DBNull.Value;
                parametroContato_CodigoContato.ParameterName = "@contato_CodigoContato";
                parametroContato_CodigoContato.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroInstituicao = new SqlParameter("@instituicao", objEscolar.Instituicao);
            parametroInstituicao.DbType = System.Data.DbType.String;

            SqlParameter parametroNumInscricaoInstituicao = new SqlParameter("@numInscricaoInstituicao", objEscolar.NumInscricaoInstituicao);
            parametroNumInscricaoInstituicao.DbType = System.Data.DbType.String;

            SqlParameter parametroMediaEscola = new SqlParameter("@mediaEscola", objEscolar.MediaEscola);
            parametroMediaEscola.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroGrauEscolaridade = new SqlParameter("@grauEscolaridade", objEscolar.GrauEscolaridade);
            parametroGrauEscolaridade.DbType = System.Data.DbType.String;

            SqlParameter parametroSerieCursada = new SqlParameter("@serieCursada", objEscolar.SerieCursada);
            parametroSerieCursada.DbType = System.Data.DbType.String;

            SqlParameter parametroDataMatricula = new SqlParameter("@dataMatricula", objEscolar.DataMatricula);
            parametroDataMatricula.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroDataSaida = new SqlParameter("@dataSaida", objEscolar.DataSaida);
            if (objEscolar.DataSaida.HasValue)
                parametroDataSaida.Value = objEscolar.DataSaida;
            else
                parametroDataSaida.Value = DBNull.Value;

            SqlParameter parametroStatusSerie = new SqlParameter("@statusSerie", objEscolar.StatusSerie);
            parametroStatusSerie.DbType = System.Data.DbType.String;

            comando.Parameters.Add(parametroAssistido_CodigoAssistido);
            comando.Parameters.Add(parametroContato_CodigoContato);
            comando.Parameters.Add(parametroInstituicao);
            comando.Parameters.Add(parametroNumInscricaoInstituicao);
            comando.Parameters.Add(parametroMediaEscola);
            comando.Parameters.Add(parametroGrauEscolaridade);
            comando.Parameters.Add(parametroSerieCursada);
            comando.Parameters.Add(parametroDataMatricula);
            comando.Parameters.Add(parametroDataSaida);
            comando.Parameters.Add(parametroStatusSerie);

            comando.ExecuteNonQuery();

            if (!objEscolar.CodigoEscolar.HasValue)
            {
                return ObterUltima();
            }
            else
            {
                return Obter(objEscolar.CodigoEscolar.Value);
            }

        }

        /// <summary>
        /// Obtém o ultimo código da escola Inserida
        /// </summary>
        /// <param name="codigoEscolar"></param>
        /// <returns></returns>
        public Escolar ObterUltima()
        {
            SqlCommand comando = new SqlCommand(@"SELECT TOP (1) * FROM Escolar ORDER BY CodigoEscolar DESC", base.Conectar());

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Escolar objEscolar = null;

            if (leitorDados.Read())
            {
                objEscolar = new Escolar();
                objEscolar.Assistido_CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                objEscolar.CodigoEscolar = Convert.ToInt32(leitorDados["CodigoEscolar"]);
                objEscolar.Contato_CodigoContato = Convert.ToInt32(leitorDados["CodigoContato"]);
                objEscolar.DataMatricula = Convert.ToDateTime(leitorDados["DataMatricula"]);
                if (leitorDados["DataMatricula"] != DBNull.Value)
                    objEscolar.DataSaida = Convert.ToDateTime(leitorDados["DataSaida"]);
                objEscolar.GrauEscolaridade = leitorDados["GrauEscolaridade"].ToString();
                objEscolar.Instituicao = leitorDados["Instituicao"].ToString();
                objEscolar.MediaEscola = Convert.ToInt32(leitorDados["MediaEscola"]);
                objEscolar.NumInscricaoInstituicao = leitorDados["NumInscricaoInstituicao"].ToString();
                objEscolar.SerieCursada = leitorDados["SerieCursada"].ToString();
                objEscolar.StatusSerie = leitorDados["StatusSerie"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            ContatoDados objContatoDados = new ContatoDados();
            objEscolar.Contato = objContatoDados.Obter(objEscolar.Contato_CodigoContato.Value);


            return objEscolar;
        }

        /// <summary>
        /// Obtém os dados escolares pelo Código Escolar.
        /// </summary>
        /// <param name="codigoEscolar"></param>
        /// <returns></returns>
        public Escolar Obter(int codigoEscolar)
        {
            SqlCommand comando = new SqlCommand("select * from Escolar where CodigoEscolar = @codigoEscolar", base.Conectar());
            SqlParameter parametroCodigoEscolar = new SqlParameter("@codigoEscolar", codigoEscolar);
            parametroCodigoEscolar.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoEscolar);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Escolar objEscolar = null;

            if (leitorDados.Read())
            {
                objEscolar = new Escolar();

                objEscolar.CodigoEscolar = codigoEscolar;
                objEscolar.Assistido_CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                objEscolar.Contato_CodigoContato = Convert.ToInt32(leitorDados["CodigoContato"]);
                objEscolar.Instituicao = leitorDados["Instituicao"].ToString();
                objEscolar.NumInscricaoInstituicao = leitorDados["NumInscricaoInstituicao"].ToString();
                objEscolar.MediaEscola = Convert.ToDecimal(leitorDados["MediaEscola"]);
                objEscolar.GrauEscolaridade = leitorDados["GrauEscolaridade"].ToString();
                objEscolar.SerieCursada = leitorDados["SerieCursada"].ToString();
                objEscolar.DataMatricula = Convert.ToDateTime(leitorDados["DataMatricula"]);
                if (leitorDados["DataMatricula"] != DBNull.Value)
                    objEscolar.DataSaida = Convert.ToDateTime(leitorDados["DataSaida"]);
                objEscolar.StatusSerie = leitorDados["StatusSerie"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            ContatoDados objContatoDados = new ContatoDados();
            objEscolar.Contato = objContatoDados.Obter(objEscolar.Contato_CodigoContato.Value);

            return objEscolar;
        }

        /// <summary>
        /// Exclui os dados escolar pelo seu código
        /// </summary>
        public bool Excluir(int codigoEscolar, int codigoContato)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Escolar where CodigoEscolar = @codigoEscolar", base.Conectar());

            SqlParameter parametroCodigoEscolar = new SqlParameter("@codigoEscolar", codigoEscolar);
            parametroCodigoEscolar.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoEscolar);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            ContatoDados objContatoDados = new ContatoDados();
            objContatoDados.Excluir(codigoContato);

            return execucao;
        }

        /// <summary>
        /// Retorna uma lista de Escolar apartir dos dados informados no ParametrosConsultarEscolarDTO
        /// </summary>
        public List<GradeConsultarEscolarDTO> Consultar(ParametroConsultarEscolarDTO objParametro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            SqlDataReader leitorDados;

            String sql = "select * from Escolar E inner join Pessoa P on P.CodigoPessoa = E.CodigoAssistido where ";

            SqlParameter paramCodigoAssistido = new SqlParameter("@codigoAssistido", System.Data.DbType.Int32);
            if (objParametro.CodigoAssistido.HasValue)
            {
                paramCodigoAssistido.Value = objParametro.CodigoAssistido.Value;
                sql += "CodigoAssistido = @codigoAssistido and ";
            }
            else
            {
                paramCodigoAssistido.Value = DBNull.Value;
            }

            SqlParameter paramGrauEscolaridade = new SqlParameter("@grauEscolaridade", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objParametro.GrauEscolaridade))
            {
                paramGrauEscolaridade.Value = objParametro.GrauEscolaridade;
                sql += "GrauEscolaridade = @grauEscolaridade and ";
            }
            else
            {
                paramGrauEscolaridade.Value = DBNull.Value;
            }

            if (sql.EndsWith("where "))
                sql = sql.Replace("where ", "");
            else if (sql.EndsWith("and "))
                sql = sql.Remove(sql.Length - 4);

            if (sql.Contains("where"))
                sql += " and P.Ativo = 1";
            else
                sql += " where P.Ativo = 1";

            sql += " order by P.Nome";
            comando.CommandText = sql;
            comando.CommandType = System.Data.CommandType.Text;

            comando.Parameters.Add(paramCodigoAssistido);
            comando.Parameters.Add(paramGrauEscolaridade);

            leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            List<GradeConsultarEscolarDTO> gradeConsultarEscolarDTOLista = new List<GradeConsultarEscolarDTO>();
            GradeConsultarEscolarDTO item;

            while (leitorDados.Read())
            {
                item = new GradeConsultarEscolarDTO();

                item.NomeAssistido = leitorDados["Nome"].ToString();
                item.CodigoEscolar = Convert.ToInt32(leitorDados["CodigoEscolar"]);
                item.CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                item.NomeInstituicao = leitorDados["Instituicao"].ToString();
                item.GrauEscolaridade = leitorDados["GrauEscolaridade"].ToString();
                item.SerieCursada = leitorDados["SerieCursada"].ToString();
                item.StatusSerie = leitorDados["StatusSerie"].ToString();

                gradeConsultarEscolarDTOLista.Add(item);
            }

            return gradeConsultarEscolarDTOLista;
        }
    }
}