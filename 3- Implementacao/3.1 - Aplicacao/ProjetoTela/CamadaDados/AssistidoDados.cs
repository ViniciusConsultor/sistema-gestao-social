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
                          Peso, Cor, Altura, TamCamisa, TamCalca, TamCalcado, Dormitorio, Deficiente, Hobby, HistoricoVida, 
                          NomePai, NomeMae, PaiVivo, MaeViva, CPFPai, CPFMae, RGPai, RGMae, TelefonePai, TelefoneMae,  
                          QtdIrmaos, NomeResponsavel, CPFResponsavel, CodigoContatoResponsavel)
                    VALUES
                         (@codigoAssistido, @statusAssistido, @certidaoNascimento, @dataEntrada, @dataSaida, @estadoSaude,
                          @peso, @cor, @altura, @tamCamisa, @tamCalca, @tamCalcado, @dormitorio, @Deficiente, @Hobby, @historicoVida,
                          @nomePai, @nomeMae, @paiVivo, @maeViva, @cpfPai, @cpfMae, @rgPai, @rgMae, @telefonePai, @telefoneMae,
                          @qtdIrmaos, @nomeResponsavel, @cpfResponsavel, @codigoContatoResponsavel)";
            }
            else
            {
                comando.CommandText =
                    @"
                    UPDATE Assistido
                    SET  StatusAssistido = @statusAssistido, CertidaoNascimento = @certidaoNascimento, DataEntrada = @dataEntrada, 
                         DataSaida = @dataSaida, EstadoSaude = @estadoSaude, Peso = @peso, Cor = @cor, Altura = @altura, TamCamisa = @tamCamisa, 
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

            SqlParameter parametroCor = new SqlParameter("@cor", objAssistido.Cor);
            parametroCor.DbType = System.Data.DbType.String;

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
            comando.Parameters.Add(parametroCor);
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
                //          Peso, Cor, Altura, TamCamisa, TamCalca, TamCalcado, Dormitorio, Deficiente, Hobby, HistoricoVida, 
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
                objAssistido.Cor = leitorDados["Cor"].ToString();
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
                objAssistido.CPFResponsavel = leitorDados["NomeResponsavel"].ToString();
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
        /// Exclui o Assistido pelo seu código
        /// </summary>
        public bool ExcluirAssistido(int codigoAssistido)
        {
            bool execucao;

            //EscolarDados objEscolarDados = new EscolarDados();
            //VisitacaoDados objVisitacaoDados = new VisitacaoDados();
            //Procedimentos objProcedimentos = new Procedimentos();
            //DesenvolvimentoDados objDesenvolvimentoDados = new DesenvolvimentoDados();
            //ContatoDados objContatoDados = new ContatoDados();
            //AssistidoDados objAssistidoDados = new AssistidoDados();
            //PessoaDados objPessoaDados = new PessoaDados();

            //Sequencia Exclusão
            // 1° Deletar dados Escolares do Assistido.
            //objEscolarDados.ExcluirEscolar(
            // 2° Excluir Visitacao
            // 3° Excluir Procedimentos
            // 4° Excluir Desenvolvimento
            // 4° Excluir Contato Responsável
            // 5° Excluir Assistido
            // 6° Excluir Contato Pessoa
            // 7º Excluir Pessoa


            SqlCommand comando = new SqlCommand("UPDATE Assistido SET Excluido = '1' where CodigoAssistido = @codigoAssistido", base.Conectar());

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