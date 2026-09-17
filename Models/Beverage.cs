namespace Assignment3_4.Models {

    enum CupSize {
        Small = 1,
        Medium,
        Large
    }

    internal abstract class Beverage {

        public int OrderID { get; set; }
        public string? Name { get; set; }
        public CupSize Size { get; set; }
        public double Price { get; set; }
        public bool Iced { get; set; }
        public string IcedText => Iced ? "Yes" : "No";
        public bool Completed { get; set; }
        public string? CustomerName { get; set; }

        public abstract string Description { get; }

    }
}
