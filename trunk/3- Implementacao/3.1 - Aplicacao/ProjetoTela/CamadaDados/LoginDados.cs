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
          /// *** [Thiago] Comentei pois estava apresentando msg de alerta!!! ***  SqlParameter parametroLogin2;
            SqlParameter parametroLogin = new SqlParameter("@login", objLogin.LoginUsuario);
            /// *** [Thiago] Comentei pois estava apresentando msg de alerta!!! *** parametroLogin.ParameterName = "@login";

            parametroLogin.DbType = System.Data.DbType.String;

            SqlParameter parametroSenha = new SqlParameter("@senha", objLogin.Senha);
            parametroSenha.DbType = System.Data.DbType.String;

            SqlDataReader leitorDados;

            SqlCommand comando = new SqlCommand("select * from Login where Login = @login and Senha = @senha", base.Conectar());
            comando.Parameters.Add(parametroLogin);
            comando.Parameters.Add(parametroSenha);

            leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            if (leitorDados.Read())
            {
                objLogin.CodigoLogin = Convert.ToInt32(leitorDados["CodigoLogin"]);
                objLogin.LoginUsuario = leitorDados["Login"].ToString();
                objLogin.Pessoa_CodigoPessoa = Convert.ToInt32(leitorDados["Pessoa_CodigoPessoa"]);
                objLogin.Email = leitorDados["Email"].ToString();
                objLogin.Nome = leitorDados["Nome"].ToString();
                objLogin.Senha = leitorDados["Senha"].ToString();
                objLogin.Perfil = leitorDados["Perfil"].ToString();

                return objLogin;
            }
            else
            {
                return null;
            }

            leitorDados.Close();
            leitorDados.Dispose();
        }

        /// <summary>
        /// Este método salvo o Login
        /// </summary>
        /// <param name="objLogin"></param>
        /// <returns></returns>
        public Login Salvar(Login objLogin)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objLogin.CodigoLogin.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Login (Pessoa_CodigoPessoa, Login, Nome, Senha, Email, Perfil)
                    VALUES (@pessoa_CodigoPessoa, @loginUsuario, @nome, @senha, @email, @perfil)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Login SET Pessoa_CodigoPessoa = @pessoa_CodigoPessoa, Nome = @nome, Login = @loginUsuario,
                    Senha = @senha, Email =@email, Perfil =@perfil
                        WHERE (CodigoLogin = @codigoLogin)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objLogin.CodigoLogin.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoLogin", objLogin.CodigoLogin.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroPessoa_CodigoPessoa = new SqlParameter();
            if (objLogin.Pessoa_CodigoPessoa.HasValue)
            {
                parametroPessoa_CodigoPessoa.Value = objLogin.Pessoa_CodigoPessoa.Value;
                parametroPessoa_CodigoPessoa.ParameterName = "@pessoa_CodigoPessoa";
                parametroPessoa_CodigoPessoa.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroPessoa_CodigoPessoa.Value = DBNull.Value;
                parametroPessoa_CodigoPessoa.ParameterName = "@pessoa_CodigoPessoa";
                parametroPessoa_CodigoPessoa.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroNome = new SqlParameter("@nome", objLogin.Nome);
            parametroNome.DbType = System.Data.DbType.String;

            SqlParameter parametroLoginUsuario = new SqlParameter("@loginUsuario", objLogin.LoginUsuario);
            parametroLoginUsuario.DbType = System.Data.DbType.String;

            SqlParameter parametroEmail = new SqlParameter("@email", objLogin.Email);
            parametroEmail.DbType = System.Data.DbType.String;

            SqlParameter parametroPerfil = new SqlParameter("@perfil", objLogin.Perfil);
            parametroPerfil.DbType = System.Data.DbType.String;

            SqlParameter parametroSenha = new SqlParameter("@senha", objLogin.Senha);
            parametroSenha.DbType = System.Data.DbType.String;

            comando.Parameters.Add(parametroPessoa_CodigoPessoa);
            comando.Parameters.Add(parametroNome);
            comando.Parameters.Add(parametroLoginUsuario);
            comando.Parameters.Add(parametroEmail);
            comando.Parameters.Add(parametroPerfil);
            comando.Parameters.Add(parametroSenha);

            comando.ExecuteNonQuery();

            //TODO: retorno entidade login com o Código do Login Preenchido
            return objLogin;
        }

        /// <summary>
        /// Obtém o Login do usuário pelo seu Código de Login
        /// </summary>
        /// <param name="codigoLogin"></param>
        /// <returns></returns>
        public Login ObterLogin(int codigoLogin)
        {
            SqlCommand comando = new SqlCommand("select * from Login where CodigoLogin = @codigoLogin", base.Conectar());
            SqlParameter parametroCodigoLogin = new SqlParameter("@codigoLogin", codigoLogin);
            parametroCodigoLogin.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoLogin);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Login objLogin = null;

            if (leitorDados.Read())
            {
                objLogin = new Login();

                objLogin.CodigoLogin = codigoLogin;
                objLogin.LoginUsuario = leitorDados["Login"].ToString();
                objLogin.Pessoa_CodigoPessoa = Convert.ToInt32(leitorDados["Pessoa_CodigoPessoa"]);
                objLogin.Email = leitorDados["Email"].ToString();
                objLogin.Nome = leitorDados["Nome"].ToString();
                objLogin.Senha = leitorDados["Senha"].ToString();
                objLogin.Perfil = leitorDados["Perfil"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objLogin;
        }

        public bool ExcluirLogin(int codigoLogin)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Login where CodigoLogin = @codigoLogin", base.Conectar());
            SqlParameter parametroCodigoLogin = new SqlParameter("@codigoLogin", codigoLogin);
            parametroCodigoLogin.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoLogin);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());
            
            return execucao;

        }

    }
}