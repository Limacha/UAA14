using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CE_Juin25_POO_NicolasPonchaut
{
    public class Arbitre : Humain
    {
        public Arbitre(int id, string nom, string prenom): base(id,nom,prenom) { }

        /// <summary>
        /// affiche les infos de l'arbitre
        /// </summary>
        /// <returns>les infos</returns>
        public override string AfficheInfo()
        {
            return $"Arbitre {Id} {Nom} {Prenom}";
        }
    }
}
