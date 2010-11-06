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
    public class AssistidoDados : BaseConnection
    {

        public Assistido Salvar(Assistido objAssistido)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objAssistido.CodigoAssistido.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Assistido (Pessoa_CodigoPessoa, Contato_CodigoContato, Escolar_CodigoEscolar, CertidaoNascimento,
                                  NomePai, NomeMae, CPFPai, CPFMae, RGPai, RGMae, EnderecoFamilia, TelefoneFamilia, Peso, Altura, Cor,
                                  HistoricoVida, Vivo, TelefoneMae, QtdIrmaos, ResponsavelLegal, CPFResponsavel, TelefoneResponsavel,
                                  LogradouroResponsavel, NumeroResponsavel, CEPResponsavel)
                    VALUES (@pessoa_CodigoPessoa, @contato_CodigoContato, @escolar_CodigoEscolar, @certidaoNascimento, @nomePai, @nomeMae,
                            @cpfPai, @cpfMae, @rgPai, @rgMae, @enderecoFamilia, @telefoneFamilia, @peso, @altura, @cor, @historicoVida,
                            @vivo, @telefoneMae, @qtdIrmaos, @responsavelLegal, @cpfResponsavel, @telefoneResponsavel, @logradouroResponsavel,
                            @numeroResponsavel, @cepResponsavel)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Assistido SET Pessoa_CodigoPessoa = @pessoa_CodigoPessoa, Contato_CodigoContato = @contato_CodigoContato,
                             Escolar_CodigoEscolar = @escolar_CodigoEscolar, CertidaoNascimento = @certidaoNascimento, NomePai = @nomePai,
                             NomeMae = @nomeMae, CPFPai = @cpfPai, CPFMae = @cpfMae, RGPai = @rgPai, RGMae = @rgMae,
                             EnderecoFamilia = @enderecoFamilia, TelefoneFamilia = @telefoneFamilia, Peso = @peso, Altura = @altura,
                             Cor = @cor, HistoricoVida = @historicoVida, Vivo = @vivo, TelefoneMae = @telefoneMae, QtdIrmaos = @qtdIrmaos,
                             ResponsavelLegal = @responsavelLegal, CPFResponsavel = @cpfResponsavel, 
                             TelefoneResponsavel = @telefoneResponsavel, LogradouroResponsavel = LogradouroResponsavel,
                             NumeroResponsavel = @numeroResponsavel, CEPResponsavel = @cepResponsavel)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objAssistido.CodigoAssistido.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoAssistido", objAssistido.CodigoAssistido.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroPessoa_CodigoPessoa = new SqlParameter();
            if (objAssistido.Pessoa_CodigoPessoa.HasValue)
            {
                parametroPessoa_CodigoPessoa.Value = objAssistido.Pessoa_CodigoPessoa.Value;
                parametroPessoa_CodigoPessoa.ParameterName = "@pessoa_CodigoPessoa";
                parametroPessoa_CodigoPessoa.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroPessoa_CodigoPessoa.Value = DBNull.Value;
                parametroPessoa_CodigoPessoa.ParameterName = "@pessoa_CodigoPessoa";
                parametroPessoa_CodigoPessoa.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroContato_CodigoContato = new SqlParameter();
            if (objAssistido.Contato_CodigoContato.HasValue)
            {
                parametroContato_CodigoContato.Value = objAssistido.Contato_CodigoContato.Value;
                parametroContato_CodigoContato.ParameterName = "@contato_CodigoContato";
                parametroContato_CodigoContato.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroContato_CodigoContato.Value = DBNull.Value;
                parametroContato_CodigoContato.ParameterName = "@contato_CodigoContato";
                parametroContato_CodigoContato.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroEscolar_CodigoEscolar = new SqlParameter();
            if (objAssistido.Escolar_CodigoEscolar.HasValue)
            {
                parametroEscolar_CodigoEscolar.Value = objAssistido.Escolar_CodigoEscolar.Value;
                parametroEscolar_CodigoEscolar.ParameterName = "@escolar_CodigoEscolar";
                parametroEscolar_CodigoEscolar.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroEscolar_CodigoEscolar.Value = DBNull.Value;
                parametroEscolar_CodigoEscolar.ParameterName = "@escolar_CodigoEscolar";
                parametroEscolar_CodigoEscolar.DbType = System.Data.DbType.Int32;
            }


            SqlParameter parametroCertidaoNascimento = new SqlParameter("@certidaoNascimento", objAssistido.CertidaoNascimento);
            parametroCertidaoNascimento.DbType = System.Data.DbType.String;

            SqlParameter parametroNomePai = new SqlParameter("@nomePai", objAssistido.NomePai);
            parametroNomePai.DbType = System.Data.DbType.String;

            SqlParameter parametroNomeMae = new SqlParameter("@nomeMae", objAssistido.NomeMae);
            parametroNomeMae.DbType = System.Data.DbType.String;

            SqlParameter parametroCPFPai = new SqlParameter("@cpfPai", objAssistido.CPFPai);
            parametroCPFPai.DbType = System.Data.DbType.String;

            SqlParameter parametroCPFMae = new SqlParameter("@cpfMae", objAssistido.CPFMae);
            parametroCPFMae.DbType = System.Data.DbType.String;

            SqlParameter parametroRGPai = new SqlParameter("@rgPai", objAssistido.RGPai);
            parametroRGPai.DbType = System.Data.DbType.String;

            SqlParameter parametroRGMae = new SqlParameter("@rgMae", objAssistido.RGMae);
            parametroRGMae.DbType = System.Data.DbType.String;

            SqlParameter parametroEnderecoFamilia = new SqlParameter("@enderecoFamilia", objAssistido.EnderecoFamilia);
            parametroEnderecoFamilia.DbType = System.Data.DbType.String;

            SqlParameter parametroTelefoneFamilia = new SqlParameter("@telefoneFamilia", objAssistido.TelefoneFamilia);
            parametroTelefoneFamilia.DbType = System.Data.DbType.String;

            SqlParameter parametroPeso = new SqlParameter("@peso", objAssistido.Peso);
            parametroPeso.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroAltura = new SqlParameter("@altura", objAssistido.Altura);
            parametroAltura.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroCor = new SqlParameter("@cor", objAssistido.Cor);
            parametroCor.DbType = System.Data.DbType.String;

            SqlParameter parametroHistoricoVida = new SqlParameter("@historicoVida", objAssistido.HistoricoVida);
            parametroHistoricoVida.DbType = System.Data.DbType.String;

            SqlParameter parametroVivo = new SqlParameter("@vivo", objAssistido.Vivo);
            parametroVivo.DbType = System.Data.DbType.String;

            SqlParameter parametroTelefoneMae = new SqlParameter("@telefoneMae", objAssistido.TelefoneMae);
            parametroTelefoneMae.DbType = System.Data.DbType.String;

            SqlParameter parametroQtdIrmaos = new SqlParameter("@qtdIrmaos", objAssistido.QtdIrmaos);
            parametroQtdIrmaos.DbType = System.Data.DbType.Int32;

            SqlParameter parametroResponsavelLegal = new SqlParameter("@responsavelLegal", objAssistido.ResponsavelLegal);
            parametroResponsavelLegal.DbType = System.Data.DbType.String;

            SqlParameter parametroCPFResponsavel = new SqlParameter("@cpfResponsavel", objAssistido.CPFResponsavel);
            parametroCPFResponsavel.DbType = System.Data.DbType.String;

            SqlParameter parametroTelefoneResponsavel = new SqlParameter("@telefoneResponsavel", objAssistido.TelefoneResponsavel);
            parametroTelefoneResponsavel.DbType = System.Data.DbType.String;

            SqlParameter parametroLogradouroResponsavel = new SqlParameter("@logradouroResponsavel", objAssistido.LogradouroResponsavel);
            parametroLogradouroResponsavel.DbType = System.Data.DbType.String;

            SqlParameter parametroNumeroResponsavel = new SqlParameter("@numeroResponsavel", objAssistido.NumeroResponsavel);
            parametroNumeroResponsavel.DbType = System.Data.DbType.String;

            SqlParameter parametroCEPResponsavel = new SqlParameter("@cepResponsavel", objAssistido.CEPResponsavel);
            parametroCEPResponsavel.DbType = System.Data.DbType.String;



            comando.Parameters.Add(parametroPessoa_CodigoPessoa);
            comando.Parameters.Add(parametroContato_CodigoContato);
            comando.Parameters.Add(parametroEscolar_CodigoEscolar);
            comando.Parameters.Add(parametroCertidaoNascimento);
            comando.Parameters.Add(parametroNomePai);
            comando.Parameters.Add(parametroNomeMae);
            comando.Parameters.Add(parametroCPFPai);
            comando.Parameters.Add(parametroCPFMae);
            comando.Parameters.Add(parametroRGPai);
            comando.Parameters.Add(parametroRGMae);
            comando.Parameters.Add(parametroEnderecoFamilia);
            comando.Parameters.Add(parametroTelefoneFamilia);
            comando.Parameters.Add(parametroPeso);
            comando.Parameters.Add(parametroAltura);
            comando.Parameters.Add(parametroCor);
            comando.Parameters.Add(parametroHistoricoVida);
            comando.Parameters.Add(parametroVivo);
            comando.Parameters.Add(parametroTelefoneMae);
            comando.Parameters.Add(parametroQtdIrmaos);
            comando.Parameters.Add(parametroResponsavelLegal);
            comando.Parameters.Add(parametroCPFResponsavel);
            comando.Parameters.Add(parametroTelefoneResponsavel);
            comando.Parameters.Add(parametroLogradouroResponsavel);
            comando.Parameters.Add(parametroNumeroResponsavel);
            comando.Parameters.Add(parametroCEPResponsavel);


            comando.ExecuteNonQuery();

            //TODO: retorno entidade Assistido com o Código do Assistido Preenchido
            return objAssistido;
        }

        /// <summary>
        /// Obtém os assistidos pelo Código do Assistido.
        /// </summary>
        /// <param name="codigoAssistido"></param>
        /// <returns></returns>
        public Assistido ObterAssistido(int codigoAssistido)
        {
            SqlCommand comando = new SqlCommand("select * from Assistido where CodigoAssistido = @codigoAssistido", base.Conectar());
            SqlParameter parametroCodigoAssistido = new SqlParameter("@codigoAssistido", codigoAssistido);
            parametroCodigoAssistido.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAssistido);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Assistido objAssistido = null;

            if (leitorDados.Read())
            {
                objAssistido = new Assistido();

                objAssistido.CodigoAssistido = codigoAssistido;
                objAssistido.Pessoa_CodigoPessoa = Convert.ToInt32(leitorDados["Pessoa_CodigoPessoa"]);
                objAssistido.Contato_CodigoContato = Convert.ToInt32(leitorDados["Contato_CodigoContato"]);
                objAssistido.Escolar_CodigoEscolar = Convert.ToInt32(leitorDados["Escolar_CodigoEscolar"]);
                objAssistido.CertidaoNascimento = leitorDados["CertidaoNascimento"].ToString();
                objAssistido.NomePai = leitorDados["NomePai"].ToString();
                objAssistido.NomeMae = leitorDados["NomeMae"].ToString();
                objAssistido.CPFPai = leitorDados["CPFPai"].ToString();
                objAssistido.CPFMae = leitorDados["CPFMae"].ToString();
                objAssistido.RGPai = leitorDados["RGPai"].ToString();
                objAssistido.RGMae = leitorDados["RGMae"].ToString();
                objAssistido.EnderecoFamilia = leitorDados["EnderecoFamilia"].ToString();
                objAssistido.TelefoneFamilia = leitorDados["TelefoneFamilia"].ToString();
                objAssistido.Peso = Convert.ToDecimal(leitorDados["Peso"]);
                objAssistido.Altura = Convert.ToDecimal(leitorDados["Altura"]);
                objAssistido.HistoricoVida = leitorDados["HistoricoVida"].ToString();
                objAssistido.Vivo = leitorDados["Vivo"].ToString();
                objAssistido.TelefoneMae = leitorDados["TelefoneMae"].ToString();
                objAssistido.QtdIrmaos = Convert.ToInt32(leitorDados["QtdIrmaos"]);
                objAssistido.ResponsavelLegal = leitorDados["ResponsavelLegal"].ToString();
                objAssistido.CPFResponsavel = leitorDados["CPFResponsavel"].ToString();
                objAssistido.TelefoneResponsavel = leitorDados["TelefoneResponsavel"].ToString();
                objAssistido.LogradouroResponsavel = leitorDados["LogradouroResponsavel"].ToString();
                objAssistido.NumeroResponsavel = leitorDados["NumeroResponsavel"].ToString();
                objAssistido.CEPResponsavel = leitorDados["CEPResponsavel"].ToString();


            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objAssistido;
        }

        /// <summary>
        /// Exclui o Assistido pelo seu código
        /// </summary>
        public bool ExcluirAssistido(int codigoAssistido)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Assistido where CodigoAssistido = @codigoAssistido", base.Conectar());

            SqlParameter parametroCodigoAssistido = new SqlParameter("@codigoAssistido", codigoAssistido);
            parametroCodigoAssistido.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAssistido);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

        public List<Assistido> Listar()
        {
            return new List<Assistido>();//TODO:MAYCON - CRIAR METODO LISTAR
        }


    }
}