using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin25_POO_NicolasPonchaut
{
    public class Match
    {
        private int _id; //l'id du match
        private Tireur _tireur1; //le tireur 1
        private Tireur _tireur2; //le tireur 2
        private Arbitre _arbitre; //l'arbitre
        private int _touchesTireur1; //les touches affectuee par le tireur 1
        private int _touchesTireur2; //les touches effectuee par le tireur 2
        private string _statut; //le statut de match

        public Tireur Tireur1 { get { return _tireur1; } }
        public Tireur Tireur2 { get { return _tireur2; } }
        public int TouchesTireur1 { get { return _touchesTireur1; } }
        public int TouchesTireur2 { get { return _touchesTireur2; } }
        public string Statut { get { return _statut; } }

        public Match (int id, Tireur tireur1, Tireur tireur2, Arbitre arbitre, int touchesTireur1, int touchesTireur2, string statut)
        {
            _id = id;
            _tireur1 = tireur1;
            _tireur2 = tireur2;
            _arbitre = arbitre;
            _touchesTireur1 = touchesTireur1;
            _touchesTireur2 = touchesTireur2;
            _statut = statut;
        }

        /// <summary>
        /// affiche les infos du match
        /// </summary>
        /// <returns>les infos</returns>
        public string AfficheInfos()
        {
            return $"Match {_id} Statut : {_statut}\n" +
                   $"----------------------------\n" +
                   $"Tireur 1 : {_tireur1.AfficheInfo()} ---> Nombre de touches : {_touchesTireur1}\n" +
                   $"Tireur 2 : {_tireur2.AfficheInfo()} ---> Nombre de touches : {_touchesTireur2}\n\n";
        }
    }
}
