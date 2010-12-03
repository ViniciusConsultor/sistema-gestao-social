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
                //String: Desenvolvimento
                new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\SGS\3- Implementacao\3.1 - Aplicacao\ProjetoTela\App_Data\SGS.mdf"";Integrated Security=True;User Instance=True");

                //String: Teste
                //new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQL2008;AttachDbFilename=""C:\Site\App_Data\SGS.mdf"";Integrated Security=True;User Instance=False");
                //new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Site\App_Data\SGS.mdf"";Integrated Security=True;User Instance=False");
                //new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\SGS\3- Implementacao\3.1 - Aplicacao\ProjetoTela\App_Data\SGS.mdf"";Integrated Security=True;User Instance=False");
                //new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQL2008;AttachDbFilename=""C:\SGS\3- Implementacao\3.1 - Aplicacao\ProjetoTela\App_Data\SGS.mdf"";Integrated Security=True;User Instance=False");
                //new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQL2008;AttachDbFilename=""C:\SGS\3- Implementacao\3.1 - Aplicacao\ProjetoTela\App_Data\SGS.mdf"";Integrated Security=false;User Instance=true;User Id=sa;Password=123456");
            
                //String: Produção
                //new System.Data.SqlClient.SqlConnection(@"Server=MAYCON-PC\SQL2008;initial catalog=SGS;User Id=sa;Password=123456;Connect Timeout=60;");

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