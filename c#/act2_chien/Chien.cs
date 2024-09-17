using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2_chien
{
    internal class Chien
    {
        private string _name;
        private int _age;
        private string _race;
        private double _taille;
        private double _poids;
        private string _etat;
        private bool _puce;
        private bool _mort;
        public string Name {  get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Race { get { return _race; } set { _race = value; } }
        public double Taille { get { return _taille; } set { _taille = value; } }
        public double Poids { get { return _poids; } set { _poids = value; } }
        public string Etat { get { return _etat; } set { _etat = value; } }
        public bool Puce { get { return _puce; } set { _puce = value; } }

        public Chien(string name, int age, string race, double taille, double poids, string etat, bool puce, bool mort)
        {
            _name = name;
            _age = age;
            _race = race;
            _taille = taille;
            _poids = poids;
            _etat = etat;
            _puce = puce;
            _mort = mort;
        }
        public string Manger() 
        { 
            return _name + " Miam miam!"; 
        }
        public string Boire()
        {
            return _name + " Glou glou!";
        }
        public string Vieillir()
        {
            _age++;
            return _name + " a vieilli d'un an!\n il a donc " + _age;
        }
        public string Seblesser()
        {
            return _name + " s'est fait mal!";
        }
        public string Besoin()
        {
            return _name + " a fait un gros caca!";
        }
        public string Mourir()
        {
            _mort = true;
            return _name + " nous a quité!";
        }
        public string InfosChien()
        {
            return "Voici les info de " + _name + ":\n" + 
                   " age: " + _age + "\n" +
                   " race: " + _race + "\n" +
                   " taille: " + _taille + "\n" +
                   " poids: " + _poids + "\n" +
                   " etat: " + _etat + "\n" +
                   " puce: " + _puce;
        }
    }
}
