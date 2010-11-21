using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SGS.CamadaDados;
using SGS.Entidades;

namespace SGS.Servicos
{
    
    public partial class SGSServico
    {
        /// <summary>
        /// Este método retorna uma Casa Lar conforme o código do parâmetro
        /// </summary>
        /// <param name="codigoCasaLar"> Representa o código da Casa Lar</param>
        /// <returns></returns>

        public CasaLar SalvarCasaLar(CasaLar objCasaLar)
        {
            CasaLarDados objCasaLarDados = new CasaLarDados();

            objCasaLar = objCasaLarDados.Salvar(objCasaLar);

            return objCasaLar;
        }

        /// <summary>
        /// Este método obtém uma Casa Lar pelo seu código
        /// </summary>
        /// <param name="codigoCasaLar"></param>
        /// <returns></returns>
        public CasaLar ObterCasaLar(int codigoCasaLar)
        {
            CasaLarDados objCasaLarDados = new CasaLarDados();

            return objCasaLarDados.ObterCasaLar(codigoCasaLar);
        }

        /// <summary>
        /// Este método obtém uma Casa Lar sem o seu código
        /// </summary>
        /// <param name="codigoCasaLar"></param>
        /// <returns></returns>
        public CasaLar ObterCasaLar()
        {
            CasaLarDados objCasaLarDados = new CasaLarDados();

            return objCasaLarDados.Obter();
        }

        /// <summary>
        /// Este método exclui a casa lar e o seu respectivo contato.
        /// </summary>
        /// <param name="codigoCasaLar"></param>
        /// <param name="codigoContato"></param>
        /// <returns></returns>
        public bool ExcluirCasaLar(int codigoCasaLar, int codigoContato)
        {
            CasaLarDados objCasaLarDados = new CasaLarDados();

            return objCasaLarDados.Excluir(codigoCasaLar,codigoContato);
        }

    }
}