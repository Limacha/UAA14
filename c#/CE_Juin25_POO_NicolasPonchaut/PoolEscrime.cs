using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin25_POO_NicolasPonchaut
{
    public static class ElementsFournis
    {
        public static string DefinirCheminBD()
        {
            return "server=localhost;database=poolescrime;port=3306;User Id=root;password=root";
        }

        public static bool ExtraitInfosSelonRequete(string query, out DataSet infos)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            try
            {
                maConnection.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                infos = new DataSet();
                da.Fill(infos);

                if (infos.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

            return ok;
        }

        /// <summary>
        /// effectue la query
        /// </summary>
        /// <param name="query">la query a executer</param>
        /// <returns>si pas de crash</returns>
        public static bool AjouterInfosSelonRequete(string query)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            try
            {
                maConnection.Open();

                MySqlCommand da = new MySqlCommand(query, maConnection);
                da.ExecuteNonQuery();
                maConnection.Close();
                ok = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

            return ok;
        }

        // "SELECT * FROM Escrimeur where escrimeurId in (SELECT escrimeurId FROM participationPool WHERE poolId= ...);"

        // "SELECT * FROM Escrimeur WHERE escrimeurId in (SELECT DISTINCT arbitreId FROM Matchs WHERE poolId= ...);"

        // "SELECT Matchs.matchId, matchTouchesTireur1, matchTouchesTireur2, arbitreId, StatutId, tireurId1, tireurId2 FROM participationmatch INNER JOIN Matchs ON participationmatch.matchId = Matchs.matchId WHERE poolId= ...;"

        // "SELECT * FROM Escrimeur WHERE escrimeurId= ...;"

        // "SELECT statutInfo FROM Statut WHERE statutId= ...;"

        // pour rappel, exemple usage dataset : (int)dataSetInfos.Tables[0].Rows[iEnregistrement]["escrimeurId"]
        // ou encore infoStatut.Tables[0].Rows[0]["statutInfo"].ToString()

        // bon travail...

    }
}