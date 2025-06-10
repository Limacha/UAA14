using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin25_POO_NicolasPonchaut
{
    public class Tireur: Humain
    {
        private Performances _performances; //les perf du joueurs
        public Performances Performances { get { return _performances; } }

        public Tireur(int id, string nom, string prenom, Performances performance) : base(id, nom, prenom)
        {
            _performances = performance;
        }

        /// <summary>
        /// affiche les infos du joueur
        /// </summary>
        /// <returns>les infos</returns>
        public override string AfficheInfo()
        {
            return $"Tireur {Id} {Nom} {Prenom}";
        }
    }
}
