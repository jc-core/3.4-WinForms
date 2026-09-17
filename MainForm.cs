using Assignment3_4.Models;

namespace Assignment3_4 {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            dataGridCoffees.AutoGenerateColumns = false;
            dataGridCoffees.DataSource = Data.Coffees;
            RefreshGrid();

        }

        private void btnAddCoffee_Click(object sender, EventArgs e) {

            Hide();

            AddCoffeeForm addCoffee = new AddCoffeeForm();
            addCoffee.ShowDialog();

            Show();
            RefreshGrid();

        }

        private void btnRemoveCoffee_Click(object sender, EventArgs e) {

            if (dataGridCoffees.CurrentRow == null) {
                MessageBox.Show("Select a coffee record first.");
                return;
            }

            Coffee coffee = Data.Coffees[dataGridCoffees.CurrentRow.Index];


            DialogResult result = MessageBox.Show(Data.RemoveOrder(coffee), "Delete Coffee", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {

                Data.Coffees.RemoveAt(dataGridCoffees.CurrentRow.Index);
                RefreshGrid();

            }

        }

        private void RefreshGrid() {

            dataGridCoffees.DataSource = null;
            dataGridCoffees.DataSource = Data.Coffees;

            foreach (DataGridViewRow row in dataGridCoffees.Rows) {
                if (Data.Coffees[row.Index].Completed) {
                    row.DefaultCellStyle.Font = new Font(dataGridCoffees.DefaultCellStyle.Font!, FontStyle.Strikeout);
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                    row.DefaultCellStyle.SelectionForeColor = Color.Gray;
                }
            }

        }

        private void btnComplete_Click(object sender, EventArgs e) {

            if (dataGridCoffees.CurrentRow == null) {
                MessageBox.Show("Select an order first.");
                return;
            }

            Coffee coffee = Data.Coffees[dataGridCoffees.CurrentRow.Index];
            if (coffee.Completed)
                return;

            coffee.Completed = true;

            Data.Coffees.Remove(coffee);
            Data.Coffees.Add(coffee);

            RefreshGrid();

        }
    }
}
