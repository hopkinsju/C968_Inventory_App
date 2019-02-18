namespace C968_Inventory_App
{
    partial class EditPart
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
            this.EditPartLabel = new C968_Inventory_App.CustomControls.PageLabel();
            this.PartLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PartIDLabel = new System.Windows.Forms.Label();
            this.PartNameLabel = new System.Windows.Forms.Label();
            this.PartInvCountLabel = new System.Windows.Forms.Label();
            this.PartPriceLable = new System.Windows.Forms.Label();
            this.PartMinCountLabel = new System.Windows.Forms.Label();
            this.PartMaxCountLabel = new System.Windows.Forms.Label();
            this.PartIDInput = new System.Windows.Forms.TextBox();
            this.PartNameInput = new System.Windows.Forms.TextBox();
            this.PartCountInput = new System.Windows.Forms.TextBox();
            this.PartPriceInput = new System.Windows.Forms.TextBox();
            this.PartMinCountInput = new System.Windows.Forms.TextBox();
            this.PartMaxCountInput = new System.Windows.Forms.TextBox();
            this.PartSourceIDInput = new System.Windows.Forms.TextBox();
            this.PartSourceLabel = new System.Windows.Forms.Label();
            this.PartSaveButton = new System.Windows.Forms.Button();
            this.PartCancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PartInHouseRadio = new System.Windows.Forms.RadioButton();
            this.PartOutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.PartLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditPartLabel
            // 
            this.EditPartLabel.AutoSize = true;
            this.EditPartLabel.BackColor = System.Drawing.Color.Transparent;
            this.EditPartLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPartLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.EditPartLabel.Location = new System.Drawing.Point(26, 26);
            this.EditPartLabel.Name = "EditPartLabel";
            this.EditPartLabel.Size = new System.Drawing.Size(157, 25);
            this.EditPartLabel.TabIndex = 0;
            this.EditPartLabel.Text = "Add/Modify Part";
            // 
            // PartLayoutPanel
            // 
            this.PartLayoutPanel.ColumnCount = 4;
            this.PartLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PartLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PartLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PartLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PartLayoutPanel.Controls.Add(this.PartMinCountLabel, 0, 4);
            this.PartLayoutPanel.Controls.Add(this.PartIDLabel, 0, 0);
            this.PartLayoutPanel.Controls.Add(this.PartNameLabel, 0, 1);
            this.PartLayoutPanel.Controls.Add(this.PartInvCountLabel, 0, 2);
            this.PartLayoutPanel.Controls.Add(this.PartPriceLable, 0, 3);
            this.PartLayoutPanel.Controls.Add(this.PartMaxCountLabel, 2, 4);
            this.PartLayoutPanel.Controls.Add(this.PartIDInput, 1, 0);
            this.PartLayoutPanel.Controls.Add(this.PartNameInput, 1, 1);
            this.PartLayoutPanel.Controls.Add(this.PartCountInput, 1, 2);
            this.PartLayoutPanel.Controls.Add(this.PartPriceInput, 1, 3);
            this.PartLayoutPanel.Controls.Add(this.PartMinCountInput, 1, 4);
            this.PartLayoutPanel.Controls.Add(this.PartMaxCountInput, 3, 4);
            this.PartLayoutPanel.Controls.Add(this.PartSourceIDInput, 1, 5);
            this.PartLayoutPanel.Controls.Add(this.PartSourceLabel, 0, 5);
            this.PartLayoutPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartLayoutPanel.Location = new System.Drawing.Point(44, 95);
            this.PartLayoutPanel.Name = "PartLayoutPanel";
            this.PartLayoutPanel.RowCount = 6;
            this.PartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PartLayoutPanel.Size = new System.Drawing.Size(372, 291);
            this.PartLayoutPanel.TabIndex = 1;
            // 
            // PartIDLabel
            // 
            this.PartIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartIDLabel.AutoSize = true;
            this.PartIDLabel.Location = new System.Drawing.Point(15, 15);
            this.PartIDLabel.Margin = new System.Windows.Forms.Padding(15);
            this.PartIDLabel.Name = "PartIDLabel";
            this.PartIDLabel.Size = new System.Drawing.Size(69, 17);
            this.PartIDLabel.TabIndex = 0;
            this.PartIDLabel.Text = "ID";
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartNameLabel.AutoSize = true;
            this.PartNameLabel.Location = new System.Drawing.Point(15, 62);
            this.PartNameLabel.Margin = new System.Windows.Forms.Padding(15);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.Size = new System.Drawing.Size(69, 17);
            this.PartNameLabel.TabIndex = 3;
            this.PartNameLabel.Text = "Name";
            // 
            // PartInvCountLabel
            // 
            this.PartInvCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartInvCountLabel.AutoSize = true;
            this.PartInvCountLabel.Location = new System.Drawing.Point(15, 109);
            this.PartInvCountLabel.Margin = new System.Windows.Forms.Padding(15);
            this.PartInvCountLabel.Name = "PartInvCountLabel";
            this.PartInvCountLabel.Size = new System.Drawing.Size(69, 17);
            this.PartInvCountLabel.TabIndex = 4;
            this.PartInvCountLabel.Text = "Inv";
            // 
            // PartPriceLable
            // 
            this.PartPriceLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartPriceLable.AutoSize = true;
            this.PartPriceLable.Location = new System.Drawing.Point(15, 156);
            this.PartPriceLable.Margin = new System.Windows.Forms.Padding(15);
            this.PartPriceLable.Name = "PartPriceLable";
            this.PartPriceLable.Size = new System.Drawing.Size(69, 17);
            this.PartPriceLable.TabIndex = 5;
            this.PartPriceLable.Text = "Price/Cost";
            // 
            // PartMinCountLabel
            // 
            this.PartMinCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartMinCountLabel.AutoSize = true;
            this.PartMinCountLabel.Location = new System.Drawing.Point(15, 203);
            this.PartMinCountLabel.Margin = new System.Windows.Forms.Padding(15);
            this.PartMinCountLabel.Name = "PartMinCountLabel";
            this.PartMinCountLabel.Size = new System.Drawing.Size(69, 17);
            this.PartMinCountLabel.TabIndex = 18;
            this.PartMinCountLabel.Text = "Min";
            // 
            // PartMaxCountLabel
            // 
            this.PartMaxCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartMaxCountLabel.AutoSize = true;
            this.PartMaxCountLabel.Location = new System.Drawing.Point(220, 203);
            this.PartMaxCountLabel.Margin = new System.Windows.Forms.Padding(15);
            this.PartMaxCountLabel.Name = "PartMaxCountLabel";
            this.PartMaxCountLabel.Size = new System.Drawing.Size(34, 17);
            this.PartMaxCountLabel.TabIndex = 20;
            this.PartMaxCountLabel.Text = "Max";
            // 
            // PartIDInput
            // 
            this.PartIDInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartIDInput.Location = new System.Drawing.Point(102, 11);
            this.PartIDInput.Name = "PartIDInput";
            this.PartIDInput.Size = new System.Drawing.Size(100, 25);
            this.PartIDInput.TabIndex = 26;
            // 
            // PartNameInput
            // 
            this.PartNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartNameInput.Location = new System.Drawing.Point(102, 58);
            this.PartNameInput.Name = "PartNameInput";
            this.PartNameInput.Size = new System.Drawing.Size(100, 25);
            this.PartNameInput.TabIndex = 27;
            // 
            // PartCountInput
            // 
            this.PartCountInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartCountInput.Location = new System.Drawing.Point(102, 105);
            this.PartCountInput.Name = "PartCountInput";
            this.PartCountInput.Size = new System.Drawing.Size(100, 25);
            this.PartCountInput.TabIndex = 28;
            // 
            // PartPriceInput
            // 
            this.PartPriceInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartPriceInput.Location = new System.Drawing.Point(102, 152);
            this.PartPriceInput.Name = "PartPriceInput";
            this.PartPriceInput.Size = new System.Drawing.Size(100, 25);
            this.PartPriceInput.TabIndex = 29;
            // 
            // PartMinCountInput
            // 
            this.PartMinCountInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartMinCountInput.Location = new System.Drawing.Point(102, 199);
            this.PartMinCountInput.Name = "PartMinCountInput";
            this.PartMinCountInput.Size = new System.Drawing.Size(100, 25);
            this.PartMinCountInput.TabIndex = 30;
            // 
            // PartMaxCountInput
            // 
            this.PartMaxCountInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartMaxCountInput.Location = new System.Drawing.Point(272, 199);
            this.PartMaxCountInput.Name = "PartMaxCountInput";
            this.PartMaxCountInput.Size = new System.Drawing.Size(97, 25);
            this.PartMaxCountInput.TabIndex = 31;
            // 
            // PartSourceIDInput
            // 
            this.PartSourceIDInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartSourceIDInput.Location = new System.Drawing.Point(102, 250);
            this.PartSourceIDInput.Name = "PartSourceIDInput";
            this.PartSourceIDInput.Size = new System.Drawing.Size(100, 25);
            this.PartSourceIDInput.TabIndex = 32;
            // 
            // PartSourceLabel
            // 
            this.PartSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartSourceLabel.AutoSize = true;
            this.PartSourceLabel.Location = new System.Drawing.Point(15, 254);
            this.PartSourceLabel.Margin = new System.Windows.Forms.Padding(15);
            this.PartSourceLabel.Name = "PartSourceLabel";
            this.PartSourceLabel.Size = new System.Drawing.Size(69, 17);
            this.PartSourceLabel.TabIndex = 33;
            this.PartSourceLabel.Text = "SourceID";
            // 
            // PartSaveButton
            // 
            this.PartSaveButton.AutoSize = true;
            this.PartSaveButton.Location = new System.Drawing.Point(261, 407);
            this.PartSaveButton.Name = "PartSaveButton";
            this.PartSaveButton.Size = new System.Drawing.Size(75, 31);
            this.PartSaveButton.TabIndex = 7;
            this.PartSaveButton.Text = "Save";
            this.PartSaveButton.UseVisualStyleBackColor = true;
            // 
            // PartCancelButton
            // 
            this.PartCancelButton.AutoSize = true;
            this.PartCancelButton.Location = new System.Drawing.Point(342, 407);
            this.PartCancelButton.Name = "PartCancelButton";
            this.PartCancelButton.Size = new System.Drawing.Size(75, 31);
            this.PartCancelButton.TabIndex = 8;
            this.PartCancelButton.Text = "Cancel";
            this.PartCancelButton.UseVisualStyleBackColor = true;
            this.PartCancelButton.Click += new System.EventHandler(this.PartCancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PartOutsourcedRadio);
            this.panel1.Controls.Add(this.PartInHouseRadio);
            this.panel1.Location = new System.Drawing.Point(201, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 25);
            this.panel1.TabIndex = 9;
            // 
            // PartInHouseRadio
            // 
            this.PartInHouseRadio.AutoSize = true;
            this.PartInHouseRadio.Checked = true;
            this.PartInHouseRadio.Location = new System.Drawing.Point(29, 3);
            this.PartInHouseRadio.Name = "PartInHouseRadio";
            this.PartInHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.PartInHouseRadio.TabIndex = 0;
            this.PartInHouseRadio.TabStop = true;
            this.PartInHouseRadio.Text = "In-House";
            this.PartInHouseRadio.UseVisualStyleBackColor = true;
            // 
            // PartOutsourcedRadio
            // 
            this.PartOutsourcedRadio.AutoSize = true;
            this.PartOutsourcedRadio.Location = new System.Drawing.Point(132, 3);
            this.PartOutsourcedRadio.Name = "PartOutsourcedRadio";
            this.PartOutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.PartOutsourcedRadio.TabIndex = 1;
            this.PartOutsourcedRadio.TabStop = true;
            this.PartOutsourcedRadio.Text = "Outsourced";
            this.PartOutsourcedRadio.UseVisualStyleBackColor = true;
            // 
            // EditPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(464, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PartSaveButton);
            this.Controls.Add(this.PartCancelButton);
            this.Controls.Add(this.PartLayoutPanel);
            this.Controls.Add(this.EditPartLabel);
            this.Name = "EditPart";
            this.Text = "EditPart";
            this.PartLayoutPanel.ResumeLayout(false);
            this.PartLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.PageLabel EditPartLabel;
        private System.Windows.Forms.TableLayoutPanel PartLayoutPanel;
        private System.Windows.Forms.Label PartMinCountLabel;
        private System.Windows.Forms.Label PartIDLabel;
        private System.Windows.Forms.Label PartNameLabel;
        private System.Windows.Forms.Label PartInvCountLabel;
        private System.Windows.Forms.Label PartPriceLable;
        private System.Windows.Forms.Label PartMaxCountLabel;
        private System.Windows.Forms.TextBox PartIDInput;
        private System.Windows.Forms.TextBox PartNameInput;
        private System.Windows.Forms.TextBox PartCountInput;
        private System.Windows.Forms.TextBox PartPriceInput;
        private System.Windows.Forms.TextBox PartMinCountInput;
        private System.Windows.Forms.TextBox PartMaxCountInput;
        private System.Windows.Forms.TextBox PartSourceIDInput;
        private System.Windows.Forms.Label PartSourceLabel;
        private System.Windows.Forms.Button PartSaveButton;
        private System.Windows.Forms.Button PartCancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton PartOutsourcedRadio;
        private System.Windows.Forms.RadioButton PartInHouseRadio;
    }
}