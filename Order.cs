using System.Collections.Generic;

namespace OrderUp {
    class Order {
        public List<MenuItem> dishes;
        public HappinessLevel happiness;
        public List<int> times;
        public List<Quality[]> quality;
        public List<Temperature[]> temperatures;

        public int calculateIncome() {
            int sum = 0;
            for(int i = 0; i < dishes.Count; i++) {
                sum += calculateIncomeForDish(i);
            }
            return sum;
        }

        private int calculateIncomeForDish(int index) {

        }

        private int calculateSpeed(int index) {
            if (times[i] <) {
                return Fast;
            } else if (times[i] >) {
                return Slow;
            } else {
                return Average;
            }
        }

    }
}