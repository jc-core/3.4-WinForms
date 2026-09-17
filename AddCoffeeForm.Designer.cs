namespace Assignment3_4 {
    partial class AddCoffeeForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblAddCoffeeTitle = new Label();
            lblCoffeeName = new Label();
            comboBoxSize = new ComboBox();
            comboBoxRoast = new ComboBox();
            btnAddCoffeeSubmit = new Button();
            btnCloseAddCoffee = new Button();
            comboBoxCoffeeType = new ComboBox();
            labelSize = new Label();
            labelRoastLevel = new Label();
            checkBoxDecaf = new CheckBox();
            checkBoxIced = new CheckBox();
            checkBoxAddShots = new CheckBox();
            comboBoxAddShots = new ComboBox();
            dataGridAddCoffee = new DataGridView();
            OrderNumber = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CoffeeType = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            Roast = new DataGridViewTextBoxColumn();
            Decaf = new DataGridViewTextBoxColumn();
            Ice = new DataGridViewTextBoxColumn();
            AddShots = new DataGridViewTextBoxColumn();
            buttonAddCoffeeReset = new Button();
            textBoxCustomerName = new TextBox();
            labelCustomerName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridAddCoffee).BeginInit();
            SuspendLayout();
            // 
            // lblAddCoffeeTitle
            // 
            lblAddCoffeeTitle.AutoSize = true;
            lblAddCoffeeTitle.BackColor = Color.BurlyWood;
            lblAddCoffeeTitle.Font = new Font("FOT-Matisse Pro Toaru B", 32F);
            lblAddCoffeeTitle.ForeColor = SystemColors.ControlText;
            lblAddCoffeeTitle.Location = new Point(12, 19);
            lblAddCoffeeTitle.Name = "lblAddCoffeeTitle";
            lblAddCoffeeTitle.Size = new Size(256, 51);
            lblAddCoffeeTitle.TabIndex = 0;
            lblAddCoffeeTitle.Text = "Add Order";
            // 
            // lblCoffeeName
            // 
            lblCoffeeName.AutoSize = true;
            lblCoffeeName.BackColor = Color.BurlyWood;
            lblCoffeeName.Font = new Font("Centaur", 26F, FontStyle.Bold);
            lblCoffeeName.Location = new Point(298, 170);
            lblCoffeeName.Name = "lblCoffeeName";
            lblCoffeeName.Size = new Size(190, 40);
            lblCoffeeName.TabIndex = 4;
            lblCoffeeName.Text = "Coffee Type";
            // 
            // comboBoxSize
            // 
            comboBoxSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSize.Font = new Font("Segoe UI", 21.75F);
            comboBoxSize.Location = new Point(510, 213);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(190, 48);
            comboBoxSize.TabIndex = 3;
            comboBoxSize.SelectedIndexChanged += selection_Changed;
            // 
            // comboBoxRoast
            // 
            comboBoxRoast.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoast.Font = new Font("Segoe UI", 21.75F);
            comboBoxRoast.Location = new Point(728, 213);
            comboBoxRoast.Name = "comboBoxRoast";
            comboBoxRoast.Size = new Size(190, 48);
            comboBoxRoast.TabIndex = 4;
            comboBoxRoast.SelectedIndexChanged += selection_Changed;
            // 
            // btnAddCoffeeSubmit
            // 
            btnAddCoffeeSubmit.BackColor = Color.BurlyWood;
            btnAddCoffeeSubmit.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold);
            btnAddCoffeeSubmit.ForeColor = SystemColors.ControlText;
            btnAddCoffeeSubmit.Location = new Point(337, 434);
            btnAddCoffeeSubmit.Name = "btnAddCoffeeSubmit";
            btnAddCoffeeSubmit.Size = new Size(190, 49);
            btnAddCoffeeSubmit.TabIndex = 9;
            btnAddCoffeeSubmit.Text = "Add";
            btnAddCoffeeSubmit.UseVisualStyleBackColor = false;
            btnAddCoffeeSubmit.Click += btnAddCoffeeSubmit_Click;
            // 
            // btnCloseAddCoffee
            // 
            btnCloseAddCoffee.BackColor = Color.BurlyWood;
            btnCloseAddCoffee.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold);
            btnCloseAddCoffee.ForeColor = SystemColors.ControlText;
            btnCloseAddCoffee.Location = new Point(758, 434);
            btnCloseAddCoffee.Name = "btnCloseAddCoffee";
            btnCloseAddCoffee.Size = new Size(190, 49);
            btnCloseAddCoffee.TabIndex = 11;
            btnCloseAddCoffee.Text = "Close";
            btnCloseAddCoffee.UseVisualStyleBackColor = false;
            btnCloseAddCoffee.Click += btnCloseAddCoffee_Click;
            // 
            // comboBoxCoffeeType
            // 
            comboBoxCoffeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCoffeeType.Font = new Font("Segoe UI", 21.75F);
            comboBoxCoffeeType.FormattingEnabled = true;
            comboBoxCoffeeType.Location = new Point(298, 213);
            comboBoxCoffeeType.Name = "comboBoxCoffeeType";
            comboBoxCoffeeType.Size = new Size(190, 48);
            comboBoxCoffeeType.TabIndex = 2;
            comboBoxCoffeeType.SelectedIndexChanged += selection_Changed;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.BackColor = Color.BurlyWood;
            labelSize.Font = new Font("Centaur", 26F, FontStyle.Bold);
            labelSize.Location = new Point(570, 170);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(72, 40);
            labelSize.TabIndex = 21;
            labelSize.Text = "Size";
            // 
            // labelRoastLevel
            // 
            labelRoastLevel.AutoSize = true;
            labelRoastLevel.BackColor = Color.BurlyWood;
            labelRoastLevel.Font = new Font("Centaur", 26F, FontStyle.Bold);
            labelRoastLevel.Location = new Point(740, 172);
            labelRoastLevel.Name = "labelRoastLevel";
            labelRoastLevel.Size = new Size(178, 40);
            labelRoastLevel.TabIndex = 22;
            labelRoastLevel.Text = "Roast Level";
            // 
            // checkBoxDecaf
            // 
            checkBoxDecaf.Appearance = Appearance.Button;
            checkBoxDecaf.AutoSize = true;
            checkBoxDecaf.BackColor = Color.BurlyWood;
            checkBoxDecaf.FlatAppearance.CheckedBackColor = Color.AntiqueWhite;
            checkBoxDecaf.FlatStyle = FlatStyle.Flat;
            checkBoxDecaf.Font = new Font("Centaur", 26F, FontStyle.Bold);
            checkBoxDecaf.Location = new Point(970, 172);
            checkBoxDecaf.Name = "checkBoxDecaf";
            checkBoxDecaf.Size = new Size(107, 50);
            checkBoxDecaf.TabIndex = 7;
            checkBoxDecaf.Text = "Decaf";
            checkBoxDecaf.UseVisualStyleBackColor = false;
            checkBoxDecaf.CheckedChanged += selection_Changed;
            // 
            // checkBoxIced
            // 
            checkBoxIced.Appearance = Appearance.Button;
            checkBoxIced.AutoSize = true;
            checkBoxIced.BackColor = Color.BurlyWood;
            checkBoxIced.FlatAppearance.CheckedBackColor = Color.AntiqueWhite;
            checkBoxIced.FlatStyle = FlatStyle.Flat;
            checkBoxIced.Font = new Font("Centaur", 26F, FontStyle.Bold);
            checkBoxIced.Location = new Point(970, 243);
            checkBoxIced.Name = "checkBoxIced";
            checkBoxIced.Size = new Size(67, 50);
            checkBoxIced.TabIndex = 8;
            checkBoxIced.Text = "Ice";
            checkBoxIced.UseVisualStyleBackColor = false;
            checkBoxIced.CheckStateChanged += selection_Changed;
            // 
            // checkBoxAddShots
            // 
            checkBoxAddShots.Appearance = Appearance.Button;
            checkBoxAddShots.AutoSize = true;
            checkBoxAddShots.BackColor = Color.BurlyWood;
            checkBoxAddShots.FlatAppearance.CheckedBackColor = Color.AntiqueWhite;
            checkBoxAddShots.FlatStyle = FlatStyle.Flat;
            checkBoxAddShots.Font = new Font("Centaur", 26F, FontStyle.Bold);
            checkBoxAddShots.Location = new Point(970, 47);
            checkBoxAddShots.Name = "checkBoxAddShots";
            checkBoxAddShots.Size = new Size(170, 50);
            checkBoxAddShots.TabIndex = 5;
            checkBoxAddShots.Text = "Add Shots";
            checkBoxAddShots.UseVisualStyleBackColor = false;
            checkBoxAddShots.CheckedChanged += checkBoxAddShots_CheckedChanged;
            // 
            // comboBoxAddShots
            // 
            comboBoxAddShots.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddShots.Enabled = false;
            comboBoxAddShots.Font = new Font("Segoe UI", 22F);
            comboBoxAddShots.Location = new Point(970, 103);
            comboBoxAddShots.Name = "comboBoxAddShots";
            comboBoxAddShots.Size = new Size(170, 48);
            comboBoxAddShots.TabIndex = 6;
            comboBoxAddShots.SelectedIndexChanged += selection_Changed;
            // 
            // dataGridAddCoffee
            // 
            dataGridAddCoffee.AllowUserToAddRows = false;
            dataGridAddCoffee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Noto Sans JP", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridAddCoffee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAddCoffee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAddCoffee.Columns.AddRange(new DataGridViewColumn[] { OrderNumber, CustomerName, CoffeeType, Size, Roast, Decaf, Ice, AddShots });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Noto Sans JP", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridAddCoffee.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridAddCoffee.EnableHeadersVisualStyles = false;
            dataGridAddCoffee.Location = new Point(163, 299);
            dataGridAddCoffee.Name = "dataGridAddCoffee";
            dataGridAddCoffee.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Noto Sans JP", 21.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridAddCoffee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridAddCoffee.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridAddCoffee.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridAddCoffee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAddCoffee.Size = new Size(929, 113);
            dataGridAddCoffee.StandardTab = true;
            dataGridAddCoffee.TabIndex = 12;
            // 
            // OrderNumber
            // 
            OrderNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderNumber.HeaderText = "Order #";
            OrderNumber.Name = "OrderNumber";
            OrderNumber.ReadOnly = true;
            OrderNumber.Width = 103;
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerName.HeaderText = "Customer Name";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 183;
            // 
            // CoffeeType
            // 
            CoffeeType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CoffeeType.HeaderText = "Coffee Type";
            CoffeeType.Name = "CoffeeType";
            CoffeeType.ReadOnly = true;
            CoffeeType.Width = 142;
            // 
            // Size
            // 
            Size.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Size.HeaderText = "Size";
            Size.Name = "Size";
            Size.ReadOnly = true;
            Size.Width = 73;
            // 
            // Roast
            // 
            Roast.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Roast.HeaderText = "Roast Level";
            Roast.Name = "Roast";
            Roast.ReadOnly = true;
            Roast.Width = 139;
            // 
            // Decaf
            // 
            Decaf.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Decaf.HeaderText = "Decaf";
            Decaf.Name = "Decaf";
            Decaf.ReadOnly = true;
            Decaf.Width = 88;
            // 
            // Ice
            // 
            Ice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Ice.HeaderText = "Ice";
            Ice.Name = "Ice";
            Ice.ReadOnly = true;
            Ice.Width = 64;
            // 
            // AddShots
            // 
            AddShots.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AddShots.HeaderText = "Add Shots";
            AddShots.Name = "AddShots";
            AddShots.ReadOnly = true;
            AddShots.Width = 128;
            // 
            // buttonAddCoffeeReset
            // 
            buttonAddCoffeeReset.BackColor = Color.BurlyWood;
            buttonAddCoffeeReset.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold);
            buttonAddCoffeeReset.ForeColor = SystemColors.ControlText;
            buttonAddCoffeeReset.Location = new Point(546, 434);
            buttonAddCoffeeReset.Name = "buttonAddCoffeeReset";
            buttonAddCoffeeReset.Size = new Size(190, 49);
            buttonAddCoffeeReset.TabIndex = 10;
            buttonAddCoffeeReset.Text = "Reset";
            buttonAddCoffeeReset.UseVisualStyleBackColor = false;
            buttonAddCoffeeReset.Click += buttonAddCoffeeReset_Click;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Font = new Font("Segoe UI", 22F);
            textBoxCustomerName.Location = new Point(556, 85);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(339, 47);
            textBoxCustomerName.TabIndex = 1;
            textBoxCustomerName.TextChanged += selection_Changed;
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.BackColor = Color.BurlyWood;
            labelCustomerName.Font = new Font("Centaur", 26F, FontStyle.Bold);
            labelCustomerName.Location = new Point(298, 92);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(241, 40);
            labelCustomerName.TabIndex = 30;
            labelCustomerName.Text = "Customer Name";
            // 
            // AddCoffeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            BackgroundImage = Properties.Resources.images_1_;
            ClientSize = new Size(1210, 523);
            Controls.Add(labelCustomerName);
            Controls.Add(textBoxCustomerName);
            Controls.Add(buttonAddCoffeeReset);
            Controls.Add(dataGridAddCoffee);
            Controls.Add(comboBoxAddShots);
            Controls.Add(checkBoxAddShots);
            Controls.Add(checkBoxIced);
            Controls.Add(checkBoxDecaf);
            Controls.Add(labelRoastLevel);
            Controls.Add(labelSize);
            Controls.Add(comboBoxCoffeeType);
            Controls.Add(btnCloseAddCoffee);
            Controls.Add(btnAddCoffeeSubmit);
            Controls.Add(comboBoxRoast);
            Controls.Add(comboBoxSize);
            Controls.Add(lblCoffeeName);
            Controls.Add(lblAddCoffeeTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCoffeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Order";
            Load += AddCoffeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAddCoffee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAddCoffeeTitle;
        private Label lblCoffeeName;
        private ComboBox comboBoxSize;
        private ComboBox comboBoxRoast;
        private Button btnAddCoffeeSubmit;
        private Button btnCloseAddCoffee;
        private ComboBox comboBoxCoffeeType;
        private Label labelSize;
        private Label labelRoastLevel;
        private CheckBox checkBoxDecaf;
        private CheckBox checkBoxIced;
        private CheckBox checkBoxAddShots;
        private ComboBox comboBoxAddShots;
        private DataGridView dataGridAddCoffee;
        private Button buttonAddCoffeeReset;
        private TextBox textBoxCustomerName;
        private Label labelCustomerName;
        private DataGridViewTextBoxColumn OrderNumber;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CoffeeType;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Roast;
        private DataGridViewTextBoxColumn Ice;
        private DataGridViewTextBoxColumn Decaf;
        private DataGridViewTextBoxColumn AddShots;
    }
}
