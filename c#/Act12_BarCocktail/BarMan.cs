using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12_BarCocktail
{
    public class BarMan: Personne
    {
        private bool enService = false; //si il travaille
        private Bar bar; //le bar au quel il est associer

        public bool EnService { get { return enService; } }
        public Bar Bar { get { return bar; } }

        /// <summary>
        /// cree un barman
        /// </summary>
        /// <param name="id">l'id de la personne</param>
        /// <param name="age">l'age de la personne</param>
        /// <param name="creditCard">la carte de credit de la personne</param>
        /// <param name="bar">le bar ou il travail de base</param>
        public BarMan(string id, int age, int creditCard, Bar bar):base(id, age, creditCard)
        {
            this.bar = bar;
        }

        /// <summary>
        /// fait arreter de traivaller le server et fait un restock des boisons
        /// </summary>
        /// <param name="cave">la cave avec la quel il fera le restock</param>
        public void StopWork(Cave cave)
        {
            enService = false;
            bar.RestockGlobal(cave);
        }

        /// <summary>
        /// fait travailler le server
        /// </summary>
        /// <param name="cave">la cave ou faire le restock</param>
        /// <param name="bar">le bar dans le quel il va travailler</param>
        public void Work(Cave cave, Bar bar)
        {
            this.bar = bar;
            enService = true;
            this.bar.RestockGlobal(cave);
        }

        /// <summary>
        /// permet au client de rendre le shaker
        /// </summary>
        /// <param name="shaker">le shaker a rendre</param>
        /// <returns>si le shaker a ete rendu</returns>
        public bool RendreShaker(Shaker shaker)
        {
            if (enService && bar != null && shaker != null)
            {
                shaker.Wash();
                bar.Shakers.Add(shaker);
                return true;
            }
            return false;
        }

        /// <summary>
        /// fait un cocktail dans un shaker si le bar a le stock de liquide et un shaker assez grand
        /// </summary>
        /// <param name="recette">la recette demander</param>
        /// <returns>si fait le shaker fait</returns>
        public Shaker? FaireCocktail(Recette recette)
        {
            if (enService)
            {
                if (bar != null)
                {
                    //prend un shaker et l'enleve de la liste du bar
                    Shaker shaker = bar.Shakers[0];
                    if (shaker != null && shaker.ContentSize >= recette.Taille)
                    {
                        if(shaker.Propre == false)
                        {
                            shaker.Wash();
                        }
                        bar.Shakers.Remove(shaker);
                        //pour chaque liquides de la recette
                        foreach (Liquide liquide in recette.Proportions.Keys)
                        {
                            //obtient toute les bouteille de se liquide
                            IEnumerable<Bouteille> bouteilles = bar.Bouteilles.Where((bouteille) => { return bouteille.Liquide.Name == liquide.Name && bouteille.Liquide.Quantiter > 0; });
                            if (bouteilles.Count() > 0)
                            {
                                //obtenir toute les bouteilles nessesaire a faire la recette
                                float quantiter = 0;
                                int nBouteille = 0;
                                while (quantiter < (recette.Proportions[liquide] / 100 * recette.Taille))
                                {
                                    if (nBouteille >= bouteilles.Count())
                                    {
                                        return null;
                                    }
                                    quantiter += bouteilles.ElementAt(nBouteille).Liquide.Quantiter;
                                    nBouteille++;
                                }
                                //enleve le liquide des bouteille
                                quantiter = recette.Proportions[liquide] / 100 * recette.Taille;
                                for (int i = 0; i < nBouteille && quantiter > 0; i++)
                                {
                                    Bouteille bouteille = bouteilles.ElementAt(i);
                                    //si plus de liquide requis
                                    if (quantiter > bouteille.Liquide.Quantiter)
                                    {
                                        //enleve la quantiter dispo et vide la bouteille
                                        quantiter -= bouteille.Liquide.Quantiter;
                                        bouteille.Liquide.Quantiter = 0;
                                    }
                                    else
                                    {
                                        //enleve la quantiter de la bouteille et vide la quantiter
                                        bouteille.Liquide.Quantiter -= quantiter;
                                        quantiter = 0;
                                    }
                                }
                                //ajout du liquide au shaker
                                shaker.Liquides.Add(new Liquide(liquide.Name, recette.Proportions[liquide] / 100 * recette.Taille));
                            }
                        }
                        shaker.Shake();
                        return shaker;
                    }
                }
            }
            return null;
        }


        /// <summary>
        /// converti le barman en string
        /// </summary>
        /// <returns>renvoit la convertion</returns>
        public override string ToString()
        {
            return $"id: {Id}\n" +
                   $"age: {Age}\n" +
                   $"creditCard: {CreditCard}\n" +
                   $"enService: {enService}\n" +
                   $"Bar: {bar.Name}";
        }
    }
}
