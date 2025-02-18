using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAct11.classe
{
    public class Etudiant
    {
        private int _anneeEntree;
        private List<InfoCours> _listCours;

        public Etudiant (int anneeEntree, List<InfoCours> listCours)
        {
            _anneeEntree = anneeEntree;
            _listCours = listCours;
        }
        public double CalculerMoyenneGenerale()
        {
            double moyene = 0;
            foreach (var cours in _listCours)
            {
                moyene += cours.note;
            }
            return moyene/_listCours.Count;
        }
        public string AfficherMatieresNotees()
        {
            string affichage = "";
            foreach (var item in _listCours)
            {
                affichage += item.cours.Nom + "\n";
            }
            return affichage;
        }
    }
}
