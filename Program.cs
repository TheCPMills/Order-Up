using System;
using System.Collections.Generic;

namespace OrderUp {
    public class Program {
        public static void Main(string[] args) {
            Ingredient patty = new Ingredient("Burger Patty", Action.Grill, Station.Grill, null);
            Ingredient lettuce = new Ingredient("Lettuce", Action.Leaf, Station.Board, null);
            Ingredient tomato = new Ingredient("Tomato", Action.Slice, Station.Board, null);
            Ingredient fries = new Ingredient("French Fries", Action.Fry, Station.Fryer, null);

            List<Spice>[] spices = new List<Spice>[]{new List<Spice>() {new Spice("Onion Powder", SpiceType.Astringent)}, null, null, null};

            MenuItem burgerAndFries = new MenuItem("Hamburger and Fries", 50, 3, 5, new Ingredient[] {patty, lettuce, tomato, fries}, new List<int>[] {null, null, null, null});
            Special onionBurgerAndFries = new Special("Onion Burger and Fries", 50, 3, 5, burgerAndFries, spices);

            Console.WriteLine(burgerAndFries);
            Console.WriteLine(onionBurgerAndFries);

            // ===========================================================================================================================

            Ingredient chickenWing = new Ingredient("Chicken Wing", Action.Dredge, Station.Board, null);
            Ingredient dredgedChickenWing = new Ingredient("Dredged Chicken Wing", Action.Fry, Station.Fryer, null);
            Ingredient chickenFries = new Ingredient("French Fries", Action.Fry, Station.Fryer, null);

            List<Spice>[] chickenSpices = new List<Spice>[] {null, new List<Spice>() {new Spice("Black Pepper", SpiceType.Pungent)}, null};

            MenuItem friedChicken = new MenuItem("Fried Chicken", 50, 3, 5, new Ingredient[] {chickenWing, dredgedChickenWing, chickenFries}, new List<int>[] {null, new List<int>(){0}, null});
            Special blackPepperChicken = new Special("Black Pepper Chicken", 50, 3, 5, friedChicken, chickenSpices);

            Console.WriteLine(friedChicken);
            Console.WriteLine(blackPepperChicken);
        }
    }
}
