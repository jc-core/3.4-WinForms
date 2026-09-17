using Assignment3_4.Models;

namespace Assignment3_4 {
    internal class Data {

        public static List<Coffee> Coffees { get; set; } = new();

        internal static Dictionary<CoffeeName, double> Prices { get; set; } = new() {

            { CoffeeName.DripCoffee, 1.00 },
            { CoffeeName.Cappuccino, 2.50 },
            { CoffeeName.Espresso, 1.00 },
            { CoffeeName.ColdBrew, 3.00 },
            { CoffeeName.Latte, 2.00 },
            { CoffeeName.Mocha, 3.00 }

        };

        public static void LoadCoffees() {

            Coffees.Add(new Coffee() {
                OrderID = 1,
                CustomerName = "Bandito Fernandez",
                Name = CoffeeName.Latte.ToString(),
                Size = CupSize.Medium,
                Price = 2.50,
                Iced = true,
                Roast = RoastType.Medium,
                Shots = 1,
                Decaf = false
            });

            Coffees.Add(new Coffee() {
                OrderID = 2,
                CustomerName = "Frankie Sylva",
                Name = CoffeeName.ColdBrew.ToString(),
                Size = CupSize.Large,
                Price = 4.00,
                Iced = false,
                Roast = RoastType.Dark,
                Shots = 2,
                Decaf = false
            });

        }
        public static string RemoveOrder(Coffee coffee) {

            return $"Remove order # {coffee.OrderID}?";

        }

    }
}
