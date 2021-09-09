using System.Collections.Generic;

namespace OrderUp {
    public class Ingredient{
        public string name {get; set;}
        public Action action {get; set;}
        public Station station {get; set;}
        public List<Spice> spices {get; set;}

        public Ingredient(string name, Action action, Station station, List<Spice> spices) {
            this.name = name;
            this.action = action;
            this.station = station;
            this.spices = spices;
        }

        public Ingredient(string name, Action action, Station station) : this(name, action, station, null) {
        }

        public override string ToString() {
            return (spices != null) ? name + " (+ " + string.Join(",", spices) + ")" : name + "";
        }
    }
}