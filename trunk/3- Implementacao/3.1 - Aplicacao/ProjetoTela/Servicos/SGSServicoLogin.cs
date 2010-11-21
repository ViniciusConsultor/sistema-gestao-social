using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;
using SGS.CamadaDados;
using SGS.Entidades.DTO;

namespace SGS.Servicos
{
    public partial class SGSServico
    {

        public Login ValidarLogin(Login objLogin)
        {
            LoginDados objLoginDados = new LoginDados();
            
            return objLoginDados.Validar(objLogin);
        }

        public Login SalvarLogin(Login objLogin)
        {
            LoginDados objLoginDados = new LoginDados();

            objLogin = objLoginDados.Salvar(objLogin);

            return objLogin;
        }

        public Login ObterLogin(int codigoLogin)
        {
            LoginDados objLoginDados = new LoginDados();

            return objLoginDados.Obter(codigoLogin);
        }

        public bool ExcluirLogin(int codigoLogin)
        {
            LoginDados objLoginDados = new LoginDados();

            return objLoginDados.Excluir(codigoLogin);
        }

        /// <summary>
        /// Consulta a tabela Login e retorna resultados de acordo com o preenchimento do filtro 
        /// </summary>
        public LoginDTO ConsultarLogin(LoginDTO objLoginDTO)
        {
            LoginDados objLoginDados = new LoginDados();
            objLoginDTO.LoginLista = objLoginDados.Consultar(objLoginDTO);

            return objLoginDTO;

        }

    }
}