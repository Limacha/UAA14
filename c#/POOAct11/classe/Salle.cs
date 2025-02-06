using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAct11.classe
{
    public class Salle
    {
        private string _nom;
        private int _nombrePlaces;

        public Salle(string nom, int nombrePlaces) 
        { 
            _nom = nom;
            _nombrePlaces = nombrePlaces;
        }

        public string Info()
        {
            return _nom + " " + _nombrePlaces;
        }
    }
}
