using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace act1_allumer_lampe
{
    internal class Lampe
    {

        private string _code;
        private string _color;
        private bool _allumer;
        public Lampe(string code, string color)
        {
            _code = code;
            _color = color;
            _allumer = false;
        }

        public string GetCode()
        {
            return _code;
        }

        public string GetColor()
        {
            return _color;
        }

        public bool GetStatu()
        {
            return _allumer;
        }

        public void SetStatu(bool etat)
        {
            _allumer = etat;
        }

        public string ShowState()
        {
            return (_allumer) ? $"est allumer avec la couleur {_color}." : "est eteinte.";
        }
    }
}