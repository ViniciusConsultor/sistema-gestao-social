using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SGS.Entidades.DTO
{
    /// <summary>
    /// Esta classe retorna os dados do usuário logado que ficam na "SESSION".
    /// </summary>
    public static class DadosAcesso
    {
        /// <summary>
        /// Retorna a entidade que contém todos os dados do usuário logado.
        /// </summary>
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

        /// <summary>
        /// Retorna o Perfil do usuário Logado. EX: "Gestor", "Funcionário"
        /// </summary>
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