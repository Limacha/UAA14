using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P624_PonchautNicolas
{
    internal class FeuDeSignalisation
    {
        private int _couleur; //couleur du feu
        private string _identifiant; //l'identifiant du feu
        private bool _etat; //etat de la lampe
        /// <summary>
        /// couleur du feu en int (0 default pour rouge)
        /// </summary>
        public int Couleur { get { return _couleur; } set { _couleur = value; } }
        /// <summary>
        /// l'identifiant du feu
        /// </summary>
        public string Identifiant { get { return _identifiant; } set { _identifiant = value; } }
        /// <summary>
        /// si il est allumer ou etaint (default false)
        /// </summary>
        public bool Etat { get { return _etat; } set { _etat = value; } }

        public FeuDeSignalisation(string identifiant) 
        { 
            _identifiant = identifiant;
            _couleur = 0;
            _etat = false;
        }

        /// <summary>
        /// change de 1 cran la couleur [[0, 2]
        /// </summary>
        /// <returns>la couleur obtenue</returns>
        public int ChangerCouleur()
        {
            if (_couleur >= 2)
            {
                _couleur = -1;
            }
            _couleur++;
            return _couleur;
        }

        /// <summary>
        /// inverse l'etat de la lampe
        /// </summary>
        public void ChangerEtat()
        {
            _etat = !_etat;
        }
        /// <summary>
        /// fait clignoter le feu
        /// </summary>
        /// <param name="nbAlternace">nombre de foix qu'il clignote</param>
        public void Clignote(int nbAlternace)
        {
            for (int i = 0; i < nbAlternace; i++)
            {
                Console.WriteLine(AfficheInfo());
                ChangerEtat();
            }
        }

        /// <summary>
        /// permet d'obtenir la couleur
        /// </summary>
        /// <returns>la couleur en question</returns>
        public string AfficherCouleur()
        {
            string[] color = new string[3] { "rouge", "orange", "vert" };
            if(_couleur > 2 || _couleur < 0)
            {
                _couleur = 0;
            }
            return color[_couleur];
        }

        /// <summary>
        /// retourne un string avec les info du feu
        /// </summary>
        /// <returns>info du feu</returns>
        public string AfficheInfo()
        {
            string et = _etat ? "allumer" : "éteint";
            return $"Le feu de signalisation {_identifiant} est {AfficherCouleur()} et {et}.";
        }
    }
}
