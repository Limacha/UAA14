using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex2
{
    public class Chien: Animaux
    {
        public Chien(string nom, DateTime dateNaissance, int puceNumber, float taille, bool concour) : base(nom, dateNaissance, puceNumber, taille, concour)
        {

        }
        public string Aboyer()
        {
            return $"{_nom} a aboyer";
        }
    }
}