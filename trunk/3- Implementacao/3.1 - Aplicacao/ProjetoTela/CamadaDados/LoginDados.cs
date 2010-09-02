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
        /// <param name="umLogin"></param>
        /// <returns></returns>
        public Login ValidarLogin(Login umLogin)
        {
            SqlParameter parametroLogin = new SqlParameter("@login", umLogin.LoginUsuario);
            parametroLogin.DbType = System.Data.DbType.String;

            SqlParameter parametroSenha = new SqlParameter("@senha", umLogin.Senha);
            parametroSenha.DbType = System.Data.DbType.String;

            SqlDataReader dataReader;
            SqlCommand comando = new SqlCommand("select * from Login where Login = @login and Senha = @senha", base.Conectar());
            comando.Parameters.Add(parametroLogin);
            comando.Parameters.Add(parametroSenha);

            dataReader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            if (dataReader.Read())
            {
                umLogin.CodigoLogin = Convert.ToInt32(dataReader["CodigoLogin"]);
                umLogin.Pessoa_CodigoPessoa = Convert.ToInt32(dataReader["Pessoa_CodigoPessoa"]);
                umLogin.Email = dataReader["Email"].ToString();
                umLogin.Nome = dataReader["Nome"].ToString();
                umLogin.Senha = dataReader["Senha"].ToString();
                umLogin.Perfil = dataReader["Perfil"].ToString();

                return umLogin;
            }
            else
            {
                return null;
            }

        }
    }
}