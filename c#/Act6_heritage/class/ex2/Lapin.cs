using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex2
{
    public class Lapin : Animaux
    {
        private float _tailleOreille;
        public float TailleOreille { get { return _tailleOreille; } }

        public Lapin(string nom, DateTime dateNaissance, int puceNumber, float taille, bool concour, float tailleOreille) : base(nom, dateNaissance, puceNumber, taille, concour)
        {
            _tailleOreille = tailleOreille;
        }
        public string FaireBond()
        {
            return $"{_nom} a fait un bond";
        }
    }
}