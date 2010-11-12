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
            comando.CommandType = System.Data.CommandType.Text;

            if (!objPessoa.CodigoPessoa.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Pessoa
                         (CodigoContato, CodigoCasaLar, Nome, Sexo, CPF, RG, TituloEleitor, DataNascimento, Nacionalidade, Naturalidade, Foto, TipoPessoa)
                         VALUES        (@contato_CodigoContato, @codigoCasaLar, @nome, @sexo, @cpf, @rg, @tituloEleitor, @dataNascimento, @nacionalidade, @naturalidade, 
                                        @foto, @tipoPessoa)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Pessoa
                         SET CodigoContato = @contato_CodigoContato, CodigoCasaLar = @codigoCasaLar, Nome = @nome, Sexo = @sexo, CPF = @cpf, 
                         RG = @rg, TituloEleitor = @tituloEleitor, DataNascimento = @dataNascimento, Nacionalidade = @nacionalidade, Naturalidade = @naturalidade, 
                         Foto = @foto, TipoPessoa = @tipoPessoa
                      WHERE CodigoPessoa = @codigoPessoa";
            }

            if (objPessoa.CodigoPessoa.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoPessoa", objPessoa.CodigoPessoa.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }


            SqlParameter parametroContato_CodigoContato = new SqlParameter("@contato_CodigoContato", System.Data.DbType.Int32);
            if (objPessoa.Contato_CodigoContato.HasValue)
            {
                parametroContato_CodigoContato.Value = objPessoa.Contato_CodigoContato.Value;
            }
            else
            {
                ContatoDados objContatoDados = new ContatoDados();
                objPessoa.Contato = objContatoDados.Salvar(objPessoa.Contato);

                parametroContato_CodigoContato.Value = objPessoa.Contato.CodigoContato.Value;
            }

            SqlParameter parametroCodigoCasaLar = new SqlParameter("@codigoCasaLar", System.Data.DbType.Int32);
            parametroCodigoCasaLar.Value = objPessoa.CodigoCasaLar.Value;

            SqlParameter parametroNome = new SqlParameter("@nome", objPessoa.Nome);
            parametroNome.DbType = System.Data.DbType.String;

            SqlParameter parametroSexo = new SqlParameter("@sexo", objPessoa.Sexo);
            parametroSexo.DbType = System.Data.DbType.String;

            SqlParameter parametroCPF = new SqlParameter("@cpf", objPessoa.CPF);
            parametroCPF.DbType = System.Data.DbType.String;

            SqlParameter parametroRG = new SqlParameter("@rg", objPessoa.RG);
            parametroRG.DbType = System.Data.DbType.String;

            SqlParameter parametroTituloEleitor = new SqlParameter("@tituloEleitor", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objPessoa.TituloEleitor))
                parametroTituloEleitor.Value = objPessoa.TituloEleitor;
            else
                parametroTituloEleitor.Value = DBNull.Value;

            SqlParameter parametroDataNascimento = new SqlParameter("@dataNascimento", objPessoa.DataNascimento);
            parametroDataNascimento.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroNacionalidade = new SqlParameter("@nacionalidade", objPessoa.Nacionalidade);
            parametroNacionalidade.DbType = System.Data.DbType.String;

            SqlParameter parametroNaturalidade = new SqlParameter("@naturalidade", objPessoa.Naturalidade);
            parametroNaturalidade.DbType = System.Data.DbType.String;

            //TODO: Maycon armazenar foto
            SqlParameter parametroFoto = new SqlParameter("@foto", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objPessoa.Foto))
                parametroFoto.Value = objPessoa.Foto;
            else
                parametroFoto.Value = DBNull.Value;

            SqlParameter parametroTipoPessoa = new SqlParameter("@tipoPessoa", objPessoa.TipoPessoa);
            parametroTipoPessoa.DbType = System.Data.DbType.String;

            comando.Parameters.Add(parametroContato_CodigoContato);
            comando.Parameters.Add(parametroCodigoCasaLar);
            comando.Parameters.Add(parametroNome);
            comando.Parameters.Add(parametroSexo);
            comando.Parameters.Add(parametroCPF);
            comando.Parameters.Add(parametroRG);
            comando.Parameters.Add(parametroTituloEleitor);
            comando.Parameters.Add(parametroDataNascimento);
            comando.Parameters.Add(parametroNaturalidade);
            comando.Parameters.Add(parametroNacionalidade);
            comando.Parameters.Add(parametroFoto);
            comando.Parameters.Add(parametroTipoPessoa);

            comando.ExecuteNonQuery();

            if (!objPessoa.CodigoPessoa.HasValue)
            {
                Pessoa objPessoaInserida = this.ObterUltimaPessoaInserida();
                objPessoa.CodigoPessoa = objPessoaInserida.CodigoPessoa;
                return objPessoa;
                //return this.ObterUltimaPessoaInserida();
            }
            else
            {
                return objPessoa;
            }
        }

        /// <summary>
        /// Obtém uma Pessoa pelo Código da Pessoa
        /// </summary>
        /// <param name="codigoPessoa"></param>
        /// <returns></returns>
        public Pessoa ObterPessoa(int codigoPessoa)
        {
            ContatoDados objContatoDados = new ContatoDados();
            SqlCommand comando = new SqlCommand("select * from Pessoa where CodigoPessoa = @codigoPessoa", base.Conectar());
            SqlParameter parametroCodigoPessoa = new SqlParameter("@codigoPessoa", codigoPessoa);
            parametroCodigoPessoa.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoPessoa);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Pessoa objPessoa = null;

            if (leitorDados.Read())
            {
                objPessoa = new Pessoa();

                objPessoa.CodigoPessoa = codigoPessoa;
                objPessoa.Contato_CodigoContato = Convert.ToInt32(leitorDados["CodigoContato"]);
                if (objPessoa.Contato_CodigoContato.HasValue)
                    objPessoa.Contato = objContatoDados.ObterContato(objPessoa.Contato_CodigoContato.Value);
                objPessoa.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objPessoa.Nome = leitorDados["Nome"].ToString();
                objPessoa.Sexo = leitorDados["Sexo"].ToString();
                objPessoa.CPF = leitorDados["CPF"].ToString();
                objPessoa.RG = leitorDados["RG"].ToString();
                objPessoa.TituloEleitor = leitorDados["TituloEleitor"].ToString();
                objPessoa.DataNascimento = Convert.ToDateTime(leitorDados["DataNascimento"]);
                objPessoa.Nacionalidade = leitorDados["Nacionalidade"].ToString();
                objPessoa.Naturalidade = leitorDados["Naturalidade"].ToString();
                objPessoa.Foto = leitorDados["Foto"].ToString();
                objPessoa.TipoPessoa = leitorDados["TipoPessoa"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objPessoa;
        }


        /// <summary>
        /// Obtém uma Pessoa pelo Código da Pessoa
        /// </summary>
        /// <param name="codigoPessoa"></param>
        /// <returns></returns>
        public Pessoa ObterUltimaPessoaInserida()
        {
            ContatoDados objContatoDados = new ContatoDados();
            SqlCommand comando = new SqlCommand("select top 1 * from Pessoa order by CodigoPessoa desc", base.Conectar());

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Pessoa objPessoa = null;

            if (leitorDados.Read())
            {
                objPessoa = new Pessoa();

                objPessoa.CodigoPessoa = Convert.ToInt32(leitorDados["CodigoPessoa"]); ;
                objPessoa.Contato_CodigoContato = Convert.ToInt32(leitorDados["CodigoContato"]);
                if (objPessoa.Contato_CodigoContato.HasValue)
                    objPessoa.Contato = objContatoDados.ObterContato(objPessoa.Contato_CodigoContato.Value);
                objPessoa.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objPessoa.Nome = leitorDados["Nome"].ToString();
                objPessoa.Sexo = leitorDados["Sexo"].ToString();
                objPessoa.CPF = leitorDados["CPF"].ToString();
                objPessoa.RG = leitorDados["RG"].ToString();
                objPessoa.TituloEleitor = leitorDados["TituloEleitor"].ToString();
                objPessoa.DataNascimento = Convert.ToDateTime(leitorDados["DataNascimento"]);
                objPessoa.Nacionalidade = leitorDados["Nacionalidade"].ToString();
                objPessoa.Naturalidade = leitorDados["Naturalidade"].ToString();
                objPessoa.Foto = leitorDados["Foto"].ToString();
                objPessoa.TipoPessoa = leitorDados["TipoPessoa"].ToString();
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objPessoa;
        }



        /// <summary>
        /// Exclui uma Pessoa pelo seu código
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

        /// <summary>
        /// Este método retorna uma lista de Pessoa
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> ListarPessoa()
        {
            ContatoDados objContatoDados = new ContatoDados();
            SqlCommand comando = new SqlCommand("select * from Pessoa order by Nome asc ", base.Conectar());

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            List<Pessoa> pessoaLista = new List<Pessoa>();
            Pessoa objPessoa = null;
            
            while (leitorDados.Read())
            {
                objPessoa = new Pessoa();

                objPessoa.CodigoPessoa = Convert.ToInt32(leitorDados["CodigoPessoa"]);
                objPessoa.Contato_CodigoContato = Convert.ToInt32(leitorDados["CodigoContato"]);
                if (objPessoa.Contato_CodigoContato.HasValue)
                    objPessoa.Contato = objContatoDados.ObterContato(objPessoa.Contato_CodigoContato.Value);
                objPessoa.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objPessoa.Nome = leitorDados["Nome"].ToString();
                objPessoa.Sexo = leitorDados["Sexo"].ToString();
                objPessoa.CPF = leitorDados["CPF"].ToString();
                objPessoa.RG = leitorDados["RG"].ToString();
                objPessoa.TituloEleitor = leitorDados["TituloEleitor"].ToString();
                objPessoa.DataNascimento = Convert.ToDateTime(leitorDados["DataNascimento"]);
                objPessoa.Nacionalidade = leitorDados["Nacionalidade"].ToString();
                objPessoa.Naturalidade = leitorDados["Naturalidade"].ToString();
                objPessoa.Foto = leitorDados["Foto"].ToString();
                objPessoa.TipoPessoa = leitorDados["TipoPessoa"].ToString();

                pessoaLista.Add(objPessoa);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return pessoaLista;


        }

    }
}