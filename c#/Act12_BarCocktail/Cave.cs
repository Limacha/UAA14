using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12_BarCocktail
{
    public class Cave
    {
        private Liquide[] liquides; //les liquides dans la cave
        public Liquide[] Liquides {  get { return liquides; } }

        /// <summary>
        /// cree une cave
        /// </summary>
        /// <param name="liquides">tout les liquide contenu</param>
        public Cave(Liquide[] liquides) 
        { 
            this.liquides = liquides;
        }

        /// <summary>
        /// converti la cave en string
        /// </summary>
        /// <returns>renvoit la convertion</returns>
        public override string ToString()
        {
            string cave = "cave:";
            foreach (Liquide liquide in liquides)
            {
                cave += "\n" + liquide.ToString();
            }
            return cave;
        }
    }
}
