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
using System.Security.Policy;


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

        public DataSet CallQueryIntelligent(string query, Dictionary<string, string> set)
        {
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            DataSet infos = new DataSet();
            try
            {
                maConnection.Open();
                Console.WriteLine(query);
                MySqlCommand upDateCommand = new MySqlCommand(query, maConnection);
                foreach (var val in set)
                {
                    upDateCommand.Parameters.AddWithValue($"@{val.Key}", val.Value);
                }
                upDateCommand.ExecuteNonQuery();
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
        public void DeleteFromId(string[] select, string from, string where)
        {
            string query = $"delete from {from} where {where};";
            Console.WriteLine(query);
            DataSet infos = CallQuery(query);

            SelectFromWhere(select, from);
        }

        public void AddItem(string table, Dictionary<string, string> set)
        {
            string query = $"INSERT INTO {table}(";
            foreach (var val in set)
            {
                query += ($"{val.Key}, ");
            }
            query = query.Substring(0, query.Length - 2);
            query += ") VALUES(";
            foreach (var val in set)
            {
                query += ($"@{val.Key}, ");
            }
            query = query.Substring(0, query.Length - 2);
            query += ");";
            CallQueryIntelligent(query, set);
        }

        public void EditItem(string table, Dictionary<string, string> set, string where)
        {
            string sete = "";
            foreach (var val in set)
            {
                sete += ($"{val.Key} = @{val.Key}, ");
            }
            sete = sete.Substring(0, sete.Length-2);
            CallQueryIntelligent($"UPDATE {table} SET {sete} WHERE {where};", set);
        }
    }
}
