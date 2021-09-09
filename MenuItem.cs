using System.Collections.Generic;

namespace OrderUp {
    public class MenuItem {
        public string name {get; set;}
        public int unlockCost {get; set;}
        public int stockCost {get; set;}
        public int dishCost {get; set;}
        public Ingredient[] ingredients {get; set;}
        public List<int>[] ingredientDependencies {get; set;}

        public MenuItem(string name, int unlockCost, int stockCost, int dishCost, Ingredient[] ingredients, List<int>[] ingredientDependencies) {
            this.name = name;
            this.unlockCost = unlockCost;
            this.stockCost = stockCost;
            this.dishCost = dishCost;
            this.ingredients = ingredients;
            this.ingredientDependencies = ingredientDependencies;
        }

        public MenuItem(string name, int unlockCost, int stockCost, int dishCost, Ingredient[] ingredients) : this(name, unlockCost, stockCost, dishCost, ingredients, new List<int>[]{new List<int>(), new List<int>(), new List<int>(), new List<int>()}) {
        }

        public override string ToString() {
            string result = name + ": {";
            for (int i = 0; i < ingredients.Length; i++) {
                result += ingredients[i].ToString();
                if (ingredientDependencies[i] != null) {
                    result += " [Depends on ";
                    for (int j = 0; j < ingredientDependencies[i].Count; j++) {
                        result += ingredients[j].ToString() + ", ";
                    }
                    result = result.Substring(0, result.Length - 2) + "]";
                }
                result += ", ";

            }
            return result.Substring(0, result.Length - 2) + "}";
        }
    }
}