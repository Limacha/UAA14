using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.classs
{
    internal class NombreComplexe
    {
        private double _reel;
        private double _imaginaire;

        public double Reel { get { return _reel; } set { _reel = value; } }
        public double Imaginaire { get { return _imaginaire; } set {  _imaginaire = value; } }

        public NombreComplexe(double reel, double imaginaire) 
        {
            _reel = reel;
            _imaginaire = imaginaire;
        }

        public string Afficher()
        {
            string message = "";
            message += $"{_reel}";
            if (_imaginaire >= 0)
            {
                message += $"+{_imaginaire}i";
            }
            else
            {
                message += $"{_imaginaire}i";
            }

            return message;
        }

        public string CalculModul()
        {
            return "Module total: " + Math.Sqrt(Math.Pow(_reel, 2) + Math.Pow(_imaginaire, 2));
        }

        public void Ajouter(NombreComplexe complex)
        {
            _reel += complex.Reel;
            _imaginaire += complex.Imaginaire;
        }
    }
}
