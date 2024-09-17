using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace act1_Lampe_v2
{
    internal class Lampe
    {

        private string _code;
        private string _color;
        private bool _allumer;
        public string Code { get { return _code; } }
        public string Color { get { return _color; } }
        public bool Allumer {  get { return _allumer; } set { _allumer = value; } }
        public Lampe(string code, string color)
        {
            _code = code;
            _color = color;
            _allumer = false;
        }

        public string ShowState()
        {
            return (_allumer) ? $"est allumer avec la couleur {_color}." : "est eteinte.";
        }
    }
}