using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex4
{
    public class Directeur : Employer
    {
        protected int _chiffreAffaire;
        protected int _pourcentage;

        public int ChiffreAffaire { get { return _chiffreAffaire; } }
        public int Pourcentage { get { return _pourcentage; } }

        public Directeur(string matricul, string nom, string prenom, DateTime dateNaissance, int chiffreAffaire, int pourcentage) : base(matricul, nom, prenom, dateNaissance)
        {
            _chiffreAffaire = chiffreAffaire;
            _pourcentage = pourcentage;
        }
        public override string Caract()
        {
            return
                "_matricul: " + _matricul + "\n" +
                "_nom: " + _nom + "\n" +
                "_prenom: " + _prenom + "\n" +
                "_dateNaissance: " + _dateNaissance + "\n" +
                "_chiffreAffaire: " + _chiffreAffaire + "\n" +
                "_pourcentage: " + _pourcentage + "\n";
        }
        public override string CalculerSalaire()
        {
            return $"salaire annuel de {_chiffreAffaire / 100 * _pourcentage}.";
        }
    }
}
