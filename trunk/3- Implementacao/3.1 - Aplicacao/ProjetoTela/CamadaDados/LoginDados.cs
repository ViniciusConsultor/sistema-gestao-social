using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using SGS.Entidades;
using System.Data.SqlClient;
using SGS.Entidades.DTO;
using SGS.Componentes;

namespace SGS.CamadaDados
{
    public class LoginDados : BaseConnection
    {

        /// <summary>
        /// Este método valida se um Login e Senha são válidos
        /// </summary>
        /// <param name="objLogin"></param>
        /// <returns></returns>
        public Login Validar(Login objLogin)
        {
          /// *** [Thiago] Comentei pois estava apresentando msg de alerta!!! ***  SqlParameter parametroLogin2;
            SqlParameter parametroLogin = new SqlParameter("@login", objLogin.LoginUsuario);
            /// *** [Thiago] Comentei pois estava apresentando msg de alerta!!! *** parametroLogin.ParameterName = "@login";

            parametroLogin.DbType = System.Data.DbType.String;

            SqlParameter parametroSenha = new SqlParameter("@senha", objLogin.SenhaCriptografada);
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
    /// Este método salva o Login
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
                    @"INSERT INTO Login (Login, Nome, Senha, Email, Perfil)
                    VALUES (@loginUsuario, @nome, @senha, @email, @perfil)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Login SET Nome = @nome, Login = @loginUsuario,
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

           SqlParameter parametroNome = new SqlParameter("@nome", objLogin.Nome);
            parametroNome.DbType = System.Data.DbType.String;

            SqlParameter parametroLoginUsuario = new SqlParameter("@loginUsuario", objLogin.LoginUsuario);
            parametroLoginUsuario.DbType = System.Data.DbType.String;

            SqlParameter parametroEmail = new SqlParameter("@email", objLogin.Email);
            parametroEmail.DbType = System.Data.DbType.String;

            SqlParameter parametroPerfil = new SqlParameter("@perfil", objLogin.Perfil);
            parametroPerfil.DbType = System.Data.DbType.String;

            SqlParameter parametroSenha = new SqlParameter("@senha", objLogin.SenhaCriptografada);
            parametroSenha.DbType = System.Data.DbType.String;

            comando.Parameters.Add(parametroNome);
            comando.Parameters.Add(parametroLoginUsuario);
            comando.Parameters.Add(parametroEmail);
            comando.Parameters.Add(parametroPerfil);
            comando.Parameters.Add(parametroSenha);

            comando.ExecuteNonQuery();

            if (!objLogin.CodigoLogin.HasValue)
            {
                return ObterUltimo();
            }
            else
            {
                return objLogin;
            }

        }

        /// <summary>
        /// Obtém o código do último Login do usuário gerado
        /// </summary>
        /// <param name="codigoLogin"></param>
        /// <returns></returns>
        public Login ObterUltimo()
        {
            SqlCommand comando = new SqlCommand(@"SELECT TOP (1) * FROM Login ORDER BY CodigoLogin DESC", base.Conectar());
            
            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Login objLogin = null;

            if (leitorDados.Read())
            {
                objLogin = new Login();

                objLogin.CodigoLogin = Convert.ToInt32(leitorDados["CodigoLogin"]);
                objLogin.LoginUsuario = leitorDados["Login"].ToString();
                objLogin.Email = leitorDados["Email"].ToString();
                objLogin.Nome = leitorDados["Nome"].ToString();
                objLogin.Senha = Criptografia.Descriptografar(leitorDados["Senha"].ToString(), "Protetor");
                objLogin.Perfil = leitorDados["Perfil"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objLogin;
        }

        /// <summary>
            /// Obtém o Login do usuário pelo seu Código de Login
        /// </summary>
        /// <param name="codigoLogin"></param>
        /// <returns></returns>
        public Login Obter(int codigoLogin)
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
                objLogin.Email = leitorDados["Email"].ToString();
                objLogin.Nome = leitorDados["Nome"].ToString();
                objLogin.Senha = Criptografia.Descriptografar(leitorDados["Senha"].ToString(), "Protetor");
                objLogin.Perfil = leitorDados["Perfil"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objLogin;
        }

        /// <summary>
        /// Exclui um Login pelo seu código
        /// </summary>
        public bool Excluir(int codigoLogin)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Login where CodigoLogin = @codigoLogin", base.Conectar());

            SqlParameter parametroCodigoLogin = new SqlParameter("@codigoLogin", codigoLogin);
            parametroCodigoLogin.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoLogin);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());
            
            return execucao;

        }

        /// <summary>
        /// Retorna uma lista de Login apartir dos dados informados no LoginDTO
        /// </summary>
        public List<Login> Consultar(LoginDTO objLoginDTO)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            SqlDataReader leitorDados;

            SqlParameter paramLoginValor = new SqlParameter("@loginValor", "%" + objLoginDTO.LoginValor + "%");
            paramLoginValor.DbType = System.Data.DbType.String;

            SqlParameter paramNomeValor = new SqlParameter("@nomeValor", "%" + objLoginDTO.NomeValor + "%");
            paramNomeValor.DbType = System.Data.DbType.String;

            String sql = "select * from Login";

            //Se os Login e Nome login preenchidos
            if (objLoginDTO.LoginValor != "" && objLoginDTO.NomeValor != "")
                sql += @" where Login like @loginValor and Nome like @nomeValor";
            //Se apenas Login preenchido
            else if (objLoginDTO.LoginValor != "")
                sql += @" where Login like @loginValor";
            //Se apenas Nome preenchido
            else if (objLoginDTO.NomeValor != "")
                sql += @" where Nome like @nomeValor";

            comando.CommandText = sql;
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.Add(paramLoginValor);
            comando.Parameters.Add(paramNomeValor);

            leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            List<Login> loginLista = new List<Login>();
            Login objLogin;
            
            while (leitorDados.Read())
            {
                objLogin = new Login();

                objLogin.CodigoLogin = Convert.ToInt32(leitorDados["CodigoLogin"]);
                objLogin.LoginUsuario = leitorDados["Login"].ToString();
                objLogin.Email = leitorDados["Email"].ToString();
                objLogin.Nome = leitorDados["Nome"].ToString();
                objLogin.Senha = Criptografia.Descriptografar(leitorDados["Senha"].ToString(), "Protetor");
                objLogin.Perfil = leitorDados["Perfil"].ToString();

                loginLista.Add(objLogin);
            }

            return loginLista;
        }

    }
}