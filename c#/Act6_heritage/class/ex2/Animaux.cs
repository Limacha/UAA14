using Act6_heritage.@class.ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex2
{
    public abstract class Animaux
    {
        protected string _nom;
        protected DateTime _dateNaissance;
        protected int _puceNumber;
        protected float _taille;
        protected bool _concour;

        public string Nom { get { return _nom; } }
        public DateTime DateNaissance { get { return _dateNaissance; } }
        public int PuceNumber { get { return _puceNumber; } }
        public float Taille { get { return _taille; } }
        public bool Concour { get { return _concour; } }

        public Animaux(string nom, DateTime dateNaissance, int puceNumber, float taille, bool concour) 
        {
            _nom = nom;
            _dateNaissance = dateNaissance;
            _puceNumber = puceNumber;
            _taille = taille;
            _concour = concour;
        }
        public string Manger()
        {
            return $"{_nom} a manger";
        }
        public string Boire()
        {
            return $"{_nom} a but";
        }
    }
}
