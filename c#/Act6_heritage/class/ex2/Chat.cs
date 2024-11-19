using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex2
{
    public class Chat : Animaux
    {
        public Chat(string nom, DateTime dateNaissance, int puceNumber, float taille, bool concour) : base(nom, dateNaissance, puceNumber, taille, concour)
        {

        }
        public string Miauler()
        {
            return $"{_nom} a Miauler";
        }
        public string Ronronner()
        {
            return $"{_nom} a Ronronner";
        }
    }
}