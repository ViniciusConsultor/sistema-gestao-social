using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.CamadaDados
{
    public class CasaLarDados : SGS.CamadaDados.BaseConnection
    {
        /// <summary>
        /// Seleciona todos os dados da tabela Casa_Lar
        /// </summary>
        public void SelecionarTodos()
        {
            System.Data.SqlClient.SqlDataReader dr;
            
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("select * from Casa_Lar", base.Conectar());
            dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (dr.Read())
            {
                string x = dr["NomeCasaLar"].ToString();

            }

            dr.Close();
            dr.Dispose();

        }
    }
}