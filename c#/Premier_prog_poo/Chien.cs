﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_prog_poo
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

        public Chien(string name, int age, string race, double taille, double poids, string etat, bool puce)
        {
            _name = name;
            _age = age;
            _race = race;
            _taille = taille;
            _poids = poids;
            _etat = etat;
            _puce = puce;
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
            return _name + " nous quiter!";
        }
        public string InfosChien()
        {
            return "Le chien " + _name + ":\n" + 
                   " age: " + _age + "\n" +
                   " race: " + _race + "\n" +
                   " taille: " + _taille + "\n" +
                   " poids: " + _poids + "\n" +
                   " etat: " + _etat + "\n" +
                   " puce: " + _puce;
        }
    }
}