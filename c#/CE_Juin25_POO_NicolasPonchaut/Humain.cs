using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin25_POO_NicolasPonchaut
{
    public abstract class Humain
    {
        private int _id; //l'id de l'humain
        private string _nom; //le nom du tireur
        private string _prenom; //le prenom du tireur

        public int Id { get { return _id; } set { _id = value; } }
        public string Nom { get { return _nom; } }
        public string Prenom { get { return _prenom; } }

        protected Humain(int id, string nom, string prenom) 
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
        }

        /// <summary>
        /// a pour objectif d'afficher les infos selon la class
        /// </summary>
        /// <returns>les infos</returns>
        public abstract string AfficheInfo();
    }
}
