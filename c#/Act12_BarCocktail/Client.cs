using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12_BarCocktail
{
    public class Client: Personne
    {
        private Shaker? shaker; //le shaker qu'a le client en main
        private Shaker? Shaker { get { return shaker; } }

        /// <summary>
        /// cree un client
        /// </summary>
        /// <param name="id">l'id de la personne</param>
        /// <param name="age">l'age de la personne</param>
        /// <param name="creditCard">la carte de credit de la personne</param>
        public Client(string id, int age, int creditCard): base(id, age, creditCard) { }

        /// <summary>
        /// affiche le menu pour le laisser choisir
        /// </summary>
        /// <param name="menu">le menu a afficher</param>
        /// <returns>le menu en string</returns>
        public string Choisir(Menu menu)
        {
            return menu.ToString();
        }
        
        /// <summary>
        /// commande un shaker
        /// </summary>
        /// <param name="barMan">le barman a qui commander</param>
        /// <param name="recette">la recette voulut</param>
        /// <returns>si la commande a été faite</returns>
        public bool Commander(BarMan barMan, Recette recette)
        {
            if (barMan != null && recette != null)
            {
                shaker = barMan.FaireCocktail(recette);
                return shaker == null;
            }
            return false;
        }

        /// <summary>
        /// rend le shaker a un barman
        /// </summary>
        /// <param name="barMan">le barman a qui rendre</param>
        /// <returns>si le shaker est rendut</returns>
        public bool RendShaker(BarMan barMan)
        {
            if(barMan != null && shaker != null)
            {
                shaker.Shaked = false;
                shaker.Propre = false;
                return barMan.RendreShaker(shaker);
            }
            return false;
        }

        /// <summary>
        /// converti le client en string
        /// </summary>
        /// <returns>renvoit la convertion</returns>
        public override string ToString()
        {
            return $"id: {Id}\n" +
                   $"age: {Age}\n" +
                   $"creditCard: {CreditCard}\n" +
                   $"shaker: {shaker != null}";
        }
    }
}
