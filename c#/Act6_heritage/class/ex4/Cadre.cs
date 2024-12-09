using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex4
{
    public class Cadre : Employer
    {
        protected int _indice;

        public int Indice { get { return _indice; } }

        public Cadre(string matricul, string nom, string prenom, DateTime dateNaissance, int indice) : base(matricul, nom, prenom, dateNaissance)
        {
            _indice = indice;
        }
        public override string Caract()
        {
            return
                "_matricul: " + _matricul + "\n" +
                "_nom: " + _nom + "\n" +
                "_prenom: " + _prenom + "\n" +
                "_dateNaissance: " + _dateNaissance + "\n" +
                "_indice: " + _indice + "\n";
        }
        public override string CalculerSalaire()
        {
            switch (_indice)
            {
                case 1:
                    return "salaire mensuel 13000 écus.";
                case 2:
                    return "salaire mensuel 15000 écus.";
                case 3:
                    return "salaire mensuel 17000 écus.";
                case 4:
                    return "salaire mensuel 20000 écus.";
            }
            return "erreur 404.";
        }
    }
}
