using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGS.Entidades;
using System.Data.Sql;
using System.Data.SqlClient;
namespace SGS.CamadaDados
{
    public class AlimentoDados : BaseConnection
    {

        public List<Alimento> Listar()
        {
            List<Alimento> AlimentoLista = new List<Alimento>();
            Alimento objAlimento = null;

            SqlCommand comando = new SqlCommand(@"select * from Alimento ORDER BY NomeAlimento ASC", base.Conectar());

            SqlDataReader leitorDados = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (leitorDados.Read())
            {
                objAlimento = new Alimento();

                //Dados Tabela Alimento
                objAlimento.CodigoAlimento = Convert.ToInt32(leitorDados["CodigoAlimento"]);
                objAlimento.NomeAlimento = leitorDados["NomeAlimento"].ToString();

                AlimentoLista.Add(objAlimento);
            }

            leitorDados.Close();
            leitorDados.Dispose();

            return AlimentoLista;
        }

    }
}