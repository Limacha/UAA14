using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.classs
{
    internal class SandwichMaker
    {
        private string[] _proteine = new string[] { "poulet", "fromage", "jambon", "viande" };
        private string[] _condiment = new string[] { "onion", "moutarde", "ketchup", "mayo" };
        private string[] _pain = new string[] { "blanc", "gris", "complet", "noir" };
        private string[] _crudite = new string[] { "salade", "tomate", "carotte", "radis" };

        public string[] Proteine { get { return _proteine; } }
        public string[] Condiment { get { return _condiment; } }
        public string[] Pain { get { return _pain; } }
        public string[] Crudite { get { return _crudite; } }

        public SandwichMaker()
        {

        }

        public string ComposeSandwich()
        {
            Random random = new Random();
            int total = random.Next(0, 50);
            string message = "vous avez :\n";
            for (int i = 0; i < total; i++)
            {
                switch (random.Next(0, 4))
                {
                    case 0:
                        message += $" - {_proteine[random.Next(0, 4)]}\n";
                        break;
                    case 1:
                        message += $" - {_crudite[random.Next(0, 4)]}\n";
                        break;
                    case 2:
                        message += $" - {_condiment[random.Next(0, 4)]}\n";
                        break;
                    case 3:
                        message += $" - {_pain[random.Next(0, 4)]}\n";
                        break;
                }
            }
            message += $"pour un total de {total}";

            return message;
        }
    }
}
