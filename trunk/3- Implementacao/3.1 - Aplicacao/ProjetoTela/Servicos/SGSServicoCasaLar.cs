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
        public CasaLar ObterCasaLar(int codigoCasaLar)
        {
            CasaLarDados objCasaLarDados = new CasaLarDados();

            return objCasaLarDados.ObterCasaLar(codigoCasaLar);
        }


    }
}