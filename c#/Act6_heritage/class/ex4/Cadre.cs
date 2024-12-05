using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex4
{
    public abstract class Cadre
    {
        protected string _matricul;
        protected string _nom;
        protected string _prenom;
        protected DateTime _dateNaissance;

        public string Matricul { get { return _matricul; } }
        public string Nom { get { return _nom; } }
        public string Prenom { get { return _prenom; } }
        public DateTime DateNaissance { get { return _dateNaissance; } }

        public Cadre(string matricul, string nom, string prenom, DateTime dateNaissance)
        {
            _matricul = matricul;
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
        }
        public abstract string Caract();
        public abstract string CalculerSalaire();
    }
}
