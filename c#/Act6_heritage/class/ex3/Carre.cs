using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex3
{
    public class Carre : Parellepipede
    {
        private float _longeur;
        public float Longeur { get { return _longeur; } }
        public Carre(string couleur, float longeur) : base(couleur)
        {
            _longeur = longeur;
        }
        public override float CalculerSurface()
        {
            return _longeur * _longeur;
        }
        public override float CalculerPerimetre()
        {
            return (_longeur + _longeur) * 2;
        }
    }
}