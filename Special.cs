using System.Collections.Generic;

namespace OrderUp {
    public class Special : MenuItem {
        public MenuItem baseDish {get; set;}
        public Special(string name, int unlockCost, int stockCost, int dishCost, MenuItem baseDish, List<Spice>[] spices) : base(name, unlockCost, stockCost, dishCost, new Ingredient[baseDish.ingredients.Length], baseDish.ingredientDependencies) {
            for (int i = 0; i < ingredients.Length; i++) {
                ingredients[i] = new Ingredient(baseDish.ingredients[i].name, baseDish.ingredients[i].action, baseDish.ingredients[i].station, spices[i]);
            }
        }
    }
}