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
    public class ContatoDados : BaseConnection
    {

        public Contato Salvar(Contato objContato)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objContato.CodigoContato.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Contato (Logradouro, Numero, Bairro, Cidade, Estado, Pais, CEP, TelefoneConvencional, TelefoneCelular,
                           Fax, Email, Site, Blog)
                    VALUES (@logradouro, @numero, @bairro, @cidade, @estado, @pais, @cep, @telefoneConvencional, @telefoneCelular, @Fax, 
                           @email, @site, @blog)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Contato SET Logradouro = @logradouro, Numero = @numero, Bairro = @bairro, Cidade = @cidade, Estado = @estado, 
                        Pais = @pais, CEP = @cep, TelefoneConvencional = @telefoneConvencional, TelefoneCelular = @telefoneCelular,
                        Fax = @Fax, Email = @email, Site = @site, Blog = @blog
                        WHERE (CodigoContato = @codigocontato)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objContato.CodigoContato.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoContato", objContato.CodigoContato.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroLogradouro = new SqlParameter("@logradouro", objContato.Logradouro);
            parametroLogradouro.DbType = System.Data.DbType.String;

            SqlParameter parametroNumero = new SqlParameter("@numero", objContato.Numero);
            parametroNumero.DbType = System.Data.DbType.Int32;

            SqlParameter parametroBairro = new SqlParameter("@bairro", objContato.Bairro);
            parametroBairro.DbType = System.Data.DbType.String;

            SqlParameter parametroCidade = new SqlParameter("@cidade", objContato.Cidade);
            parametroCidade.DbType = System.Data.DbType.String;

            SqlParameter parametroEstado = new SqlParameter("@estado", objContato.Estado);
            parametroEstado.DbType = System.Data.DbType.String;

            SqlParameter parametroPais = new SqlParameter("@pais", objContato.Pais);
            parametroPais.DbType = System.Data.DbType.String;

            SqlParameter parametroCEP = new SqlParameter("@cep", objContato.CEP);
            parametroCEP.DbType = System.Data.DbType.String;

            SqlParameter parametroTelefoneConvencional = new SqlParameter("@telefoneConvencional", objContato.TelefoneConvencional);
            parametroTelefoneConvencional.DbType = System.Data.DbType.String;

            SqlParameter parametroTelefoneCelular = new SqlParameter("@telefoneCelular", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objContato.TelefoneCelular))
                parametroTelefoneCelular.Value = objContato.TelefoneCelular;
            else
                parametroTelefoneCelular.Value = DBNull.Value;

            SqlParameter parametroFax = new SqlParameter("@Fax", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objContato.Fax))
                parametroFax.Value = objContato.Fax;
            else
                parametroFax.Value = DBNull.Value;

            SqlParameter parametroEmail = new SqlParameter("@email", objContato.Email);
            parametroEmail.DbType = System.Data.DbType.String;

            SqlParameter parametroSite = new SqlParameter("@site", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objContato.Site))
                parametroSite.Value = objContato.Site;
            else
                parametroSite.Value = DBNull.Value;

            SqlParameter parametroBlog = new SqlParameter("@blog", System.Data.DbType.String);
            if(!string.IsNullOrEmpty(objContato.Blog))
                parametroBlog.Value = objContato.Blog ;
            else
                parametroBlog.Value = DBNull.Value;
            
            comando.Parameters.Add(parametroLogradouro);
            comando.Parameters.Add(parametroNumero);
            comando.Parameters.Add(parametroBairro);
            comando.Parameters.Add(parametroCidade);
            comando.Parameters.Add(parametroEstado);
            comando.Parameters.Add(parametroPais);
            comando.Parameters.Add(parametroCEP);
            comando.Parameters.Add(parametroTelefoneConvencional);
            comando.Parameters.Add(parametroTelefoneCelular);
            comando.Parameters.Add(parametroFax);
            comando.Parameters.Add(parametroEmail);
            comando.Parameters.Add(parametroSite);
            comando.Parameters.Add(parametroBlog);

            comando.ExecuteNonQuery();

            if (!objContato.CodigoContato.HasValue)
            {
                return ObterUltimoContato();
            }
            else
            {
                return objContato;
            }
          
        }

        /// <summary>
        /// Obtém o Contato pelo Código o Contato
        /// </summary>
        /// <param name="codigoPessoa"></param>
        /// <returns></returns>
        public Contato ObterUltimoContato()
        {
            SqlCommand comando = new SqlCommand("select TOP (1) * from Contato ORDER BY CodigoContato DESC", base.Conectar());
           
            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Contato objContato = null;

            if (leitorDados.Read())
            {
                objContato = new Contato();

                objContato.CodigoContato = Convert.ToInt32(leitorDados["codigoContato"]);
                objContato.Logradouro = leitorDados["Logradouro"].ToString();
                objContato.Numero = leitorDados["Numero"].ToString();
                objContato.Bairro = leitorDados["Bairro"].ToString();
                objContato.Cidade = leitorDados["Cidade"].ToString();
                objContato.Estado = leitorDados["Estado"].ToString();
                objContato.Pais = leitorDados["Pais"].ToString();
                objContato.CEP = leitorDados["CEP"].ToString();
                objContato.TelefoneConvencional = leitorDados["TelefoneConvencional"].ToString();
                objContato.TelefoneCelular = leitorDados["TelefoneCelular"].ToString();
                objContato.Fax = leitorDados["Fax"].ToString();
                objContato.Email = leitorDados["Email"].ToString();
                objContato.Site = leitorDados["Site"].ToString();
                objContato.Blog = leitorDados["Blog"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objContato;
        }


        /// <summary>
        /// Obtém o Contato pelo Código o Contato
        /// </summary>
        /// <param name="codigoPessoa"></param>
        /// <returns></returns>
        public Contato ObterContato(int codigoContato)
        {
            SqlCommand comando = new SqlCommand("select * from Contato where CodigoContato = @codigoContato", base.Conectar());
            SqlParameter parametroCodigoContato = new SqlParameter("@codigoContato", codigoContato);
            parametroCodigoContato.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoContato);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Contato objContato = null;

            if (leitorDados.Read())
            {
                objContato = new Contato();

                objContato.CodigoContato = codigoContato;
                objContato.Logradouro = leitorDados["Logradouro"].ToString();
                objContato.Numero = leitorDados["Numero"].ToString();
                objContato.Bairro = leitorDados["Bairro"].ToString();
                objContato.Cidade = leitorDados["Cidade"].ToString();
                objContato.Estado = leitorDados["Estado"].ToString();
                objContato.Pais = leitorDados["Pais"].ToString();
                objContato.CEP = leitorDados["CEP"].ToString();
                objContato.TelefoneConvencional = leitorDados["TelefoneConvencional"].ToString();
                objContato.TelefoneCelular = leitorDados["TelefoneCelular"].ToString();
                objContato.Fax = leitorDados["Fax"].ToString();
                objContato.Email = leitorDados["Email"].ToString();
                objContato.Site = leitorDados["Site"].ToString();
                objContato.Blog = leitorDados["Blog"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objContato;
        }

        /// <summary>
        /// Exclui um Contato pelo seu código
        /// </summary>
        public bool ExcluirContato(int codigoContato)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Contato where CodigoContato = @codigoContato", base.Conectar());

            SqlParameter parametroCodigoContato = new SqlParameter("@codigoContato", codigoContato);
            parametroCodigoContato.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoContato);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

    }
}