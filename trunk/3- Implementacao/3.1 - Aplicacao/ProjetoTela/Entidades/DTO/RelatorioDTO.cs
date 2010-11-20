using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{
     /// <summary>
    /// Esta classe retorna os dados do usuário logado que ficam na "SESSION".
    /// </summary>
    public static class RelatorioDTO
    {

        /// <summary>
        /// Retorna a entidade que contém todos os dados do Relatório.
        /// </summary>
        public static Object DadosRelatorio
        {
            get
            {
                return (Object)System.Web.HttpContext.Current.Session["DadosRelatorio"];
            }
            set
            {
                if (System.Web.HttpContext.Current.Session["DadosRelatorio"] != null)
                    System.Web.HttpContext.Current.Session["DadosRelatorio"] = value;
                else
                    System.Web.HttpContext.Current.Session.Add("DadosRelatorio", value);
            }
        }

    }

}