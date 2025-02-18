using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAct11.classe
{
    public class Departement
    {
        private string _nom;
        private string _matiere;
        private List<Enseignant> _listeEnseignants;

        public string Nom { get { return _nom; } }
        public string Matiere {  get { return _matiere; } }
        public Departement(string nom, string matiere, List<Enseignant> listeEnseignants) 
        { 
            _nom = nom;
            _matiere = matiere;
            _listeEnseignants = listeEnseignants;
        }
        public void AjouterEnseignat(Enseignant enseignant)
        {
            _listeEnseignants.Add(enseignant);
        }
    }
}
