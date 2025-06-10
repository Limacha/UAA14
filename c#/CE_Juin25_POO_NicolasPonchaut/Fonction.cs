using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CE_Juin25_POO_NicolasPonchaut.ElementsFournis;

namespace CE_Juin25_POO_NicolasPonchaut
{
    public struct Fonction
    {
        /// <summary>
        /// prend une phrase et essaye de lire un int rentrer par l'utilisateur
        /// </summary>
        /// <param name="phrase">la question afficher</param>
        /// <param name="clear">cide la console ou pas</param>
        /// <returns>le chiffre de l'utilisateur</returns>
        public static int LireInt(string phrase, bool clear, int min, int max)
        {
            int x = 0;
            do
            {
                do
                {
                    if (clear) Console.Clear();
                    Console.WriteLine(phrase);
                } while (!int.TryParse(Console.ReadLine(), out x));
            } while (x > max || x < min);
            return x;
        }

        /// <summary>
        /// cree une pool avec l'id recu
        /// </summary>
        /// <param name="id">l'id de la pool</param>
        /// <param name="pool">la pool creez</param>
        /// <returns>si une erreur est survenu</returns>
        public static bool InitPool(int id, out Pool pool)
        {
            pool = null;
            List<Tireur> tireursPool = new List<Tireur>();
            List<Arbitre> arbitresPool = new List<Arbitre>();
            List<Match> matchsPool = new List<Match>();
            if (ExtraitInfosSelonRequete($"select * from pool where poolId={id};", out DataSet poolData))
            {
                if (ExtraitInfosSelonRequete($"SELECT * FROM Escrimeur where escrimeurId in (SELECT escrimeurId FROM participationPool WHERE poolId={id});", out DataSet escrimersData))
                {
                    if (ExtraitInfosSelonRequete($"SELECT Matchs.matchId, matchTouchesTireur1, matchTouchesTireur2, arbitreId, StatutId, tireurId1, tireurId2 FROM participationmatch INNER JOIN Matchs ON participationmatch.matchId = Matchs.matchId WHERE poolId= {id};", out DataSet matchData))
                    {
                        Console.WriteLine(escrimersData.Tables[0].Rows.Count);
                        for (int i = 0; i < escrimersData.Tables[0].Rows.Count; i++)
                        {
                            tireursPool.Add(new Tireur(
                                (int)escrimersData.Tables[0].Rows[i]["escrimeurId"],
                                escrimersData.Tables[0].Rows[i]["escrimeurNom"].ToString(),
                                escrimersData.Tables[0].Rows[i]["escrimeurPrenom"].ToString(),
                                new Performances(0,0,0)
                            ));
                        }

                        Console.WriteLine(matchData.Tables[0].Rows.Count);
                        for (int i = 0; i < matchData.Tables[0].Rows.Count; i++)
                        {
                            if (arbitresPool.Count((arbitre) => { return arbitre.Id == (int)matchData.Tables[0].Rows[i]["arbitreId"]; }) <= 0)
                            {
                                if (ExtraitInfosSelonRequete($"select * from escrimeur where escrimeurId={(int)matchData.Tables[0].Rows[i]["arbitreId"]};", out DataSet arbitreData))
                                {
                                    arbitresPool.Add(new Arbitre((int)arbitreData.Tables[0].Rows[0]["escrimeurId"], arbitreData.Tables[0].Rows[0]["escrimeurNom"].ToString(), arbitreData.Tables[0].Rows[0]["escrimeurPrenom"].ToString()));
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            if (ExtraitInfosSelonRequete($"select * from statut where statutId = {(int)matchData.Tables[0].Rows[i]["StatutId"]};", out DataSet statutData))
                            {
                                matchsPool.Add(new Match(
                                    (int)matchData.Tables[0].Rows[i]["matchId"],
                                    tireursPool.Where((tireur) => { return tireur.Id == (int)matchData.Tables[0].Rows[i]["tireurId1"]; }).First(),
                                    tireursPool.Where((tireur) => { return tireur.Id == (int)matchData.Tables[0].Rows[i]["tireurId2"]; }).First(),
                                    arbitresPool.Where((arbitre) => { return arbitre.Id == (int)matchData.Tables[0].Rows[i]["arbitreId"]; }).First(),
                                    (int)matchData.Tables[0].Rows[i]["matchTouchesTireur1"],
                                    (int)matchData.Tables[0].Rows[i]["matchTouchesTireur2"],
                                    statutData.Tables[0].Rows[0]["statutInfo"].ToString()
                                ));
                            }
                            else
                            {
                                return false;
                            }
                        }

                        pool = new Pool(id, tireursPool, arbitresPool, matchsPool);
                        pool.CalculPerformancesParTireur();
                        return true;
                    }
                }
            }
            return false;
        }
    
        /// <summary>
        /// ajoute les performances de la pool a la bdd
        /// </summary>
        /// <param name="pool">la pool</param>
        /// <returns>si la sauvegarde a reussit</returns>
        public static bool SavePerformance(Pool pool)
        {
            /*if(AjouterInfosSelonRequete("insert into performance (perfTouchesDonnees, perfTouchesRecues, perfNbVictoires, poolId, escrimeurId) values (1,2,3,2,3);"))
            {
                return true;
            }*/

            foreach (Tireur tireur in pool.Tireurs)
            {
                Performances perf = tireur.Performances;
                if (!AjouterInfosSelonRequete($"insert into performance (perfTouchesDonnees, perfTouchesRecues, perfNbVictoires, poolId, escrimeurId) values ({perf.TouchesDonees},{perf.TouchesRecues},{perf.NbVictoire},{pool.Id},{tireur.Id});"))
                {
                    return false;
                }
            }
            return true;
        }
    }
}