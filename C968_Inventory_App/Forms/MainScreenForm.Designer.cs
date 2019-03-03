namespace C968_Inventory_App
{
    partial class MainScreenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.PartsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.PartsDataGrid = new System.Windows.Forms.DataGridView();
            this.PartSearchInput = new System.Windows.Forms.TextBox();
            this.PartsSearchButton = new System.Windows.Forms.Button();
            this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductSearchInput = new System.Windows.Forms.TextBox();
            this.ProductSearchButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageLabel1 = new C968_Inventory_App.CustomControls.PageLabel();
            this.PartsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).BeginInit();
            this.ProductsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1045, 567);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 28);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PartsGroupBox
            // 
            this.PartsGroupBox.Controls.Add(this.AddPartButton);
            this.PartsGroupBox.Controls.Add(this.ModifyPartButton);
            this.PartsGroupBox.Controls.Add(this.DeletePartButton);
            this.PartsGroupBox.Controls.Add(this.PartsDataGrid);
            this.PartsGroupBox.Controls.Add(this.PartSearchInput);
            this.PartsGroupBox.Controls.Add(this.PartsSearchButton);
            this.PartsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsGroupBox.Location = new System.Drawing.Point(31, 75);
            this.PartsGroupBox.Name = "PartsGroupBox";
            this.PartsGroupBox.Size = new System.Drawing.Size(571, 441);
            this.PartsGroupBox.TabIndex = 4;
            this.PartsGroupBox.TabStop = false;
            this.PartsGroupBox.Text = "Parts";
            // 
            // AddPartButton
            // 
            this.AddPartButton.AutoSize = true;
            this.AddPartButton.Location = new System.Drawing.Point(315, 391);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 31);
            this.AddPartButton.TabIndex = 5;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.AutoSize = true;
            this.ModifyPartButton.Location = new System.Drawing.Point(396, 391);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(75, 31);
            this.ModifyPartButton.TabIndex = 6;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.AutoSize = true;
            this.DeletePartButton.Location = new System.Drawing.Point(477, 391);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(80, 31);
            this.DeletePartButton.TabIndex = 7;
            this.DeletePartButton.Text = "Remove";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // PartsDataGrid
            // 
            this.PartsDataGrid.AllowUserToAddRows = false;
            this.PartsDataGrid.AllowUserToDeleteRows = false;
            this.PartsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGrid.Location = new System.Drawing.Point(18, 106);
            this.PartsDataGrid.MultiSelect = false;
            this.PartsDataGrid.Name = "PartsDataGrid";
            this.PartsDataGrid.ReadOnly = true;
            this.PartsDataGrid.RowHeadersVisible = false;
            this.PartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDataGrid.ShowEditingIcon = false;
            this.PartsDataGrid.Size = new System.Drawing.Size(534, 262);
            this.PartsDataGrid.TabIndex = 2;
            // 
            // PartSearchInput
            // 
            this.PartSearchInput.Location = new System.Drawing.Point(388, 29);
            this.PartSearchInput.Name = "PartSearchInput";
            this.PartSearchInput.Size = new System.Drawing.Size(177, 29);
            this.PartSearchInput.TabIndex = 1;
            this.PartSearchInput.Text = "Search by Part ID";
            this.PartSearchInput.Enter += new System.EventHandler(this.PartSearchInput_Enter);
            this.PartSearchInput.Leave += new System.EventHandler(this.PartSearchInput_Leave);
            // 
            // PartsSearchButton
            // 
            this.PartsSearchButton.AutoSize = true;
            this.PartsSearchButton.Location = new System.Drawing.Point(305, 28);
            this.PartsSearchButton.Name = "PartsSearchButton";
            this.PartsSearchButton.Size = new System.Drawing.Size(76, 31);
            this.PartsSearchButton.TabIndex = 0;
            this.PartsSearchButton.Text = "Search";
            this.PartsSearchButton.UseVisualStyleBackColor = true;
            this.PartsSearchButton.Click += new System.EventHandler(this.PartsSearchButton_Click);
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.Controls.Add(this.AddProductButton);
            this.ProductsGroupBox.Controls.Add(this.ModifyProductButton);
            this.ProductsGroupBox.Controls.Add(this.DeleteProductButton);
            this.ProductsGroupBox.Controls.Add(this.ProductsDataGrid);
            this.ProductsGroupBox.Controls.Add(this.ProductSearchInput);
            this.ProductsGroupBox.Controls.Add(this.ProductSearchButton);
            this.ProductsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGroupBox.Location = new System.Drawing.Point(608, 75);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Size = new System.Drawing.Size(571, 441);
            this.ProductsGroupBox.TabIndex = 8;
            this.ProductsGroupBox.TabStop = false;
            this.ProductsGroupBox.Text = "Products";
            // 
            // AddProductButton
            // 
            this.AddProductButton.AutoSize = true;
            this.AddProductButton.Location = new System.Drawing.Point(315, 391);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 31);
            this.AddProductButton.TabIndex = 5;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.AutoSize = true;
            this.ModifyProductButton.Location = new System.Drawing.Point(396, 391);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(75, 31);
            this.ModifyProductButton.TabIndex = 6;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.AutoSize = true;
            this.DeleteProductButton.Location = new System.Drawing.Point(477, 391);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(80, 31);
            this.DeleteProductButton.TabIndex = 7;
            this.DeleteProductButton.Text = "Remove";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.AllowUserToAddRows = false;
            this.ProductsDataGrid.AllowUserToDeleteRows = false;
            this.ProductsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGrid.Location = new System.Drawing.Point(18, 106);
            this.ProductsDataGrid.MultiSelect = false;
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGrid.ShowEditingIcon = false;
            this.ProductsDataGrid.Size = new System.Drawing.Size(534, 262);
            this.ProductsDataGrid.TabIndex = 2;
            // 
            // ProductSearchInput
            // 
            this.ProductSearchInput.Location = new System.Drawing.Point(388, 29);
            this.ProductSearchInput.Name = "ProductSearchInput";
            this.ProductSearchInput.Size = new System.Drawing.Size(177, 29);
            this.ProductSearchInput.TabIndex = 1;
            this.ProductSearchInput.Text = "Search by Product ID";
            this.ProductSearchInput.Enter += new System.EventHandler(this.ProductSearchInput_Enter);
            this.ProductSearchInput.Leave += new System.EventHandler(this.ProductSearchInput_Leave);
            // 
            // ProductSearchButton
            // 
            this.ProductSearchButton.AutoSize = true;
            this.ProductSearchButton.Location = new System.Drawing.Point(305, 28);
            this.ProductSearchButton.Name = "ProductSearchButton";
            this.ProductSearchButton.Size = new System.Drawing.Size(76, 31);
            this.ProductSearchButton.TabIndex = 0;
            this.ProductSearchButton.Text = "Search";
            this.ProductSearchButton.UseVisualStyleBackColor = true;
            this.ProductSearchButton.Click += new System.EventHandler(this.ProductSearchButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 82;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.Width = 81;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 82;
            // 
            // pageLabel1
            // 
            this.pageLabel1.AutoSize = true;
            this.pageLabel1.BackColor = System.Drawing.Color.Transparent;
            this.pageLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLabel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pageLabel1.Location = new System.Drawing.Point(26, 26);
            this.pageLabel1.Name = "pageLabel1";
            this.pageLabel1.Size = new System.Drawing.Size(283, 25);
            this.pageLabel1.TabIndex = 0;
            this.pageLabel1.Text = "Inventory Management System";
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1206, 640);
            this.ControlBox = false;
            this.Controls.Add(this.ProductsGroupBox);
            this.Controls.Add(this.PartsGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pageLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainScreenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MainScreen";
            this.Activated += new System.EventHandler(this.MainScreenForm_Activated);
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            this.PartsGroupBox.ResumeLayout(false);
            this.PartsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).EndInit();
            this.ProductsGroupBox.ResumeLayout(false);
            this.ProductsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.PageLabel pageLabel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox PartsGroupBox;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.DataGridView PartsDataGrid;
        private System.Windows.Forms.TextBox PartSearchInput;
        private System.Windows.Forms.Button PartsSearchButton;
        private System.Windows.Forms.GroupBox ProductsGroupBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.DataGridView ProductsDataGrid;
        private System.Windows.Forms.TextBox ProductSearchInput;
        private System.Windows.Forms.Button ProductSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}