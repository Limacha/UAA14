using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAct11.classe
{
    public class Enseignant: Personne
    {
        private DateTime _datePriseFonction;
        private string _matiere;
        private List<Cours> _listeCours = new List<Cours>();

        public Enseignant(DateTime datePriseFonction, string matiere)
        {
            _datePriseFonction = datePriseFonction;
            _matiere = matiere;
        }

        public void AjouterCours(Cours cour)
        {
            _listeCours.Add(cour);
        }
    }
}
