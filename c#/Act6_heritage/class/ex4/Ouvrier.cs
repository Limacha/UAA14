using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex4
{
    public class Ouvrier: Employer
    {
        protected DateTime _dateEntree;

        public DateTime DateEntree { get { return _dateEntree; } }

        public Ouvrier(string matricul, string nom, string prenom, DateTime dateNaissance, DateTime dateEntree): base(matricul, nom, prenom, dateNaissance)
        {
            _dateEntree = dateEntree;
        }
        public override string Caract()
        {
            return
                "_matricul: " + _matricul + "\n" +
                "_nom: " + _nom + "\n" +
                "_prenom: " + _prenom + "\n" +
                "_dateNaissance: " + _dateNaissance + "\n" +
                "_dateEntree: " + _dateEntree + "\n";
        }
        public override string CalculerSalaire()
        {
            int salaire = 2500 + 100 * (DateTime.Now.Year - _dateEntree.Year);
            if(salaire > 5000)
            {
                salaire = 5000;
            }
            return $"salaire de {salaire} écus.";
        }
    }
}
