using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.classs
{
    internal class Perssone
    {
        private string _nom;
        private double _porteMoney;

        public string Nom { get { return _nom; } set { _nom = value; } }
        public double PorteMoney { get { return _porteMoney; } set { _porteMoney = value; } }

        public Perssone(string nom, double porteMoney)
        {
            _nom = nom;
            _porteMoney = porteMoney;
        }

        public void AddMoney(double money)
        {
            PorteMoney += money;
        }

        public void AddTransaction(double money, Perssone perssone) 
        {
            PorteMoney -= money;
            perssone.AddMoney(money);
        }

        public string ShowInfo()
        {
            return $"{_nom} a {_porteMoney}";
        }
    }
}
