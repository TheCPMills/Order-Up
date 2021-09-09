namespace OrderUp {
    public class Spice {
        public string name {get; set;}
        public SpiceType spiceType {get; set;}

        public Spice(string name, SpiceType spiceType) {
            this.name = name;
            this.spiceType = spiceType;
        }

        public override string ToString() {
            return name;
        }
    }
}