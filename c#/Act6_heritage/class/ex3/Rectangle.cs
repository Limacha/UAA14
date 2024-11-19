using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex3
{
    public class Rectangle: Parellepipede
    {
        private float _longeur;
        private float _largeur;
        public float Longeur { get { return _longeur; } }
        public float Largeur { get { return _largeur; } }
        public Rectangle(string couleur, float longeur, float largeur) : base(couleur)
        {
            _longeur = longeur;
            _largeur = largeur;
        }
        public override float CalculerSurface()
        {
            return _longeur * _largeur;
        }
        public override float CalculerPerimetre()
        {
            return (_longeur + _largeur) * 2;
        }
    }
}