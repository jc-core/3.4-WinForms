namespace Assignment3_4 {
    partial class MainForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnAddOrder = new Button();
            btnComplete = new Button();
            btnRemove = new Button();
            dataGridCoffees = new DataGridView();
            OrderNumber = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Roast = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridCoffees).BeginInit();
            SuspendLayout();
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.BurlyWood;
            btnAddOrder.Font = new Font("Cascadia Code SemiBold", 15F);
            btnAddOrder.ForeColor = SystemColors.ControlText;
            btnAddOrder.Location = new Point(79, 331);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(200, 82);
            btnAddOrder.TabIndex = 2;
            btnAddOrder.Text = "New Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddCoffee_Click;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.BurlyWood;
            btnComplete.Font = new Font("Cascadia Code SemiBold", 15F);
            btnComplete.ForeColor = SystemColors.ControlText;
            btnComplete.Location = new Point(433, 336);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(200, 82);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Complete Order";
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.BurlyWood;
            btnRemove.Font = new Font("Cascadia Mono SemiBold", 15F);
            btnRemove.ForeColor = SystemColors.ControlText;
            btnRemove.Location = new Point(789, 331);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(200, 82);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove Order";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemoveCoffee_Click;
            // 
            // dataGridCoffees
            // 
            dataGridCoffees.AllowUserToAddRows = false;
            dataGridCoffees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Noto Sans JP", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridCoffees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCoffees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCoffees.Columns.AddRange(new DataGridViewColumn[] { OrderNumber, CustomerName, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Roast, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Price });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Noto Sans JP", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridCoffees.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridCoffees.EnableHeadersVisualStyles = false;
            dataGridCoffees.Location = new Point(22, 33);
            dataGridCoffees.Name = "dataGridCoffees";
            dataGridCoffees.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Noto Sans JP", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridCoffees.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridCoffees.RowHeadersVisible = false;
            dataGridCoffees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCoffees.Size = new Size(1023, 265);
            dataGridCoffees.StandardTab = true;
            dataGridCoffees.TabIndex = 1;
            // 
            // OrderNumber
            // 
            OrderNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderNumber.DataPropertyName = "OrderID";
            dataGridViewCellStyle2.Font = new Font("Noto Sans JP", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            OrderNumber.DefaultCellStyle = dataGridViewCellStyle2;
            OrderNumber.HeaderText = "Order #";
            OrderNumber.Name = "OrderNumber";
            OrderNumber.ReadOnly = true;
            OrderNumber.Width = 103;
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Noto Sans JP", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            CustomerName.DefaultCellStyle = dataGridViewCellStyle3;
            CustomerName.HeaderText = "Customer Name";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 183;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Coffee Type";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 142;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.DataPropertyName = "Size";
            dataGridViewTextBoxColumn2.HeaderText = "Size";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 73;
            // 
            // Roast
            // 
            Roast.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Roast.DataPropertyName = "Roast";
            Roast.HeaderText = "Roast Level";
            Roast.Name = "Roast";
            Roast.ReadOnly = true;
            Roast.Width = 139;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.DataPropertyName = "IcedText";
            dataGridViewTextBoxColumn3.HeaderText = "Ice";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 64;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.DataPropertyName = "DecafText";
            dataGridViewTextBoxColumn4.HeaderText = "Decaf";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 88;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.DataPropertyName = "Shots";
            dataGridViewTextBoxColumn5.HeaderText = "Add Shots";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 128;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            Price.DefaultCellStyle = dataGridViewCellStyle4;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.Roasted_coffee_beans_1_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1066, 487);
            Controls.Add(dataGridCoffees);
            Controls.Add(btnRemove);
            Controls.Add(btnComplete);
            Controls.Add(btnAddOrder);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coffee Time Order Station";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCoffees).EndInit();
            ResumeLayout(false);
        }

        private Button btnAddOrder;
        private Button btnComplete;
        private Button btnRemove;
        private DataGridView dataGridCoffees;
        private DataGridViewTextBoxColumn OrderNumber;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Roast;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Price;
    }
}
