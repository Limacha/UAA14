using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin25_POO_NicolasPonchaut
{
    public class Pool
    {
        private int _identifiant; //l'id de la pool
        private List<Tireur> _tireurs; //les tireurs dedans
        private List<Arbitre> _arbitres; //les arbitres dedans
        private List<Match> _matchs; //les matchs de la pool

        public int Id { get { return _identifiant; } }
        public List<Tireur> Tireurs { get { return _tireurs; } }

        public Pool(int identifiant, List<Tireur> tireurs, List<Arbitre> arbitres, List<Match> matchs)
        {
            _identifiant = identifiant;
            _tireurs = tireurs;
            _arbitres = arbitres;
            _matchs = matchs;
        }


        /// <summary>
        /// trouve le numero de place dans la liste des tireurs de la pool, d'un tireur dont on connait l'id
        /// </summary>
        /// <param name="id">l'id du tireur</param>
        /// <returns>la position du tireur -1 si pas trouver</returns>
        public int ChercherPlaceDansList(int id)
        {
            for (int iTireur = 0; iTireur < _tireurs.Count(); iTireur++)
            {
                Tireur tireur = _tireurs[iTireur];
                if (tireur.Id == id)
                {
                    return iTireur;
                }
            }
            return -1;
        }

        /// <summary>
        /// determine si tous les matchs de la pool sont termines
        /// </summary>
        /// <returns>si tous est fini</returns>
        public bool Terminee()
        {
            foreach (Match match in _matchs)
            {
                if(match.Statut != "Terminé")
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// calcul et remplit les performances de chaque tireur de la pool pour tous les matchs Terminé de la pool
        /// </summary>
        public void CalculPerformancesParTireur()
        {
            foreach (Tireur tireur in _tireurs)
            {
                tireur.Performances.TouchesDonees = 0;
                tireur.Performances.TouchesRecues = 0;
                tireur.Performances.NbVictoire = 0;
            }
            foreach (Match match in _matchs)
            {
                if (match.Statut == "Terminé")
                {
                    Tireur t1 = _tireurs.Where((tireur) => { return tireur.Id == match.Tireur1.Id; }).First();
                    Tireur t2 = _tireurs.Where((tireur) => { return tireur.Id == match.Tireur2.Id; }).First();

                    t1.Performances.TouchesDonees += match.TouchesTireur1;
                    t1.Performances.TouchesRecues += match.TouchesTireur2;

                    t2.Performances.TouchesDonees += match.TouchesTireur2;
                    t2.Performances.TouchesRecues += match.TouchesTireur1;

                    if (match.TouchesTireur1 < match.TouchesTireur2)
                    {
                        t2.Performances.NbVictoire++;
                    }
                    else
                    {
                        t1.Performances.NbVictoire++;
                    }
                }
            }
        }

        /// <summary>
        /// prépare le listing  des informations des tireurs et des arbitres de la pool
        /// </summary>
        /// <returns>le listing complet sous forme de string</returns>
        public string AfficherParticipantsPool()
        {
            string tireurs = "";
            string arbitres = "";

            foreach (Tireur tireur in _tireurs)
            {
                tireurs += tireur.AfficheInfo() + "\n";
            }
            
            foreach (Arbitre arbitre in _arbitres)
            {
                arbitres += arbitre.AfficheInfo() + "\n";
            }

            return $"Tireurs de la pool {_identifiant}\n" +
                   $"=================================\n" +
                   $"{tireurs}" +
                   $"Arbitres de la pool {_identifiant}\n" +
                   $"=================================\n" +
                   $"{arbitres}";
        }

        /// <summary>
        /// prepare le listing du détail des matchs
        /// </summary>
        /// <returns>le listing sous forme de string</returns>
        public string AfficherRecapitulatifCompletMatchs()
        {
            string matchs = "";

            foreach (Match match in _matchs)
            {
                matchs += match.AfficheInfos();   
            }

            return matchs;
        }

        /// <summary>
        /// prépare le listing des informations des tireurs et de leurs performances
        /// </summary>
        /// <returns>le listing sous forme de string</returns>
        public string AfficherPreformancesTireurs()
        {
            string avertisement = (Terminee()) ? "Attention, résultats partiels : ils reste encore des matchs à réaliser\n------------------------------------------------------------------------\n" : "";
            string performances = "";

            foreach (Tireur tireur in _tireurs)
            {
                performances += "   " + tireur.AfficheInfo() + "\n";
                performances += "   ------------------------------------\n";
                performances += tireur.Performances.ToString() + "\n";
                performances += "   ------------------------------------\n\n";
            }

            return $"Voici les performances pour chaque tireur de la pool :\n"+
                   $"======================================================\n"+
                   $"\n" +
                   $"{avertisement}\n\n" +
                   $"{performances}";
        }
    }
}
