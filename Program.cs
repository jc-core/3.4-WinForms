namespace Assignment3_4 {
    internal static class Program {

        [STAThread]
        static void Main() {

            ApplicationConfiguration.Initialize();

            Data.LoadCoffees();

            Application.Run(new MainForm());

        }
    }
}
