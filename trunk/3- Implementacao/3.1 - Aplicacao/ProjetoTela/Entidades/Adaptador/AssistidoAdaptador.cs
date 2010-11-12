using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.Adaptador
{
    public class AssistidoAdaptador
    {
        /// <summary>
        /// Este método adapta uma Pessoa para a entidade Assistido
        /// </summary>
        /// <param name="objPessoa"></param>
        /// <returns></returns>
        public Assistido AdaptarPessoaParaAssistido(Pessoa objPessoa)
        {
            Assistido objAssistido = new Assistido();

            objAssistido.CodigoCasaLar = objPessoa.CodigoCasaLar;
            objAssistido.CodigoPessoa = objPessoa.CodigoPessoa;
            objAssistido.CodigoAssistido = objPessoa.CodigoPessoa;
            objAssistido.Contato = objPessoa.Contato;
            objAssistido.Contato_CodigoContato = objPessoa.Contato_CodigoContato;
            objAssistido.CPF = objPessoa.CPF;
            objAssistido.DataNascimento = objPessoa.DataNascimento;
            objAssistido.Foto = objPessoa.Foto;
            objAssistido.Nacionalidade = objPessoa.Nacionalidade;
            objAssistido.Naturalidade = objPessoa.Naturalidade;
            objAssistido.Nome = objPessoa.Nome;
            objAssistido.RG = objPessoa.RG;
            objAssistido.Sexo = objPessoa.Sexo;
            objAssistido.TipoPessoa = objPessoa.TipoPessoa;
            objAssistido.TituloEleitor = objPessoa.TituloEleitor;
            objAssistido.Ativo = objPessoa.Ativo;

            return objAssistido;
        }

    }
}