using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex4
{
    public abstract class Ouvrier
    {
        protected DateTime _dateEntree;

        public DateTime Date { get { return _dateEntree; } }

        public Ouvrier(string matricul, string nom, string prenom, DateTime dateNaissance)
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
