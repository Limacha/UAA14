using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAct11.classe
{
    public class Ecole
    {
        private string _codeEcole;
        private string _siteInternet;
        private List<Salle> _listeSalle;
        private List<Departement> _listeDepartement;
        public List<Departement> ListeDepartement { get { return _listeDepartement; } }

        public Ecole(string codeEcole, string siteInternet, List<Salle> listeSalle, List<Departement> listeDepartement)
        {
            _codeEcole = codeEcole;
            _siteInternet = siteInternet;
            _listeSalle = listeSalle;
            _listeDepartement = listeDepartement;
        }

        public void AjouterDepartment(Departement departement)
        {
            _listeDepartement.Add(departement);
        }

        public string Afficher(Departement departement)
        {
            return "nom:" + departement.Nom + "\nmat:" + departement.Matiere;
        }
    }
}
