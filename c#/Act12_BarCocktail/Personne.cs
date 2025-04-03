using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12_BarCocktail
{
    public abstract class Personne
    {
        private string id; //l'id du mec
        private int age; //l'age du mec
        private int creditCard; //sa carte de credits

        public string Id { get { return id; } }
        public int Age { get { return age; } }
        public int CreditCard { get { return creditCard; } }

        /// <summary>
        /// cree une personne
        /// </summary>
        /// <param name="id">l'id de la personne</param>
        /// <param name="age">l'age de la personne</param>
        /// <param name="creditCard">la carte de credit de la personne</param>
        public Personne(string id, int age, int creditCard)
        {
            this.id = id;
            this.age = age;
            this.creditCard = creditCard;
        }

        /// <summary>
        /// converti la personne en string
        /// </summary>
        /// <returns>renvoit la convertion</returns>
        public override string ToString()
        {
            return $"id: {id}\n" +
                   $"age: {age}\n" +
                   $"creditCard: {creditCard}";
        }
    }
}
