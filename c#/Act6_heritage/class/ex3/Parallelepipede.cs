using Act6_heritage.@class.ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex3
{
    public abstract class Parellepipede
    {
        protected string _couleur;

        public string Couleur { get { return _couleur; } }

        public Parellepipede(string couleur) 
        {
            _couleur = couleur;
        }
        public abstract float CalculerSurface();
        public abstract float CalculerPerimetre();
    }
}
