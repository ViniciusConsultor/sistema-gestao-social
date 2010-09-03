using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;
using System.Data.SqlClient;

namespace SGS.CamadaDados
{
    public class LoginDados : BaseConnection
    {

        /// <summary>
        /// Este método valida se um Login e Senha são válidos
        /// </summary>
        /// <param name="objLogin"></param>
        /// <returns></returns>
        public Login ValidarLogin(Login objLogin)
        {
            SqlParameter parametroLogin2;
            SqlParameter parametroLogin = new SqlParameter("@login", objLogin.LoginUsuario);
            parametroLogin.ParameterName = "@login";

            parametroLogin.DbType = System.Data.DbType.String;

            SqlParameter parametroSenha = new SqlParameter("@senha", objLogin.Senha);
            parametroSenha.DbType = System.Data.DbType.String;

            SqlDataReader dataReader;

            SqlCommand comando = new SqlCommand("select * from Login where Login = @login and Senha = @senha", base.Conectar());
            comando.Parameters.Add(parametroLogin);
            comando.Parameters.Add(parametroSenha);

            dataReader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            if (dataReader.Read())
            {
                objLogin.CodigoLogin = Convert.ToInt32(dataReader["CodigoLogin"]);
                objLogin.Pessoa_CodigoPessoa = Convert.ToInt32(dataReader["Pessoa_CodigoPessoa"]);
                objLogin.Email = dataReader["Email"].ToString();
                objLogin.Nome = dataReader["Nome"].ToString();
                objLogin.Senha = dataReader["Senha"].ToString();
                objLogin.Perfil = dataReader["Perfil"].ToString();

                return objLogin;
            }
            else
            {
                return null;
            }

        }
    }
}