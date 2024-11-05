using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_heritage
{
    public class Velo : Vehicule
    {
        private string _type;
        private bool _estElec;

        public string Type { get { return _type; } set { _type = value; } }
        public bool EstElec { get { return _estElec; } set { _estElec = value; } }

        public Velo(string model, string marque, string couleur, decimal prix,string type, bool estElec) : base(model, marque, couleur, prix)
        {
            _type = type;
            _estElec = estElec;
        }

        public override string Affiche()
        {
            return $"{_modele}\n{_marque}\n{_couleur}\n{_prix}\n{_type}\n{_estElec}\n";
        }
    }
}
