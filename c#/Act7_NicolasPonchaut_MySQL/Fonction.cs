using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Collections;
using System.Data.Common;
using Google.Protobuf.WellKnownTypes;


namespace Act7_NicolasPonchaut_MySQL
{
    internal class Fonction
    {
        static string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=localhost;database=immo;port=3306;User Id=root;password=root";
        }
        public DataSet CallQuery(string query)
        {
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            DataSet infos = new DataSet();
            try
            {
                maConnection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                da.Fill(infos, "mesDonnees");
                maConnection.Close();
                return infos;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public void SelectFromWhere(string[] select, string from, string where = "")
        {
            string query = (where != "") ? $"SELECT * FROM {from} where {where}; " : $"SELECT * FROM {from};";
            DataSet infos = CallQuery(query);

            for (int i = 0; i < infos.Tables[0].Rows.Count; i++)
            {
                foreach (var row in select)
                {
                    Console.Write(infos.Tables[0].Rows[i][row].ToString() + "  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

    }
}
