using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;

namespace SGS.CamadaDados
{
    public class BaseConnection
    {

        /// <summary>
        /// Este método conecta ao Banco de Dados
        /// </summary>
        /// <returns>System.Data.SqlClient.SqlConnection</returns>
        public System.Data.SqlClient.SqlConnection Conectar()
        {
            System.Data.SqlClient.SqlConnection sqlCon = 
                new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\SGS\3- Implementacao\3.1 - Aplicacao\ProjetoTela\App_Data\SGS.mdf"";Integrated Security=True;User Instance=True");

            sqlCon.Open();
            
            return sqlCon;
        }

        /// <summary>
        /// Este Método fecha a conexão que está aberta
        /// </summary>
        /// <param name="sqlCon"></param>
        public void Desconectar(System.Data.SqlClient.SqlConnection sqlCon)
        {
            sqlCon.Close();
            sqlCon.Dispose();
        }

        public void Teste()
        {

        }
    }
}