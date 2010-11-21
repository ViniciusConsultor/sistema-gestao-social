using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using SGS.Entidades;
using System.Data.SqlClient;
using SGS.Entidades.DTO;
using SGS.Entidades.Adaptador;

namespace SGS.CamadaDados
{
    public class AssistidoDados : BaseConnection
    {

        /// <summary>
        /// Este método cadastro ou atualiza um assistido
        /// </summary>
        /// <param name="objAssistido"></param>
        /// <returns></returns>
        public Assistido Salvar(Assistido objAssistido)
        {
            PessoaDados objPessoaDados = new PessoaDados();
            objPessoaDados.Salvar(objAssistido);

            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            if (!objAssistido.CodigoAssistido.HasValue)
            {
                objAssistido.CodigoAssistido = objAssistido.CodigoPessoa;

                comando.CommandText =
                    @"
                    INSERT INTO Assistido
                         (CodigoAssistido, StatusAssistido, CertidaoNascimento, DataEntrada, DataSaida, EstadoSaude, 
                          Peso, Etnia, Altura, TamCamisa, TamCalca, TamCalcado, Dormitorio, Deficiente, Hobby, HistoricoVida, 
                          NomePai, NomeMae, PaiVivo, MaeViva, CPFPai, CPFMae, RGPai, RGMae, TelefonePai, TelefoneMae,  
                          QtdIrmaos, NomeResponsavel, CPFResponsavel, CodigoContatoResponsavel)
                    VALUES
                         (@codigoAssistido, @statusAssistido, @certidaoNascimento, @dataEntrada, @dataSaida, @estadoSaude,
                          @peso, @Etnia, @altura, @tamCamisa, @tamCalca, @tamCalcado, @dormitorio, @Deficiente, @Hobby, @historicoVida,
                          @nomePai, @nomeMae, @paiVivo, @maeViva, @cpfPai, @cpfMae, @rgPai, @rgMae, @telefonePai, @telefoneMae,
                          @qtdIrmaos, @nomeResponsavel, @cpfResponsavel, @codigoContatoResponsavel)";
            }
            else
            {
                comando.CommandText =
                    @"
                    UPDATE Assistido
                    SET  StatusAssistido = @statusAssistido, CertidaoNascimento = @certidaoNascimento, DataEntrada = @dataEntrada, 
                         DataSaida = @dataSaida, EstadoSaude = @estadoSaude, Peso = @peso, Etnia = @Etnia, Altura = @altura, TamCamisa = @tamCamisa, 
                         TamCalca = @tamCalca, TamCalcado = @tamCalcado, Dormitorio = @dormitorio, Deficiente = @Deficiente, Hobby = @Hobby,
                         HistoricoVida = @historicoVida, NomePai = @nomePai, NomeMae = @nomeMae, PaiVivo = @paiVivo,  MaeViva = @maeViva, CPFPai = @cpfPai, 
                         CPFMae = @cpfMae, RGPai = @rgPai, RGMae = @rgMae, TelefonePai = @telefonePai, TelefoneMae = @telefoneMae, 
                         QtdIrmaos = @qtdIrmaos, NomeResponsavel = @nomeResponsavel, CPFResponsavel = @cpfResponsavel, CodigoContatoResponsavel = @codigoContatoResponsavel
                    WHERE CodigoAssistido = @codigoAssistido";

            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objAssistido.CodigoAssistido.HasValue)
            {
                SqlParameter parametroCodigoAssistido = new SqlParameter("@codigoAssistido", objAssistido.CodigoAssistido.Value);
                parametroCodigoAssistido.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigoAssistido);
            }

            SqlParameter parametroStatusAssistido = new SqlParameter("@statusAssistido", objAssistido.StatusAssistido);
            parametroStatusAssistido.DbType = System.Data.DbType.String;

            SqlParameter parametroCertidaoNascimento = new SqlParameter("@certidaoNascimento", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objAssistido.CertidaoNascimento))
                parametroCertidaoNascimento.Value = objAssistido.CertidaoNascimento;
            else
                parametroCertidaoNascimento.Value = DBNull.Value;

            SqlParameter parametroDataEntrada = new SqlParameter("@dataEntrada", objAssistido.DataEntrada.Value);
            parametroDataEntrada.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroDataSaida = new SqlParameter("@dataSaida", System.Data.DbType.DateTime);
            if (objAssistido.DataSaida.HasValue)
                parametroDataSaida.Value = objAssistido.DataSaida.Value;
            else
                parametroDataSaida.Value = DBNull.Value;

            SqlParameter parametroEstadoSaude = new SqlParameter("@estadoSaude", objAssistido.EstadoSaude);
            parametroEstadoSaude.DbType = System.Data.DbType.String;

            SqlParameter parametroPeso = new SqlParameter("@peso", objAssistido.Peso);
            parametroPeso.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroEtnia = new SqlParameter("@Etnia", objAssistido.Etnia);
            parametroEtnia.DbType = System.Data.DbType.String;

            SqlParameter parametroAltura = new SqlParameter("@altura", objAssistido.Altura);
            parametroAltura.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroTamCamisa = new SqlParameter("@tamCamisa", objAssistido.TamanhoCamisa);
            parametroTamCamisa.DbType = System.Data.DbType.String;

            SqlParameter parametroTamCalca = new SqlParameter("@tamCalca", objAssistido.TamanhoCalca);
            parametroTamCalca.DbType = System.Data.DbType.String;

            SqlParameter parametroTamCalcado = new SqlParameter("@tamCalcado", objAssistido.TamanhoCalcado);
            parametroTamCalcado.DbType = System.Data.DbType.String;

            SqlParameter parametroDormitorio = new SqlParameter("@dormitorio", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objAssistido.Dormitorio))
                parametroDormitorio.Value= objAssistido.Dormitorio;
            else
                parametroDormitorio.Value= DBNull.Value;

            SqlParameter parametroDeficiente = new SqlParameter("@deficiente", objAssistido.Deficiente);
            parametroDeficiente.DbType = System.Data.DbType.String ;

            SqlParameter parametroHobby = new SqlParameter("@hobby", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objAssistido.Hobby))
                parametroHobby.Value = objAssistido.Hobby;
            else
                parametroHobby.Value = DBNull.Value;

            SqlParameter parametroHistoricoVida = new SqlParameter("@historicoVida", System.Data.DbType.String);
            if(!String.IsNullOrEmpty(objAssistido.HistoricoVida))
                parametroHistoricoVida.Value = objAssistido.HistoricoVida;
            else
                parametroHistoricoVida.Value = DBNull.Value;

            //Dados Pais
            SqlParameter parametroNomePai = new SqlParameter("@nomePai", System.Data.DbType.String);
            if(!String.IsNullOrEmpty(objAssistido.Pai))
                parametroNomePai.Value = objAssistido.Pai;
            else
                parametroNomePai.Value = DBNull.Value;

            SqlParameter parametroNomeMae = new SqlParameter("@nomeMae", System.Data.DbType.String);
            if(!String.IsNullOrEmpty(objAssistido.Mae))
                parametroNomeMae.Value = objAssistido.Mae;
            else
                parametroNomeMae.Value = DBNull.Value;

            SqlParameter parametroPaiVivo = new SqlParameter("@paiVivo", System.Data.DbType.String);
            if(!String.IsNullOrEmpty(objAssistido.PaiVivo))
                parametroPaiVivo.Value = objAssistido.PaiVivo;
            else
                parametroPaiVivo.Value = DBNull.Value;

            SqlParameter parametroMaeViva = new SqlParameter("@maeViva", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objAssistido.MaeViva))
                parametroMaeViva.Value = objAssistido.MaeViva;
            else
                parametroMaeViva.Value = DBNull.Value;

            SqlParameter parametroCPFPai = new SqlParameter("@cpfPai", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objAssistido.CPFPai))
                parametroCPFPai.Value = objAssistido.CPFPai;
            else
                parametroCPFPai.Value = objAssistido.CPFPai;

            SqlParameter parametroCPFMae = new SqlParameter("@cpfMae", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objAssistido.CPFMae))
                parametroCPFMae.Value = objAssistido.CPFMae;
            else
                parametroCPFMae.Value = DBNull.Value;

            SqlParameter parametroRGPai = new SqlParameter("@rgPai", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objAssistido.RGPai))
                parametroRGPai.Value = objAssistido.RGPai;
            else
                parametroRGPai.Value = DBNull.Value;

            SqlParameter parametroRGMae = new SqlParameter("@rgMae", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objAssistido.RGMae))
                parametroRGMae.Value = objAssistido.RGMae;
            else
                parametroRGMae.Value = DBNull.Value;

            SqlParameter parametroTelefonePai = new SqlParameter("@telefonePai", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objAssistido.TelefonePai))
                parametroTelefonePai.Value = objAssistido.TelefonePai;
            else
                 parametroTelefonePai.Value = DBNull.Value;

            SqlParameter parametroTelefoneMae = new SqlParameter("@telefoneMae", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(objAssistido.TelefoneMae))
                parametroTelefonePai.Value = objAssistido.TelefoneMae;
            else
                parametroTelefonePai.Value = DBNull.Value;

            SqlParameter parametroQtdIrmaos = new SqlParameter("@qtdIrmaos", System.Data.DbType.Int32);
            if(objAssistido.QtdIrmaos.HasValue)
                parametroQtdIrmaos.Value = objAssistido.QtdIrmaos;    
            else
                parametroQtdIrmaos.Value = DBNull.Value; ;    
            

            //Dados Responsavel
            SqlParameter parametroNomeResponsavel = new SqlParameter("@nomeResponsavel", System.Data.DbType.String);
            if(!String.IsNullOrEmpty(objAssistido.ResponsavelLegal))
                parametroNomeResponsavel.Value = objAssistido.ResponsavelLegal;
            else
                parametroNomeResponsavel.Value = DBNull.Value;

            SqlParameter parametroCPFResponsavel = new SqlParameter("@cpfResponsavel", System.Data.DbType.String);
            if(!String.IsNullOrEmpty(objAssistido.ResponsavelLegal))
                parametroCPFResponsavel.Value = objAssistido.CPFResponsavel;
            else
                parametroCPFResponsavel.Value = DBNull.Value;

            //Adiciona os dados de contato do Responsavel na tabela Contato
            //TODO: Maycon verificar se os campos de contato do responsável foram preenchidos
            if (objAssistido.ContatoResponsavel != null)
            {
                ContatoDados objContatoDados = new ContatoDados();
                objAssistido.ContatoResponsavel = objContatoDados.Salvar(objAssistido.ContatoResponsavel);
                objAssistido.CodigoContatoResponsavel = objAssistido.ContatoResponsavel.CodigoContato;
            }
            
            SqlParameter parametroCodigoContatoResponsavel = new SqlParameter("@codigoContatoResponsavel", System.Data.DbType.String);
            if(objAssistido.CodigoContatoResponsavel.HasValue)
                parametroCodigoContatoResponsavel.Value = objAssistido.CodigoContatoResponsavel.Value;
            else
                parametroCodigoContatoResponsavel.Value = DBNull.Value;

            //Parametros
            comando.Parameters.Add(parametroStatusAssistido);
            comando.Parameters.Add(parametroDataEntrada);
            comando.Parameters.Add(parametroDataSaida);
            comando.Parameters.Add(parametroEstadoSaude);
            comando.Parameters.Add(parametroCertidaoNascimento);
            comando.Parameters.Add(parametroPeso);
            comando.Parameters.Add(parametroAltura);
            comando.Parameters.Add(parametroEtnia);
            comando.Parameters.Add(parametroTamCalca);
            comando.Parameters.Add(parametroTamCalcado);
            comando.Parameters.Add(parametroTamCamisa);
            comando.Parameters.Add(parametroDormitorio);
            comando.Parameters.Add(parametroDeficiente);
            comando.Parameters.Add(parametroHobby);
            comando.Parameters.Add(parametroHistoricoVida);

            comando.Parameters.Add(parametroNomePai);
            comando.Parameters.Add(parametroPaiVivo);
            comando.Parameters.Add(parametroNomeMae);
            comando.Parameters.Add(parametroMaeViva);
            comando.Parameters.Add(parametroCPFPai);
            comando.Parameters.Add(parametroCPFMae);
            comando.Parameters.Add(parametroRGPai);
            comando.Parameters.Add(parametroRGMae);
            comando.Parameters.Add(parametroTelefonePai);
            comando.Parameters.Add(parametroTelefoneMae);
            comando.Parameters.Add(parametroQtdIrmaos);
            comando.Parameters.Add(parametroNomeResponsavel);
            comando.Parameters.Add(parametroCPFResponsavel);
            comando.Parameters.Add(parametroCodigoContatoResponsavel);

            comando.ExecuteNonQuery();

            return objAssistido;

        }

        /// <summary>
        /// Obtém os assistidos pelo Código do Assistido.
        /// </summary>
        /// <param name="codigoAssistido"></param>
        /// <returns></returns>
        public Assistido ObterAssistido(int codigoAssistido)
        {
            PessoaDados objPessoaDados = new PessoaDados();
            AssistidoAdaptador objAssistidoAdaptador = new AssistidoAdaptador(); 
            Pessoa objPessoa = null;
            Assistido objAssistido = null;

            objPessoa = objPessoaDados.ObterPessoa(codigoAssistido);
            objAssistido = objAssistidoAdaptador.AdaptarPessoaParaAssistido(objPessoa);

            SqlCommand comando = new SqlCommand("select * from Assistido where CodigoAssistido = @codigoAssistido", base.Conectar());

            SqlParameter parametroCodigoAssistido = new SqlParameter("@codigoAssistido", codigoAssistido);
            parametroCodigoAssistido.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoAssistido);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            

            if (leitorDados.Read())
            {
                //(CodigoAssistido, StatusAssistido, CertidaoNascimento, DataEntrada, DataSaida, EstadoSaude, 
                //          Peso, Etnia, Altura, TamCamisa, TamCalca, TamCalcado, Dormitorio, Deficiente, Hobby, HistoricoVida, 
                //          NomePai, NomeMae, PaiVivo, MaeViva, CPFPai, CPFMae, RGPai, RGMae, TelefonePai, TelefoneMae,  
                //          QtdIrmaos, NomeResponsavel, CPFResponsavel, CodigoContatoResponsavel)

                objAssistido.CodigoAssistido = codigoAssistido;
                objAssistido.StatusAssistido = leitorDados["StatusAssistido"].ToString();
                if (leitorDados["CertidaoNascimento"] != DBNull.Value)
                    objAssistido.CertidaoNascimento = leitorDados["CertidaoNascimento"].ToString();
                objAssistido.DataEntrada = Convert.ToDateTime(leitorDados["DataEntrada"]);
                if (leitorDados["DataSaida"] != DBNull.Value)
                    objAssistido.DataSaida = Convert.ToDateTime(leitorDados["DataSaida"]); ;
                objAssistido.EstadoSaude = leitorDados["EstadoSaude"].ToString();
                objAssistido.Peso = Convert.ToDecimal(leitorDados["Peso"]);
                objAssistido.Etnia = leitorDados["Etnia"].ToString();
                objAssistido.Altura = Convert.ToDecimal(leitorDados["Altura"]);
                objAssistido.TamanhoCamisa = leitorDados["TamCamisa"].ToString();
                objAssistido.TamanhoCalca = leitorDados["TamCalca"].ToString();
                objAssistido.TamanhoCalcado = leitorDados["TamCalcado"].ToString();
                objAssistido.Dormitorio = leitorDados["Dormitorio"].ToString(); ;
                objAssistido.Deficiente = leitorDados["Deficiente"].ToString();
                objAssistido.Hobby = leitorDados["Hobby"].ToString();
                objAssistido.HistoricoVida = leitorDados["HistoricoVida"].ToString();
                objAssistido.Pai = leitorDados["NomePai"].ToString();
                objAssistido.Mae = leitorDados["NomeMae"].ToString();
                objAssistido.PaiVivo = leitorDados["PaiVivo"].ToString();
                objAssistido.MaeViva = leitorDados["MaeViva"].ToString();
                objAssistido.CPFPai = leitorDados["CPFPai"].ToString();
                objAssistido.CPFMae = leitorDados["CPFMae"].ToString();
                objAssistido.RGPai = leitorDados["RGPai"].ToString();
                objAssistido.RGMae = leitorDados["RGMae"].ToString();
                objAssistido.TelefonePai = leitorDados["TelefonePai"].ToString();
                objAssistido.TelefoneMae = leitorDados["TelefoneMae"].ToString();
                objAssistido.QtdIrmaos = Convert.ToInt32(leitorDados["QtdIrmaos"]);
                objAssistido.ResponsavelLegal = leitorDados["NomeResponsavel"].ToString();
                objAssistido.CPFResponsavel = leitorDados["CpfResponsavel"].ToString();
                if (leitorDados["CodigoContatoResponsavel"] != DBNull.Value)
                    objAssistido.CodigoContatoResponsavel = Convert.ToInt32(leitorDados["CodigoContatoResponsavel"]);
                else
                    objAssistido.CodigoContatoResponsavel = null;
            }

            //Todo: MAYCON Pegar os dados das tabelas auxiliares
            if (objAssistido.CodigoContatoResponsavel.HasValue)
            {
                ContatoDados objContatoDados = new ContatoDados();
                objAssistido.ContatoResponsavel = objContatoDados.ObterContato(objAssistido.CodigoContatoResponsavel.Value);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objAssistido;
        }

        /// <summary>
        /// Obtém os assistidos pelo Código do Assistido.
        /// </summary>
        /// <param name="codigoAssistido"></param>
        /// <returns></returns>
        public Assistido ObterUltimoAssistidoInserido(int codigoAssistido)
        {
            return new Assistido();
        }

        /// <summary>
        /// Este método retorna uma lista de assistido
        /// </summary>
        /// <param name="assistidoAtivado"></param>
        /// <returns></returns>
        public List<Assistido> Listar(bool? assistidoAtivado)
        {
            SqlCommand comando = new SqlCommand();

            List<Assistido> assistidoLista = new List<Assistido>();
            Assistido objAssistido = null;
            PessoaDados objPessoaDados = new PessoaDados();
            ContatoDados objContatoDados = new ContatoDados();

            string sql = @"select * from Assistido A inner join Pessoa P ON A.CodigoAssistido = P.CodigoPessoa"; 
                                                             
            if (assistidoAtivado.HasValue)
            {
                sql += " where Ativo = @ativo";
                SqlParameter parametroAtivo = new SqlParameter("@ativo", System.Data.DbType.Boolean);
                parametroAtivo.Value = assistidoAtivado;
                comando.Parameters.Add(parametroAtivo);
            }

            comando.Connection = base.Conectar();
            comando.CommandText = sql;
            
            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (leitorDados.Read())
            {
                objAssistido = new Assistido();
                
                //Dados Tabela Pessoa
                objAssistido.CodigoPessoa = Convert.ToInt32(leitorDados["CodigoPessoa"]); 
                if (leitorDados["CodigoContato"] != DBNull.Value)
                    objAssistido.Contato_CodigoContato = Convert.ToInt32(leitorDados["CodigoContato"]);
                if (objAssistido.Contato_CodigoContato.HasValue)
                    objAssistido.Contato = objContatoDados.ObterContato(objAssistido.Contato_CodigoContato.Value);
                objAssistido.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objAssistido.Nome = leitorDados["Nome"].ToString();
                objAssistido.Sexo = leitorDados["Sexo"].ToString();
                objAssistido.CPF = leitorDados["CPF"].ToString();
                objAssistido.RG = leitorDados["RG"].ToString();
                objAssistido.TituloEleitor = leitorDados["TituloEleitor"].ToString();
                objAssistido.DataNascimento = Convert.ToDateTime(leitorDados["DataNascimento"]);
                objAssistido.Nacionalidade = leitorDados["Nacionalidade"].ToString();
                objAssistido.Naturalidade = leitorDados["Naturalidade"].ToString();
                objAssistido.Foto = leitorDados["Foto"].ToString();
                objAssistido.TipoPessoa = leitorDados["TipoPessoa"].ToString();
                objAssistido.Ativo = Convert.ToBoolean(leitorDados["Ativo"]);

                //Dados Tabela Assistido
                objAssistido.CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                objAssistido.StatusAssistido = leitorDados["StatusAssistido"].ToString();
                if (leitorDados["CertidaoNascimento"] != DBNull.Value)
                    objAssistido.CertidaoNascimento = leitorDados["CertidaoNascimento"].ToString();
                objAssistido.DataEntrada = Convert.ToDateTime(leitorDados["DataEntrada"]);
                if (leitorDados["DataSaida"] != DBNull.Value)
                    objAssistido.DataSaida = Convert.ToDateTime(leitorDados["DataSaida"]); ;
                objAssistido.EstadoSaude = leitorDados["EstadoSaude"].ToString();
                objAssistido.Peso = Convert.ToDecimal(leitorDados["Peso"]);
                objAssistido.Etnia = leitorDados["Etnia"].ToString();
                objAssistido.Altura = Convert.ToDecimal(leitorDados["Altura"]);
                objAssistido.TamanhoCamisa = leitorDados["TamCamisa"].ToString();
                objAssistido.TamanhoCalca = leitorDados["TamCalca"].ToString();
                objAssistido.TamanhoCalcado = leitorDados["TamCalcado"].ToString();
                objAssistido.Dormitorio = leitorDados["Dormitorio"].ToString(); ;
                objAssistido.Deficiente = leitorDados["Deficiente"].ToString();
                objAssistido.Hobby = leitorDados["Hobby"].ToString();
                objAssistido.HistoricoVida = leitorDados["HistoricoVida"].ToString();
                objAssistido.Pai = leitorDados["NomePai"].ToString();
                objAssistido.Mae = leitorDados["NomeMae"].ToString();
                objAssistido.PaiVivo = leitorDados["PaiVivo"].ToString();
                objAssistido.MaeViva = leitorDados["MaeViva"].ToString();
                objAssistido.CPFPai = leitorDados["CPFPai"].ToString();
                objAssistido.CPFMae = leitorDados["CPFMae"].ToString();
                objAssistido.RGPai = leitorDados["RGPai"].ToString();
                objAssistido.RGMae = leitorDados["RGMae"].ToString();
                objAssistido.TelefonePai = leitorDados["TelefonePai"].ToString();
                objAssistido.TelefoneMae = leitorDados["TelefoneMae"].ToString();
                objAssistido.QtdIrmaos = Convert.ToInt32(leitorDados["QtdIrmaos"]);
                objAssistido.ResponsavelLegal = leitorDados["NomeResponsavel"].ToString();
                objAssistido.CPFResponsavel = leitorDados["CpfResponsavel"].ToString();
                
                if (leitorDados["CodigoContatoResponsavel"] != DBNull.Value)
                    objAssistido.CodigoContatoResponsavel = Convert.ToInt32(leitorDados["CodigoContatoResponsavel"]);
                else
                    objAssistido.CodigoContatoResponsavel = null;
                
                //Obtém dados de Contato do Responsável
                if (objAssistido.CodigoContatoResponsavel.HasValue)
                {
                    objAssistido.ContatoResponsavel = objContatoDados.ObterContato(objAssistido.CodigoContatoResponsavel.Value);
                }

                assistidoLista.Add(objAssistido);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return assistidoLista;
        }

        /// <summary>
        /// Consulta os assistido pelos dados contidos no ConsultarAssistidoDTO
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Assistido> ConsultarAssistido(ConsultarAssistidoDTO filtro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();

            SqlDataReader leitorDados;

            String sql = "select * from Assistido A inner join Pessoa P on A.CodigoAssistido = P.CodigoPessoa where ";

            SqlParameter paramCodigoAssistido = new SqlParameter("@codigoAssistido", System.Data.DbType.Int32);
            if (filtro.CodigoAssisitoValor.HasValue)
            {
                paramCodigoAssistido.Value = filtro.CodigoAssisitoValor.Value;
                sql += @"A.CodigoAssistido = @codigoAssistido and ";
            }
            else
                paramCodigoAssistido.Value = DBNull.Value;

            SqlParameter paramNome = new SqlParameter("@nome", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(filtro.NomeAssistidoValor))
            {
                paramNome.Value = "%" + filtro.NomeAssistidoValor + "%";
                sql += @"P.Nome like @nome and ";
            }
            else
                paramNome.Value = DBNull.Value;

            SqlParameter paramStatusAssistido = new SqlParameter("@statusAssistido", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(filtro.StatusAssistidoValor))
            {
                paramStatusAssistido.Value = filtro.StatusAssistidoValor;
                sql += "A.StatusAssistido = @statusAssistido and ";
            }
            else
                paramStatusAssistido.Value = DBNull.Value;

            SqlParameter paramStatusCadastro = new SqlParameter("@statusCadastro", System.Data.DbType.Boolean);
            if (filtro.StatusCadastroValor.HasValue)
            {
                paramStatusCadastro.Value = filtro.StatusCadastroValor.Value;
                sql += "P.Ativo = @statusCadastro and ";
            }
            else
                paramStatusCadastro.Value = DBNull.Value;

            SqlParameter paramEstadoSaude = new SqlParameter("@estadoSaude", System.Data.DbType.String);
            if (!String.IsNullOrEmpty(filtro.EstadoSaudeValor))
            {
                paramEstadoSaude.Value = filtro.EstadoSaudeValor;
                sql += "EstadoSaude = @estadoSaude and ";
            }
            else
                paramEstadoSaude.Value = DBNull.Value;

            SqlParameter paramDataEntrada = new SqlParameter("@dataEntrada", System.Data.DbType.DateTime);
            if (filtro.DataEntradaValor.HasValue)
            {
                paramDataEntrada.Value = filtro.DataEntradaValor.Value;
                sql += "DataEntrada >= @dataEntrada and "; 
            }
            else
                paramDataEntrada.Value = DBNull.Value;

            SqlParameter paramDataSaida = new SqlParameter("@dataSaida", System.Data.DbType.DateTime);
            if (filtro.DataSaidaValor.HasValue)
            {
                paramDataSaida.Value = filtro.DataSaidaValor.Value;
                sql += "(DataSaida <= @dataSaida or DataSaida is null) and ";
            }
            else
                paramDataSaida.Value = DBNull.Value;

            
            if (sql.EndsWith("where "))
                sql = sql.Replace("where ", "");
            else if (sql.EndsWith("and "))
                sql = sql.Remove(sql.Length - 4);
            
            comando.CommandText = sql;
            comando.CommandType = System.Data.CommandType.Text;

            comando.Parameters.Add(paramCodigoAssistido);
            comando.Parameters.Add(paramNome);
            comando.Parameters.Add(paramStatusAssistido);
            comando.Parameters.Add(paramStatusCadastro);
            comando.Parameters.Add(paramEstadoSaude);
            comando.Parameters.Add(paramDataEntrada);
            comando.Parameters.Add(paramDataSaida);

            leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            List<Assistido> assistidoLista = new List<Assistido>();
            Assistido objAssistido;
            ContatoDados objContatoDados = new ContatoDados();

            while (leitorDados.Read())
            {
                objAssistido = new Assistido();

                //Dados Tabela Pessoa
                objAssistido.CodigoPessoa = Convert.ToInt32(leitorDados["CodigoPessoa"]);
                if (leitorDados["CodigoContato"] != DBNull.Value)
                    objAssistido.Contato_CodigoContato = Convert.ToInt32(leitorDados["CodigoContato"]);
                if (objAssistido.Contato_CodigoContato.HasValue)
                    objAssistido.Contato = objContatoDados.ObterContato(objAssistido.Contato_CodigoContato.Value);
                objAssistido.CodigoCasaLar = Convert.ToInt32(leitorDados["CodigoCasaLar"]);
                objAssistido.Nome = leitorDados["Nome"].ToString();
                objAssistido.Sexo = leitorDados["Sexo"].ToString();
                objAssistido.CPF = leitorDados["CPF"].ToString();
                objAssistido.RG = leitorDados["RG"].ToString();
                objAssistido.TituloEleitor = leitorDados["TituloEleitor"].ToString();
                objAssistido.DataNascimento = Convert.ToDateTime(leitorDados["DataNascimento"]);
                objAssistido.Nacionalidade = leitorDados["Nacionalidade"].ToString();
                objAssistido.Naturalidade = leitorDados["Naturalidade"].ToString();
                objAssistido.Foto = leitorDados["Foto"].ToString();
                objAssistido.TipoPessoa = leitorDados["TipoPessoa"].ToString();
                objAssistido.Ativo = Convert.ToBoolean(leitorDados["Ativo"]);

                //Dados Tabela Assistido
                objAssistido.CodigoAssistido = Convert.ToInt32(leitorDados["CodigoAssistido"]);
                objAssistido.StatusAssistido = leitorDados["StatusAssistido"].ToString();
                if (leitorDados["CertidaoNascimento"] != DBNull.Value)
                    objAssistido.CertidaoNascimento = leitorDados["CertidaoNascimento"].ToString();
                objAssistido.DataEntrada = Convert.ToDateTime(leitorDados["DataEntrada"]);
                if (leitorDados["DataSaida"] != DBNull.Value)
                    objAssistido.DataSaida = Convert.ToDateTime(leitorDados["DataSaida"]); ;
                objAssistido.EstadoSaude = leitorDados["EstadoSaude"].ToString();
                objAssistido.Peso = Convert.ToDecimal(leitorDados["Peso"]);
                objAssistido.Etnia = leitorDados["Etnia"].ToString();
                objAssistido.Altura = Convert.ToDecimal(leitorDados["Altura"]);
                objAssistido.TamanhoCamisa = leitorDados["TamCamisa"].ToString();
                objAssistido.TamanhoCalca = leitorDados["TamCalca"].ToString();
                objAssistido.TamanhoCalcado = leitorDados["TamCalcado"].ToString();
                objAssistido.Dormitorio = leitorDados["Dormitorio"].ToString(); ;
                objAssistido.Deficiente = leitorDados["Deficiente"].ToString();
                objAssistido.Hobby = leitorDados["Hobby"].ToString();
                objAssistido.HistoricoVida = leitorDados["HistoricoVida"].ToString();
                objAssistido.Pai = leitorDados["NomePai"].ToString();
                objAssistido.Mae = leitorDados["NomeMae"].ToString();
                objAssistido.PaiVivo = leitorDados["PaiVivo"].ToString();
                objAssistido.MaeViva = leitorDados["MaeViva"].ToString();
                objAssistido.CPFPai = leitorDados["CPFPai"].ToString();
                objAssistido.CPFMae = leitorDados["CPFMae"].ToString();
                objAssistido.RGPai = leitorDados["RGPai"].ToString();
                objAssistido.RGMae = leitorDados["RGMae"].ToString();
                objAssistido.TelefonePai = leitorDados["TelefonePai"].ToString();
                objAssistido.TelefoneMae = leitorDados["TelefoneMae"].ToString();
                objAssistido.QtdIrmaos = Convert.ToInt32(leitorDados["QtdIrmaos"]);
                objAssistido.ResponsavelLegal = leitorDados["NomeResponsavel"].ToString();
                objAssistido.CPFResponsavel = leitorDados["CpfResponsavel"].ToString();

                if (leitorDados["CodigoContatoResponsavel"] != DBNull.Value)
                    objAssistido.CodigoContatoResponsavel = Convert.ToInt32(leitorDados["CodigoContatoResponsavel"]);
                else
                    objAssistido.CodigoContatoResponsavel = null;

                //Obtém dados de Contato do Responsável
                if (objAssistido.CodigoContatoResponsavel.HasValue)
                {
                    objAssistido.ContatoResponsavel = objContatoDados.ObterContato(objAssistido.CodigoContatoResponsavel.Value);
                }
                EscolarDados objEscolarDados = new EscolarDados();
                //objAssistido.Escolar = objEscolarDados.Ob

                assistidoLista.Add(objAssistido);
            }
            
            return assistidoLista;
        }


    }
}