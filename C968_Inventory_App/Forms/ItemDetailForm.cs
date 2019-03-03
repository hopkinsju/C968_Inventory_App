using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Inventory_App
{
    public partial class ItemDetailForm : Form
    {
        protected Part part;
        protected Product product;
        protected bool isNew;

        public ItemDetailForm()
        {
            InitializeComponent();
        }

        public virtual void LoadForm()
        {
            this.AutoValidate = AutoValidate.Disable;
            NameInput.CausesValidation = true;
            NameInput.Validating += new System.ComponentModel.CancelEventHandler(NameInput_Validating);
            CountInput.CausesValidation = true;
            CountInput.Validating += new System.ComponentModel.CancelEventHandler(CountInput_Validating);
            PriceInput.CausesValidation = true;
            PriceInput.Validating += new System.ComponentModel.CancelEventHandler(PriceInput_Validating);
            MinCountInput.CausesValidation = true;
            MinCountInput.Validating += new System.ComponentModel.CancelEventHandler(MinCountInput_Validating);
            MaxCountInput.CausesValidation = true;
            MaxCountInput.Validating += new System.ComponentModel.CancelEventHandler(MaxCountInput_Validating);
        }

        private void PartCancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void EditPartForm_change(object sender, EventArgs e)
        {
            this.FormCancelButton.Location = new System.Drawing.Point(Width - 130, Height - 120);
            this.SaveButton.Location = new System.Drawing.Point(FormCancelButton.Left - SaveButton.Width - 20, FormCancelButton.Top);
        }
        void NameInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (NameInput.Text.Length > 0) ? false : true;
            if (e.Cancel)
            {
                NameInput.BackColor = Color.Pink;
            }
        }
        private void CountInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (int.TryParse(CountInput.Text, out int n)) ? false : true;
            if (e.Cancel)
            {
                CountInput.BackColor = Color.Pink;
            }
        }
        private void PriceInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (double.TryParse(PriceInput.Text, out double n)) ? false : true;
            if (e.Cancel)
            {
                PriceInput.BackColor = Color.Pink;
            }
        }
        private void MinCountInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (int.TryParse(MinCountInput.Text, out int n)) ? false : true;
            if (e.Cancel)
            {
                MinCountInput.BackColor = Color.Pink;
            }
        }
        private void MaxCountInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (int.TryParse(MaxCountInput.Text, out int n)) ? false : true;
            if (e.Cancel)
            {
                MaxCountInput.BackColor = Color.Pink;
            }
        }
        public void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                SaveItem();
            }
            else
            {
                MessageBox.Show(NameInput, "Please supply valid values for highlighted fields.");
            }
        }
        public virtual void SaveItem()
        {
            return;
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceLabel.Text = (OutsourcedRadio.Checked) ? "Company Name" : "Machine ID";
        }
    }
}
