using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAct11.classe
{
    public class Academie
    {
        private string _nom;
        private List<Ecole> _listeEcole;

        public void AjouteEcole(Ecole ecole)
        {
            _listeEcole.Add(ecole);
        }

        public string Afficher()
        {
            var affichage = "";
            foreach (var ecole in _listeEcole)
            {
                foreach (var departement in ecole.ListeDepartement)
                {
                    affichage += ecole.Afficher(departement);
                }
            }
            return affichage;
        }
    }
}
