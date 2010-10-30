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


            if (!objEscolar.CodigoEscolar.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Escolar (CodigoAssistido, CodigoContato, Instituicao, NumInscricaoInstituicao, 
                                  MediaEscola, GrauEscolaridade, SerieCursada, DataMatricula, DataSaida, StatusMatricula, FormatoAnoLetivo,
                                  Materia, Professor, Nota, StatusMateria, ParteAnoLetivo)
                    VALUES (@assistido_CodigoAssistido, @contato_CodigoContato, @instituicao, @numInscricaoInstituicao, @mediaEscola,
                            @grauEscolaridade, @serieCursada, @dataMatricula, @dataSaida, @statusMatricula, @formatoAnoLetivo, @materia,
                            @professor, @note, @statusMateria, @parteAnoLetivo)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Escolar SET CodigoAssistido = @sssistido_CodigoAssistido, 
                             CodigoContato = @contato_CodigoContato, Instituicao = @instituicao,
                             NumInscricaoInstituicao = @numInscricaoInstituicao, MediaEscola = @mediaEscola, 
                             GrauEscolaridade = @grauEscolaridade, SerieCursada = @serieCursada, DataMatricula = @dataMatricula,
                             DataSaida  = @dataSaida, StatusMatricula = @statusMatricula, FormatoAnoLetivo = @formatoAnoLetivo,
                             Materia = @materia, Professor = @professor, Nota = @nota, StatusMateria = @statusMateria,
                             ParteAnoLetivo = @parteAnoLetivo)";
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
                parametroContato_CodigoContato.Value = objEscolar.Contato_CodigoContato.Value;
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
            parametroDataSaida.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroStatusMatricula = new SqlParameter("@statusMatricula", objEscolar.StatusMatricula);
            parametroStatusMatricula.DbType = System.Data.DbType.String;

            SqlParameter parametroFormatoAnoLetivo = new SqlParameter("@formatoAnoLetivo", objEscolar.FormatoAnoLetivo);
            parametroFormatoAnoLetivo.DbType = System.Data.DbType.String;

            SqlParameter parametroMateria = new SqlParameter("@materia", objEscolar.Materia);
            parametroMateria.DbType = System.Data.DbType.String;

            SqlParameter parametroProfessor = new SqlParameter("@professor", objEscolar.Professor);
            parametroProfessor.DbType = System.Data.DbType.String;

            SqlParameter parametroNota = new SqlParameter("@nota", objEscolar.Nota);
            parametroNota.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroStatusMateria = new SqlParameter("@statusMateria", objEscolar.StatusMateria);
            parametroStatusMateria.DbType = System.Data.DbType.String;

            SqlParameter parametroParteAnoLetivo = new SqlParameter("@parteAnoLetivo", objEscolar.ParteAnoLetivo);
            parametroParteAnoLetivo.DbType = System.Data.DbType.String;




            comando.Parameters.Add(parametroAssistido_CodigoAssistido);
            comando.Parameters.Add(parametroContato_CodigoContato);
            comando.Parameters.Add(parametroInstituicao);
            comando.Parameters.Add(parametroNumInscricaoInstituicao);
            comando.Parameters.Add(parametroMediaEscola);
            comando.Parameters.Add(parametroGrauEscolaridade);
            comando.Parameters.Add(parametroSerieCursada);
            comando.Parameters.Add(parametroDataMatricula);
            comando.Parameters.Add(parametroDataSaida);
            comando.Parameters.Add(parametroStatusMatricula);
            comando.Parameters.Add(parametroFormatoAnoLetivo);
            comando.Parameters.Add(parametroMateria);
            comando.Parameters.Add(parametroProfessor);
            comando.Parameters.Add(parametroNota);
            comando.Parameters.Add(parametroStatusMateria);
            comando.Parameters.Add(parametroParteAnoLetivo);


            comando.ExecuteNonQuery();

            //TODO: retorno entidade Escolar com o Código do Escolar Preenchido
            return objEscolar;
        }

        /// <summary>
        /// Obtém os dados escolares pelo Código Escolar.
        /// </summary>
        /// <param name="codigoEscolar"></param>
        /// <returns></returns>
        public Escolar ObterEscolar(int codigoEscolar)
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
                objEscolar.Assistido_CodigoAssistido = Convert.ToInt32(leitorDados["Assistido_CodigoAssistido"]);
                objEscolar.Contato_CodigoContato = Convert.ToInt32(leitorDados["Contato_CodigoAssistido"]);
                objEscolar.Instituicao = leitorDados["Instituicao"].ToString();
                objEscolar.NumInscricaoInstituicao = leitorDados["NumInscricaoInstituicao"].ToString();
                objEscolar.MediaEscola = Convert.ToDecimal(leitorDados["MediaEscola"]);
                objEscolar.GrauEscolaridade = leitorDados["GrauEscolaridade"].ToString();
                objEscolar.SerieCursada = leitorDados["SerieCursada"].ToString();
                objEscolar.DataMatricula = Convert.ToDateTime(leitorDados["DataMatricula"]);
                objEscolar.DataSaida = Convert.ToDateTime(leitorDados["DataSaida"]);
                objEscolar.StatusMatricula = leitorDados["StatusMatricula"].ToString();
                objEscolar.FormatoAnoLetivo = leitorDados["FormatoAnoLetivo"].ToString();
                objEscolar.Materia = leitorDados["Materia"].ToString();
                objEscolar.Professor = leitorDados["Professor"].ToString();
                objEscolar.Nota = Convert.ToDecimal(leitorDados["Nota"]);
                objEscolar.StatusMateria = leitorDados["StatusMateria"].ToString();
                objEscolar.ParteAnoLetivo = leitorDados["ParteAnoLetivo"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objEscolar;
        }

        /// <summary>
        /// Exclui os dados escolar pelo seu código
        /// </summary>
        public bool ExcluirEscolar(int codigoEscolar, int codigoContato)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Escolar where CodigoEscolar = @codigoEscolar", base.Conectar());

            SqlParameter parametroCodigoEscolar = new SqlParameter("@codigoEscolar", codigoEscolar);
            parametroCodigoEscolar.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoEscolar);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

    }
}