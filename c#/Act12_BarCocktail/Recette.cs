using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12_BarCocktail
{
    public class Recette
    {
        private string name; //le nom de la recette
        private Dictionary<Liquide, float> proportions; //en pourcentage
        private readonly int taille = 20; //la taille

        public string Name { get { return name; } }
        public Dictionary<Liquide, float> Proportions { get { return proportions; } }
        public int Taille { get { return taille; } }
        
        /// <summary>
        /// cree une recette
        /// </summary>
        /// <param name="name">le nom de la recette</param>
        /// <param name="proportions">les proportions de la recette</param>
        public Recette(string name, Dictionary<Liquide, float> proportions) 
        { 
            this.name = name;
            this.proportions = proportions;
        }

        /// <summary>
        /// converti la recette en string
        /// </summary>
        /// <returns>renvoit la convertion</returns>
        public override string ToString()
        {
            string recette = $"{name}({taille}cl):";
            foreach (Liquide liquide in proportions.Keys)
            {
                recette += "\n" + liquide.ToString() + proportions[liquide].ToString();
            }
            return recette;
        }
    }
}
