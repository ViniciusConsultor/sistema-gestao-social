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
    public class FuncionarioDados : BaseConnection
    {

        public Funcionario Salvar(Funcionario objFuncionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = base.Conectar();


            if (!objFuncionario.CodigoFuncionario.HasValue)
            {
                comando.CommandText =
                    @"INSERT INTO Funcionario (Pessoa_CodigoPessoa, Cargo, Salario, DataContratacao, NumCTPS, PIS, GrauEscolaridade, CursoFormacao, EstadoCivil
                                  CertidaoNascimento, CertidaoCasamento, QtdFilhos, CertificadoReservista)
                    VALUES (@pessoa_CodigoPessoa, @cargo, @salario, @dataContratacao, @numCTPS, @pis, @grauEscolaridade, @cursoFormacao,
                            @estadoCivil, @certidaoNascimento, @certidaoCasamento, @qtdFilhos, @certificadoReservista)";
            }
            else
            {
                comando.CommandText =
                    @"UPDATE Funcionario SET Pessoa_CodigoPessoa = @pessoa_CodigoPessoa, Cargo = @cargo, Salario = @salario,
                             DataContratacao = @dataContratacao, NumCTPS = @numCTPS, PIS = @pis, GrauEscolaridade = @grauEscolaridade,
                             CursoFormacao = @cursoFormacao, EstadoCivil = @estadoCivil, CertidaoNascimento = @certidaoNascimento,
                             CertidaoCasamento = @certidaoCasamento, QtdFilhos = @qtdFilhos, CertificadoReservista = @certificadoReservista)";
            }

            comando.CommandType = System.Data.CommandType.Text;
            if (objFuncionario.CodigoFuncionario.HasValue)
            {
                SqlParameter parametroCodigo = new SqlParameter("@codigoFuncionario", objFuncionario.CodigoFuncionario.Value);
                parametroCodigo.DbType = System.Data.DbType.Int32;
                comando.Parameters.Add(parametroCodigo);
            }

            SqlParameter parametroPessoa_CodigoPessoa = new SqlParameter();
            if (objFuncionario.Pessoa_CodigoPessoa.HasValue)
            {
                parametroPessoa_CodigoPessoa.Value = objFuncionario.Pessoa_CodigoPessoa.Value;
                parametroPessoa_CodigoPessoa.ParameterName = "@pessoa_CodigoPessoa";
                parametroPessoa_CodigoPessoa.DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametroPessoa_CodigoPessoa.Value = DBNull.Value;
                parametroPessoa_CodigoPessoa.ParameterName = "@pessoa_CodigoPessoa";
                parametroPessoa_CodigoPessoa.DbType = System.Data.DbType.Int32;
            }

            SqlParameter parametroCargo = new SqlParameter("@cargo", objFuncionario.Cargo);
            parametroCargo.DbType = System.Data.DbType.String;

            SqlParameter parametroSalario = new SqlParameter("@salario", objFuncionario.Salario);
            parametroSalario.DbType = System.Data.DbType.Decimal;

            SqlParameter parametroDataContratacao = new SqlParameter("@dataContratacao", objFuncionario.DataContratacao);
            parametroDataContratacao.DbType = System.Data.DbType.DateTime;

            SqlParameter parametroNumCTPS = new SqlParameter("@numCTPS", objFuncionario.NumCTPS);
            parametroNumCTPS.DbType = System.Data.DbType.String;

            SqlParameter parametroPIS = new SqlParameter("@pis", objFuncionario.PIS);
            parametroPIS.DbType = System.Data.DbType.String;

            SqlParameter parametroGrauEscolaridade = new SqlParameter("@grauEscolaridade", objFuncionario.GrauEscolaridade);
            parametroGrauEscolaridade.DbType = System.Data.DbType.String;

            SqlParameter parametroCursoFormacao = new SqlParameter("@cursoFormacao", objFuncionario.CursoFormacao);
            parametroCursoFormacao.DbType = System.Data.DbType.String;

            SqlParameter parametroEstadoCivil = new SqlParameter("@estadoCivil", objFuncionario.EstadoCivil);
            parametroEstadoCivil.DbType = System.Data.DbType.String;

            SqlParameter parametroCertidaoNascimento = new SqlParameter("@certidaoNascimento", objFuncionario.CertidaoNascimento);
            parametroCertidaoNascimento.DbType = System.Data.DbType.String;

            SqlParameter parametroCertidaoCasamento = new SqlParameter("@certidaoCasamento", objFuncionario.CertidaoCasamento);
            parametroCertidaoCasamento.DbType = System.Data.DbType.String;

            SqlParameter parametroQtdFilhos = new SqlParameter("@qtdFilhos", objFuncionario.QtdFilhos);
            parametroQtdFilhos.DbType = System.Data.DbType.Int32;

            SqlParameter parametroCertificadoReservista = new SqlParameter("@certificadoReservista", objFuncionario.CertificadoReservista);
            parametroCertificadoReservista.DbType = System.Data.DbType.String;


            comando.Parameters.Add(parametroPessoa_CodigoPessoa);
            comando.Parameters.Add(parametroCargo);
            comando.Parameters.Add(parametroSalario);
            comando.Parameters.Add(parametroDataContratacao);
            comando.Parameters.Add(parametroNumCTPS);
            comando.Parameters.Add(parametroPIS);
            comando.Parameters.Add(parametroGrauEscolaridade);
            comando.Parameters.Add(parametroEstadoCivil);
            comando.Parameters.Add(parametroCertidaoNascimento);
            comando.Parameters.Add(parametroCertidaoCasamento);
            comando.Parameters.Add(parametroQtdFilhos);
            comando.Parameters.Add(parametroCertificadoReservista);


            comando.ExecuteNonQuery();

            //TODO: retorno entidade Funcionario com o Código do Funcionario Preenchido
            return objFuncionario;
        }

        /// <summary>
        /// Obtém o Funcionario pelo Código do Funcionario
        /// </summary>
        /// <param name="codigoFuncionario"></param>
        /// <returns></returns>
        public Funcionario ObterFuncionario(int codigoFuncionario)
        {
            SqlCommand comando = new SqlCommand("select * from Funcionario where CodigoFuncionario = @codigoFuncionario", base.Conectar());
            SqlParameter parametroCodigoFuncionario = new SqlParameter("@codigoFuncionario", codigoFuncionario);
            parametroCodigoFuncionario.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoFuncionario);

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Funcionario objFuncionario = null;

            if (leitorDados.Read())
            {
                objFuncionario = new Funcionario();

                objFuncionario.CodigoFuncionario = codigoFuncionario;
                objFuncionario.Pessoa_CodigoPessoa = Convert.ToInt32(leitorDados["Pessoa_CodigoPessoa"]);
                objFuncionario.Cargo = leitorDados["Cargo"].ToString();
                objFuncionario.Salario = Convert.ToDecimal(leitorDados["Salario"]);
                objFuncionario.DataContratacao = Convert.ToDateTime(leitorDados["DataContratacao"]);
                objFuncionario.NumCTPS = leitorDados["NumCTPS"].ToString();
                objFuncionario.PIS = leitorDados["PIS"].ToString();
                objFuncionario.GrauEscolaridade = leitorDados["GrauEscolaridade"].ToString();
                objFuncionario.CursoFormacao = leitorDados["CursoFormacao"].ToString();
                objFuncionario.EstadoCivil = leitorDados["EstadoCivil"].ToString();
                objFuncionario.CertidaoNascimento = leitorDados["CertidaoNascimento"].ToString();
                objFuncionario.CertidaoCasamento = leitorDados["CertidaoCasamento"].ToString();
                objFuncionario.QtdFilhos = Convert.ToInt32(leitorDados["QtdFilhos"]);
                objFuncionario.CertificadoReservista= leitorDados["CertificadoReservista"].ToString();

            }

            leitorDados.Close();
            leitorDados.Dispose();

            return objFuncionario;
        }

        /// <summary>
        /// Exclui um Funcionario pelo seu código
        /// </summary>
        public bool ExcluirFuncionario(int codigoFuncionario)
        {
            bool execucao;

            SqlCommand comando = new SqlCommand("delete from Funcionario where CodigoFuncionario = @codigoFuncionario", base.Conectar());

            SqlParameter parametroCodigoFuncionario = new SqlParameter("@codigoFuncionario", codigoFuncionario);
            parametroCodigoFuncionario.DbType = System.Data.DbType.Int32;
            comando.Parameters.Add(parametroCodigoFuncionario);

            execucao = Convert.ToBoolean(comando.ExecuteNonQuery());

            return execucao;
        }

    }
}