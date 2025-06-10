using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin25_POO_NicolasPonchaut
{
    public class Performances
    {
        private int _touchesDonnees; //touche donne par le tireur
        private int _touchesRecues; //touche recues par le tireur
        private int _nbVictoire; //nombre de victoire

        public int TouchesDonees { get { return _touchesDonnees; } set { _touchesDonnees = value; } }
        public int TouchesRecues { get { return _touchesRecues; } set { _touchesRecues = value; } }
        public int NbVictoire { get { return _nbVictoire; } set { _nbVictoire = value; } }

        public Performances (int touchesDonnees, int touchesRecues, int nbVictoire)
        {
            _touchesDonnees = touchesDonnees;
            _touchesRecues = touchesRecues;
            _nbVictoire = nbVictoire;
        }



        /// <summary>
        /// tansforme la class en string avec les perfs afficher
        /// </summary>
        /// <returns>les perfs en string</returns>
        public override string ToString()
        {
            return $"   Touches données {_touchesDonnees}\n" +
             $"   Touches reçues : {_touchesRecues}\n" +
             $"   Nombre de victoire : {_nbVictoire}";
        }
    }
}
