namespace C968_Inventory_App
{
    partial class EditProduct
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
            this.PartSearchInput = new System.Windows.Forms.TextBox();
            this.PartSearchButton = new System.Windows.Forms.Button();
            this.allPartsListDataGrid = new System.Windows.Forms.DataGridView();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.associatedPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.DeletePartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(896, 460);
            // 
            // PartSearchInput
            // 
            this.PartSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartSearchInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearchInput.Location = new System.Drawing.Point(914, 25);
            this.PartSearchInput.Name = "PartSearchInput";
            this.PartSearchInput.Size = new System.Drawing.Size(170, 25);
            this.PartSearchInput.TabIndex = 32;
            this.PartSearchInput.Text = "Search by Part ID";
            this.PartSearchInput.Enter += new System.EventHandler(this.PartSearchInput_Enter);
            this.PartSearchInput.Leave += new System.EventHandler(this.PartSearchInput_Leave);
            // 
            // PartSearchButton
            // 
            this.PartSearchButton.Location = new System.Drawing.Point(823, 25);
            this.PartSearchButton.Name = "PartSearchButton";
            this.PartSearchButton.Size = new System.Drawing.Size(85, 25);
            this.PartSearchButton.TabIndex = 33;
            this.PartSearchButton.Text = "Search";
            this.PartSearchButton.UseVisualStyleBackColor = true;
            this.PartSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // allPartsListDataGrid
            // 
            this.allPartsListDataGrid.AllowUserToAddRows = false;
            this.allPartsListDataGrid.AllowUserToDeleteRows = false;
            this.allPartsListDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allPartsListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsListDataGrid.Location = new System.Drawing.Point(492, 71);
            this.allPartsListDataGrid.MultiSelect = false;
            this.allPartsListDataGrid.Name = "allPartsListDataGrid";
            this.allPartsListDataGrid.ReadOnly = true;
            this.allPartsListDataGrid.RowHeadersVisible = false;
            this.allPartsListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsListDataGrid.Size = new System.Drawing.Size(592, 141);
            this.allPartsListDataGrid.TabIndex = 34;
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(1009, 218);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 23);
            this.AddPartButton.TabIndex = 35;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // associatedPartsDataGrid
            // 
            this.associatedPartsDataGrid.AllowUserToAddRows = false;
            this.associatedPartsDataGrid.AllowUserToDeleteRows = false;
            this.associatedPartsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsDataGrid.Location = new System.Drawing.Point(492, 266);
            this.associatedPartsDataGrid.MultiSelect = false;
            this.associatedPartsDataGrid.Name = "associatedPartsDataGrid";
            this.associatedPartsDataGrid.ReadOnly = true;
            this.associatedPartsDataGrid.RowHeadersVisible = false;
            this.associatedPartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsDataGrid.Size = new System.Drawing.Size(592, 141);
            this.associatedPartsDataGrid.TabIndex = 36;
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Location = new System.Drawing.Point(1009, 413);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePartButton.TabIndex = 37;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 541);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.associatedPartsDataGrid);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.allPartsListDataGrid);
            this.Controls.Add(this.PartSearchButton);
            this.Controls.Add(this.PartSearchInput);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.Controls.SetChildIndex(this.EditPageLabel, 0);
            this.Controls.SetChildIndex(this.SaveButton, 0);
            this.Controls.SetChildIndex(this.PartSearchInput, 0);
            this.Controls.SetChildIndex(this.PartSearchButton, 0);
            this.Controls.SetChildIndex(this.allPartsListDataGrid, 0);
            this.Controls.SetChildIndex(this.AddPartButton, 0);
            this.Controls.SetChildIndex(this.associatedPartsDataGrid, 0);
            this.Controls.SetChildIndex(this.DeletePartButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.allPartsListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PartSearchInput;
        private System.Windows.Forms.Button PartSearchButton;
        private System.Windows.Forms.DataGridView allPartsListDataGrid;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.DataGridView associatedPartsDataGrid;
        private System.Windows.Forms.Button DeletePartButton;
    }
}