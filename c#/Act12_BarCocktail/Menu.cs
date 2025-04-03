using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12_BarCocktail
{
    public class Menu
    {
        private Recette[] recettes; //les recettes contenu
        public Recette[] Recettes {  get { return recettes; } }

        /// <summary>
        /// cree un menu
        /// </summary>
        /// <param name="recettes">les recettes dans le menu</param>
        public Menu(Recette[] recettes)
        {
            this.recettes = recettes;
        }

        /// <summary>
        /// converti le menu en string
        /// </summary>
        /// <returns>renvoit la convertion</returns>
        public override string ToString()
        {
            string menu = "menu:";
            foreach (Recette recette in recettes)
            {
                menu += "\n" + recette.ToString();
            }
            return menu;
        }
    }
}
