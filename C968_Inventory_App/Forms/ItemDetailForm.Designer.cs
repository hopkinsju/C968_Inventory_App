namespace C968_Inventory_App
{
    partial class ItemDetailForm
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
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MinCountLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InvCountLabel = new System.Windows.Forms.Label();
            this.PriceLable = new System.Windows.Forms.Label();
            this.MaxCountLabel = new System.Windows.Forms.Label();
            this.IDInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.CountInput = new System.Windows.Forms.TextBox();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.MinCountInput = new System.Windows.Forms.TextBox();
            this.MaxCountInput = new System.Windows.Forms.TextBox();
            this.SourceIDInput = new System.Windows.Forms.TextBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FormCancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.EditPageLabel = new C968_Inventory_App.CustomControls.PageLabel();
            this.LayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.ColumnCount = 4;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutPanel.Controls.Add(this.MinCountLabel, 0, 4);
            this.LayoutPanel.Controls.Add(this.IDLabel, 0, 0);
            this.LayoutPanel.Controls.Add(this.NameLabel, 0, 1);
            this.LayoutPanel.Controls.Add(this.InvCountLabel, 0, 2);
            this.LayoutPanel.Controls.Add(this.PriceLable, 0, 3);
            this.LayoutPanel.Controls.Add(this.MaxCountLabel, 2, 4);
            this.LayoutPanel.Controls.Add(this.IDInput, 1, 0);
            this.LayoutPanel.Controls.Add(this.NameInput, 1, 1);
            this.LayoutPanel.Controls.Add(this.CountInput, 1, 2);
            this.LayoutPanel.Controls.Add(this.PriceInput, 1, 3);
            this.LayoutPanel.Controls.Add(this.MinCountInput, 1, 4);
            this.LayoutPanel.Controls.Add(this.MaxCountInput, 3, 4);
            this.LayoutPanel.Controls.Add(this.SourceIDInput, 1, 5);
            this.LayoutPanel.Controls.Add(this.SourceLabel, 0, 5);
            this.LayoutPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutPanel.Location = new System.Drawing.Point(44, 95);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 6;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.Size = new System.Drawing.Size(372, 291);
            this.LayoutPanel.TabIndex = 1;
            // 
            // MinCountLabel
            // 
            this.MinCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MinCountLabel.AutoSize = true;
            this.MinCountLabel.Location = new System.Drawing.Point(15, 203);
            this.MinCountLabel.Margin = new System.Windows.Forms.Padding(15);
            this.MinCountLabel.Name = "MinCountLabel";
            this.MinCountLabel.Size = new System.Drawing.Size(69, 17);
            this.MinCountLabel.TabIndex = 18;
            this.MinCountLabel.Text = "Min";
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(15, 15);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(15);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(69, 17);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(15, 62);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 17);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // InvCountLabel
            // 
            this.InvCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InvCountLabel.AutoSize = true;
            this.InvCountLabel.Location = new System.Drawing.Point(15, 109);
            this.InvCountLabel.Margin = new System.Windows.Forms.Padding(15);
            this.InvCountLabel.Name = "InvCountLabel";
            this.InvCountLabel.Size = new System.Drawing.Size(69, 17);
            this.InvCountLabel.TabIndex = 4;
            this.InvCountLabel.Text = "Inv";
            // 
            // PriceLable
            // 
            this.PriceLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceLable.AutoSize = true;
            this.PriceLable.Location = new System.Drawing.Point(15, 156);
            this.PriceLable.Margin = new System.Windows.Forms.Padding(15);
            this.PriceLable.Name = "PriceLable";
            this.PriceLable.Size = new System.Drawing.Size(69, 17);
            this.PriceLable.TabIndex = 5;
            this.PriceLable.Text = "Price/Cost";
            // 
            // MaxCountLabel
            // 
            this.MaxCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxCountLabel.AutoSize = true;
            this.MaxCountLabel.Location = new System.Drawing.Point(220, 203);
            this.MaxCountLabel.Margin = new System.Windows.Forms.Padding(15);
            this.MaxCountLabel.Name = "MaxCountLabel";
            this.MaxCountLabel.Size = new System.Drawing.Size(34, 17);
            this.MaxCountLabel.TabIndex = 20;
            this.MaxCountLabel.Text = "Max";
            // 
            // IDInput
            // 
            this.IDInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IDInput.Location = new System.Drawing.Point(102, 11);
            this.IDInput.Name = "IDInput";
            this.IDInput.Size = new System.Drawing.Size(100, 25);
            this.IDInput.TabIndex = 26;
            // 
            // NameInput
            // 
            this.NameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameInput.Location = new System.Drawing.Point(102, 58);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 25);
            this.NameInput.TabIndex = 27;
            // 
            // CountInput
            // 
            this.CountInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CountInput.Location = new System.Drawing.Point(102, 105);
            this.CountInput.Name = "CountInput";
            this.CountInput.Size = new System.Drawing.Size(100, 25);
            this.CountInput.TabIndex = 28;
            // 
            // PriceInput
            // 
            this.PriceInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceInput.Location = new System.Drawing.Point(102, 152);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(100, 25);
            this.PriceInput.TabIndex = 29;
            // 
            // MinCountInput
            // 
            this.MinCountInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MinCountInput.Location = new System.Drawing.Point(102, 199);
            this.MinCountInput.Name = "MinCountInput";
            this.MinCountInput.Size = new System.Drawing.Size(100, 25);
            this.MinCountInput.TabIndex = 30;
            // 
            // MaxCountInput
            // 
            this.MaxCountInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxCountInput.Location = new System.Drawing.Point(272, 199);
            this.MaxCountInput.Name = "MaxCountInput";
            this.MaxCountInput.Size = new System.Drawing.Size(97, 25);
            this.MaxCountInput.TabIndex = 31;
            // 
            // SourceIDInput
            // 
            this.SourceIDInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceIDInput.Location = new System.Drawing.Point(102, 250);
            this.SourceIDInput.Name = "SourceIDInput";
            this.SourceIDInput.Size = new System.Drawing.Size(100, 25);
            this.SourceIDInput.TabIndex = 32;
            // 
            // SourceLabel
            // 
            this.SourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(15, 254);
            this.SourceLabel.Margin = new System.Windows.Forms.Padding(15);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(69, 17);
            this.SourceLabel.TabIndex = 33;
            this.SourceLabel.Text = "SourceID";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.AutoSize = true;
            this.SaveButton.Location = new System.Drawing.Point(266, 415);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 31);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormCancelButton.AutoSize = true;
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.Location = new System.Drawing.Point(346, 415);
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.Size = new System.Drawing.Size(75, 31);
            this.FormCancelButton.TabIndex = 8;
            this.FormCancelButton.Text = "Cancel";
            this.FormCancelButton.UseVisualStyleBackColor = true;
            this.FormCancelButton.Click += new System.EventHandler(this.PartCancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OutsourcedRadio);
            this.panel1.Controls.Add(this.InHouseRadio);
            this.panel1.Location = new System.Drawing.Point(201, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 25);
            this.panel1.TabIndex = 9;
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(132, 3);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadio.TabIndex = 1;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadio_CheckedChanged);
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Checked = true;
            this.InHouseRadio.Location = new System.Drawing.Point(29, 3);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadio.TabIndex = 0;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            // 
            // EditPageLabel
            // 
            this.EditPageLabel.AutoSize = true;
            this.EditPageLabel.BackColor = System.Drawing.Color.Transparent;
            this.EditPageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPageLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.EditPageLabel.Location = new System.Drawing.Point(26, 26);
            this.EditPageLabel.Name = "EditPageLabel";
            this.EditPageLabel.Size = new System.Drawing.Size(157, 25);
            this.EditPageLabel.TabIndex = 0;
            this.EditPageLabel.Text = "Add/Modify Part";
            // 
            // ItemDetailForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(469, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FormCancelButton);
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.EditPageLabel);
            this.Name = "ItemDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ItemDetail";
            this.Load += new System.EventHandler(this.EditPartForm_change);
            this.Resize += new System.EventHandler(this.EditPartForm_change);
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected CustomControls.PageLabel EditPageLabel;
        protected System.Windows.Forms.TableLayoutPanel LayoutPanel;
        protected System.Windows.Forms.Label MinCountLabel;
        protected System.Windows.Forms.Label IDLabel;
        protected System.Windows.Forms.Label NameLabel;
        protected System.Windows.Forms.Label InvCountLabel;
        protected System.Windows.Forms.Label PriceLable;
        protected System.Windows.Forms.Label MaxCountLabel;
        protected System.Windows.Forms.TextBox IDInput;
        protected System.Windows.Forms.TextBox NameInput;
        protected System.Windows.Forms.TextBox CountInput;
        protected System.Windows.Forms.TextBox PriceInput;
        protected System.Windows.Forms.TextBox MinCountInput;
        protected System.Windows.Forms.TextBox MaxCountInput;
        protected System.Windows.Forms.TextBox SourceIDInput;
        protected System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Button FormCancelButton;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.RadioButton OutsourcedRadio;
        protected System.Windows.Forms.RadioButton InHouseRadio;
        protected internal System.Windows.Forms.Button SaveButton;
    }
}