using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage.@class.ex1
{
    public class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;

        public string Motorisation { get { return _motorisation; } set { _motorisation = value; } }
        public bool Gps { get { return _gps; } set { _gps = value; } }

        public Voiture(string model, string marque, string couleur, decimal prix, string motorisation, bool gps) : base(model, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }

        public override string Affiche()
        {
            return $"{_modele}\n{_marque}\n{_couleur}\n{_prix}\n{_motorisation}\n{_gps}\n";
        }
    }
}
