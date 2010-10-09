using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SGS.Entidades.DTO
{
    public static class DadosAcesso
    {

        public static SessaoDTO SessaoDTO
        {
            get
            {
                 return (SessaoDTO)System.Web.HttpContext.Current.Session["Sessao"];
            }
            set
            {
                if (System.Web.HttpContext.Current.Session["Sessao"] != null)
                    System.Web.HttpContext.Current.Session["Sessao"] = value;
                else
                    System.Web.HttpContext.Current.Session.Add("Sessao", value);

            }
        }

        public static string Perfil
        {
            get
            {
                if (DadosAcesso.SessaoDTO != null && DadosAcesso.SessaoDTO.Login != null)
                    return DadosAcesso.SessaoDTO.Login.Perfil;
                else
                    return "";
            }
        }

    }
}