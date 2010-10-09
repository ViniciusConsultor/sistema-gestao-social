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
    public class CasaLarDados : BaseConnection
    {
        public CasaLar Salvar(CasaLar objCasaLar)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objCasaLar.CodigoCasaLar.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO CasaLar (Contato_CodigoContato, NomeCasaLar, CNPJ, Alvara, DataFundacao, Historia, Gestor, StatusCasaLar,
                           QtdMaxAssistidos, QtdAssistidos, Foto, EmailGestor, TelefoneGestor)
                    VALUES (@contato_CodigoContato, @nomeCasaLar, @cnpj, @alvara, @dataFundacao, @historia, @gestor, @statusCasaLar, 
                            @qtdMaxAssistidos, @qtdAssistidos, @foto, @emailGestor, @telefoneGestor)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Pessoa SET Contato_CodigoContato = @contato_CodigoContato, NomeCasaLar = @nomeCasaLar, CNPJ = @cnpj,
                        Alvara = @alvara, DataFundacao = @dataFundacao, Historia = @historia, gestor = @gestor, 
                        StatusCasaLar = @statusCasaLar, QtdMaxAssistidos = @qtdMaxAssistidos, QtdAssistidos = @qtdAssistidos,
                        Foto = @foto, EmailGestor = @emailGestor, TelefoneGestor = @telefoneGestor
                        WHERE (CodigoCasaLar = @codigoCasaLar)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objCasaLar.CodigoCasaLar.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoCasaLar", objCasaLar.CodigoCasaLar.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroContato_CodigoContato = new SqlParameter();
            if (objCasaLar.CodigoContato.HasValue)
            {
                parametroContato_CodigoContato.Value = objCasaLar.CodigoContato.Value;
                parametroContato_CodigoContato.ParameterName = "@contato_CodigoContato";
                parametroContato_CodigoContato.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroContato_CodigoContato.Value = DBNull.Value;
                parametroContato_CodigoContato.ParameterName = "@contato_CodigoContato";
                parametroContato_CodigoContato.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroNomeCasaLar = new SqlParameter("@nomeCasaLar", objCasaLar.NomeCasaLar);
            parametroNomeCasaLar.DbType = System.Data.DbType.String;

            SqlParameter parametroCNPJ = new SqlParameter("@cnpj", objCasaLar.CNPJ);
            parametroCNPJ.DbType = System.Data.DbType.String;

            SqlParameter parametroAlvara = new SqlParameter("@alvara", objCasaLar.Alvara);
            parametroAlvara.DbType = System.Data.DbType.String;

            SqlParameter parametroDataFundacao = new SqlParameter("@dataFundacao", objCasaLar.DataFundacao);
            parametroDataFundacao.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroHistoria = new SqlParameter("@historia", objCasaLar.Historia);
            parametroHistoria.DbType = System.Data.DbType.String;

            SqlParameter parametroGestor = new SqlParameter("@gestor", objCasaLar.Gestor);
            parametroGestor.DbType = System.Data.DbType.String;

            SqlParameter parametroStatusCasaLar = new SqlParameter("@statusCasaLar", objCasaLar.StatusCasaLar);
            parametroStatusCasaLar.DbType = System.Data.DbType.String;

            SqlParameter parametroQtdMaxAssistidos = new SqlParameter("@qtdMaxAssistidos", objCasaLar.QtdMaxAssistidos);
            parametroQtdMaxAssistidos.DbType = System.Data.DbType.Int32;

            SqlParameter parametroQtdAssistidos = new SqlParameter("@qtdAssistidos", objCasaLar.QtdAssistidos);
            parametroQtdAssistidos.DbType = System.Data.DbType.Int32;

            SqlParameter parametroFoto = new SqlParameter("@foto", objCasaLar.Foto);
            parametroFoto.DbType = System.Data.DbType.String;

            SqlParameter parametroEmailGestor = new SqlParameter("@emailGestor", objCasaLar.EmailGestor);
            parametroEmailGestor.DbType = System.Data.DbType.String;

            SqlParameter parametroTelefoneGestor = new SqlParameter("@telefoneGestor", objCasaLar.TelefoneGestor);
            parametroTelefoneGestor.DbType = System.Data.DbType.String;



            comando.Parameters.Add(parametroContato_CodigoContato);
            comando.Parameters.Add(parametroNomeCasaLar);
            comando.Parameters.Add(parametroCNPJ);
            comando.Parameters.Add(parametroAlvara);
            comando.Parameters.Add(parametroDataFundacao);
            comando.Parameters.Add(parametroHistoria);
            comando.Parameters.Add(parametroGestor);
            comando.Parameters.Add(parametroStatusCasaLar);
            comando.Parameters.Add(parametroQtdMaxAssistidos);
            comando.Parameters.Add(parametroQtdAssistidos);
            comando.Parameters.Add(parametroFoto);
            comando.Parameters.Add(parametroEmailGestor);
            comando.Parameters.Add(parametroTelefoneGestor);

            comando.ExecuteNonQuery();

            //TODO: retorno entidade CasaLar com o Código da casaLAr Preenchido
            return objCasaLar;
        }

        /// <summary>
        /// Obtém a CasaLar pelo Código da CasaLAr
        /// </summary>
        /// <param name="codigoCasaLar"></param>
        /// <returns></returns>
        public CasaLar ObterCasaLar(int codigoCasaLar)
        {
            SqlCommand comando = new SqlCommand("select * from Casa_Lar where CodigoCasaLar = @codigoCasaLar", base.Conectar());
            SqlParameter parametroCodigoCasaLar = new SqlParameter("@codigoCasaLar", codigoCasaLar);
            parametroCodigoCasaLar.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoCasaLar);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            CasaLar objCasaLar = null;

            if (leitorDados.Read())
            {
                objCasaLar = new CasaLar();

                objCasaLar.CodigoCasaLar = codigoCasaLar;
                objCasaLar.CodigoContato = Convert.ToInt32(leitorDados["CodigoContato"]);
                objCasaLar.NomeCasaLar = leitorDados["NomeCasaLar"].ToString();
                objCasaLar.CNPJ = leitorDados["CNPJ"].ToString();
                objCasaLar.Alvara = leitorDados["Alvara"].ToString();
                objCasaLar.DataFundacao = Convert.ToDateTime(leitorDados["DataFundacao"]);
                objCasaLar.Historia = leitorDados["Historia"].ToString();
                objCasaLar.Gestor = leitorDados["Gestor"].ToString();
                objCasaLar.StatusCasaLar = leitorDados["Status"].ToString();
                objCasaLar.QtdMaxAssistidos = Convert.ToInt32(leitorDados["QtdMaximaAssistidos"]);
                objCasaLar.QtdAssistidos = Convert.ToInt32(leitorDados["QtdAssistidos"]);
               ///TODO: Maycon
               ///objCasaLar.Foto = leitorDados["Foto"].ToString();
                objCasaLar.EmailGestor = leitorDados["EmailGestor"].ToString();
                objCasaLar.TelefoneGestor = leitorDados["TelefoneGestor"].ToString();
            }

            if (objCasaLar != null && objCasaLar.CodigoContato != null)
            { 
               ContatoDados objContatoDados = new ContatoDados();
               objCasaLar.Contato = objContatoDados.ObterContato(objCasaLar.CodigoContato.Value);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objCasaLar;
        }

        /// <summary>
        /// Exclui uma CasaLar pelo seu código
        /// </summary>
        public bool ExcluirCasaLar(int codigoCasaLar)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from CasaLar where CodigoCasaLar = @codigoCasaLar", base.Conectar());

            SqlParameter parametroCodigoCasaLar = new SqlParameter("@codigoCasaLar", codigoCasaLar);
            parametroCodigoCasaLar.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoCasaLar);
        
            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }
    }
}