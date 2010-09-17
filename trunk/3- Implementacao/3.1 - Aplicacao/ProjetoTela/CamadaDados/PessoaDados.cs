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
    public class PessoaDados : BaseConnection
    {
 
        public Pessoa Salvar(Pessoa objPessoa)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objPessoa.CodigoPessoa.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Pessoa (Contato_CodigoContato, Nome, Sexo, CPF, RG, TituloEleitor, DataNascimento, Naturalidade,
                           Nacionalidade, Foto)
                    VALUES (@contato_CodigoContato, @nome, @sexo, @cpf, @rg, @tituloEleitor, @dataNascimento, @naturalidade, 
                            @nacionalidade, @foto)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Pessoa SET Contato_CodigoContato = @contato_CodigoContato, Nome = @nome, Sexo = @sexo, CPF = @cpf, RG = @rg,
                        TituloEleitor = @tituloEleitor, DataNascimento = @dataNascimento, Naturalidade = @naturalidade,
                        Nacionalidade = @nacionalidade, Foto = @foto
                        WHERE (CodigoPessoa = @codigoPessoa)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objPessoa.CodigoPessoa.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoPessoa", objPessoa.CodigoPessoa.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroContato_CodigoContato = new SqlParameter();
            if (objPessoa.Contato_CodigoContato.HasValue)
            {
                parametroContato_CodigoContato.Value = objPessoa.Contato_CodigoContato.Value;
                parametroContato_CodigoContato.ParameterName = "@contato_CodigoContato";
                parametroContato_CodigoContato.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroContato_CodigoContato.Value = DBNull.Value;
                parametroContato_CodigoContato.ParameterName = "@contato_CodigoContato";
                parametroContato_CodigoContato.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroNome = new SqlParameter("@nome", objPessoa.Nome);
            parametroNome.DbType = System.Data.DbType.String;

            SqlParameter parametroSexo = new SqlParameter("@sexo", objPessoa.Sexo);
            parametroSexo.DbType = System.Data.DbType.String;

            SqlParameter parametroCPF = new SqlParameter("@cpf", objPessoa.CPF);
            parametroCPF.DbType = System.Data.DbType.String;

            SqlParameter parametroRG = new SqlParameter("@rg", objPessoa.RG);
            parametroRG.DbType = System.Data.DbType.String;

            SqlParameter parametroTituloEleitor = new SqlParameter("@tituloEleitor", objPessoa.TituloEleitor);
            parametroTituloEleitor.DbType = System.Data.DbType.String;

            SqlParameter parametroDataNascimento = new SqlParameter("@dataNascimento", objPessoa.DataNascimento);
            parametroDataNascimento.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroNaturalidade = new SqlParameter("@naturalidade", objPessoa.Naturalidade);
            parametroNaturalidade.DbType = System.Data.DbType.String;

            SqlParameter parametroNacionalidade = new SqlParameter("@nacionalidade", objPessoa.Nacionalidade);
            parametroNacionalidade.DbType = System.Data.DbType.String;

            SqlParameter parametroFoto = new SqlParameter("@foto", objPessoa.Foto);
            parametroFoto.DbType = System.Data.DbType.String;



            comando.Parameters.Add(parametroContato_CodigoContato);
            comando.Parameters.Add(parametroNome);
            comando.Parameters.Add(parametroSexo);
            comando.Parameters.Add(parametroCPF);
            comando.Parameters.Add(parametroRG);
            comando.Parameters.Add(parametroTituloEleitor);
            comando.Parameters.Add(parametroDataNascimento);
            comando.Parameters.Add(parametroNaturalidade);
            comando.Parameters.Add(parametroNacionalidade);
            comando.Parameters.Add(parametroFoto);

            comando.ExecuteNonQuery();

            //TODO: retorno entidade pessoa com o Código da pessoa Preenchido
            return objPessoa;
        }

        /// <summary>
        /// Obtém a Pessoa pelo Código da Pessoa
        /// </summary>
        /// <param name="codigoPessoa"></param>
        /// <returns></returns>
        public Pessoa ObterPessoa(int codigoPessoa)
        {
            SqlCommand comando = new SqlCommand("select * from Pessoa where CodigoPessoa = @codigoPessoa", base.Conectar());
            SqlParameter parametroCodigoPessoa = new SqlParameter("@codigoLogin", codigoPessoa);
            parametroCodigoPessoa.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoPessoa);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Pessoa objPessoa = null;

            if (leitorDados.Read())
            {
                objPessoa = new Pessoa();

                objPessoa.CodigoPessoa = codigoPessoa;
                objPessoa.Contato_CodigoContato = Convert.ToInt32(leitorDados["Contato_CodigoContato"]);
                objPessoa.Nome = leitorDados["Nome"].ToString();
                objPessoa.Sexo = leitorDados["Sexo"].ToString();
                objPessoa.CPF = leitorDados["CPF"].ToString();
                objPessoa.RG = leitorDados["RG"].ToString();
                objPessoa.TituloEleitor = leitorDados["TituloEleitor"].ToString();
                objPessoa.DataNascimento = Convert.ToDateTime(leitorDados["DataNascimento"]);
                objPessoa.Naturalidade = leitorDados["Naturalidade"].ToString();
                objPessoa.Nacionalidade = leitorDados["Nacionalidade"].ToString();
                objPessoa.Foto = leitorDados["Foto"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objPessoa;
        }

        /// <summary>
        /// Exclui um Login pelo seu código
        /// </summary>
        public bool ExcluirPessoa(int codigoPessoa)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Pessoa where CodigoPessoa = @codigoPessoa", base.Conectar());

            SqlParameter parametroCodigoPessoa = new SqlParameter("@codigoPessoa", codigoPessoa);
            parametroCodigoPessoa.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoPessoa);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }
     
    }
}