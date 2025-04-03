using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12_BarCocktail
{
    public class Bouteille
    {
        private Liquide liquide; //le liquide dedans
        private int maxQuantiter = 75; //la quantiter maximumn

        public Liquide Liquide { get { return liquide; } }
        public int MaxQuantiter { get { return maxQuantiter; } }

        /// <summary>
        /// cree une bouteille
        /// </summary>
        /// <param name="liquide">le liquide contenu</param>
        /// <param name="maxQuantiter">la quantiter max</param>
        public Bouteille(Liquide liquide, int maxQuantiter)
        {
            this.liquide = liquide;
            this.maxQuantiter = maxQuantiter;
        }

        /// <summary>
        /// converti la bouteille en string
        /// </summary>
        /// <returns>renvoit la convertion</returns>
        public override string ToString()
        {
            return $"{liquide.ToString()}/{maxQuantiter}cl";
        }
    }
}
