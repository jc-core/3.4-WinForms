using Assignment3_4.Models;
using System.Data.Common;

namespace Assignment3_4 {
    public partial class AddCoffeeForm : Form {

        public AddCoffeeForm() {
            InitializeComponent();
        }

        private void AddCoffeeForm_Load(object sender, EventArgs e) {

            comboBoxCoffeeType.DataSource = Enum.GetValues(typeof(CoffeeName));
            comboBoxCoffeeType.SelectedItem = CoffeeName.DripCoffee;
            comboBoxSize.DataSource = Enum.GetValues(typeof(CupSize));
            comboBoxRoast.DataSource = Enum.GetValues(typeof(RoastType));
            comboBoxSize.SelectedItem = CupSize.Medium;
            comboBoxRoast.SelectedItem = RoastType.Medium;
            comboBoxAddShots.Items.AddRange(new object[] { 1, 2, 3 });

            OrderPreview();

        }

        private void btnAddCoffeeSubmit_Click(object sender, EventArgs e) {

            if (comboBoxCoffeeType.SelectedIndex == -1) {
                MessageBox.Show("Select a Coffee Type");
                comboBoxCoffeeType.Select();
                return;
            }

            if (comboBoxSize.SelectedIndex == -1) {
                MessageBox.Show("Select a size.");
                comboBoxSize.Select();
                return;
            }

            if (comboBoxRoast.SelectedIndex == -1) {
                MessageBox.Show("Select a roast level.");
                comboBoxRoast.Select();
                return;
            }

            Coffee addOrder = new Coffee();
            addOrder.OrderID = NextOrderID();
            addOrder.CustomerName = textBoxCustomerName.Text;
            addOrder.Name = comboBoxCoffeeType.SelectedItem!.ToString();
            addOrder.Size = (CupSize)comboBoxSize.SelectedItem!;
            addOrder.Price = Data.Prices[(CoffeeName)comboBoxCoffeeType.SelectedItem];
            addOrder.Iced = checkBoxIced.Checked;
            addOrder.Roast = (RoastType)comboBoxRoast.SelectedItem!;
            addOrder.Shots = checkBoxAddShots.Checked ? (int)comboBoxAddShots.SelectedItem! : 0;
            addOrder.Decaf = checkBoxDecaf.Checked;

            Data.Coffees.Add(addOrder);
            MessageBox.Show("Order added.");

            ClearForm();
        }
        private void btnCloseAddCoffee_Click(object sender, EventArgs e) {
            
            Close();

        }
        private void checkBoxAddShots_CheckedChanged(object sender, EventArgs e) {

            comboBoxAddShots.Enabled = checkBoxAddShots.Checked;

            if (checkBoxAddShots.Checked)
                comboBoxAddShots.SelectedItem = 1;
            else
                comboBoxAddShots.SelectedItem = -1;
            OrderPreview();
        }
        private void buttonAddCoffeeReset_Click(object sender, EventArgs e) {
            ClearForm();
            OrderPreview();
        }
        private void selection_Changed(object sender, EventArgs e) {

            OrderPreview();

        }

        private void ClearForm() {

            textBoxCustomerName.Clear();
            comboBoxCoffeeType.SelectedItem = CoffeeName.DripCoffee;
            comboBoxSize.SelectedItem = CupSize.Medium;
            comboBoxRoast.SelectedItem = RoastType.Medium;
            checkBoxAddShots.Checked = false;
            checkBoxIced.Checked = false;
            checkBoxDecaf.Checked = false;
            checkBoxAddShots.Checked = false;
            comboBoxAddShots.SelectedIndex = -1;
            textBoxCustomerName.Select();
        }
        private int NextOrderID() {

            int highest = 0;

            foreach (Coffee coffee in Data.Coffees) {
                if (coffee.OrderID > highest)
                    highest = coffee.OrderID;
            }

            return highest + 1;
        }
        private void OrderPreview() {

            dataGridAddCoffee.Rows.Clear();
            dataGridAddCoffee.Rows.Add(
                NextOrderID(),
                textBoxCustomerName.Text,
                comboBoxCoffeeType.Text,
                comboBoxSize.Text,
                comboBoxRoast.Text,
                checkBoxDecaf.Checked ? "Yes" : "No",
                checkBoxIced.Checked ? "Yes" : "No",
                checkBoxAddShots.Checked ? comboBoxAddShots.Text : "0"
            );

        }


    }
}
