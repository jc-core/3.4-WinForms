using System.Collections;
namespace Assignment3_4.Models {

    enum RoastType {
        Light = 1,
        Medium,
        Dark,
        Espresso
    }

    enum CoffeeName {
        DripCoffee = 1,
        Cappuccino,
        ColdBrew,
        Latte,
        Mocha,
        Espresso
    }

    internal class Coffee : Beverage {

        public RoastType Roast { get; set; }
        public int Shots { get; set; }
        public bool Decaf { get; set; }
        public string DecafText => Decaf ? "Yes" : "No";
        public override string Description {

            get {

                string iced = Iced ? "Iced" : "";
                string decaf = Decaf ? "Decaf" : "Regular";

                return $"{Size}, {Iced}, {Roast}, {Shots}, {Decaf}";

            }

        }

    }
}
