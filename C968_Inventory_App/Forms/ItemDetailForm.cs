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
        protected bool isNew = false;
        protected static Inventory inv;
        

        public ItemDetailForm(Part part)
        {
            InitializeComponent();
            EditPageLabel.Text = "Modify Part";
            this.part = part;
            LoadPart(part);
        }

        public ItemDetailForm(Product product)
        {
            InitializeComponent();
            EditPageLabel.Text = "Modify Product";
            this.product = product;
            LoadProduct(product);
        }

        public ItemDetailForm()
        {
            InitializeComponent();
            EditPageLabel.Text = "Add Part";
            IDInput.Text = Convert.ToString(Inventory.nextPartID);
            IDInput.Enabled = false;
            isNew = true;
            SourceLabel.Text = "Machine ID";
        }

        void LoadForm()
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
            SourceIDInput.CausesValidation = true;
            SourceIDInput.Validating += new System.ComponentModel.CancelEventHandler(SourceIDInput_Validating);

        }

        private void PartCancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void LoadPart(Part part)
        {
            IDInput.Text = part.PartID.ToString();
            IDInput.Enabled = false;
            NameInput.Text = part.Name;
            CountInput.Text = part.InStock.ToString();
            PriceInput.Text = part.Price.ToString();
            MinCountInput.Text = part.Min.ToString();
            MaxCountInput.Text = part.Max.ToString();
            if (part is Inhouse)
            {
                InHouseRadio.Select();
                SourceLabel.Text = "Machine ID";
                SourceIDInput.Text = part.MachineID.ToString();
            }
            else
            {
                OutsourcedRadio.Select();
                SourceLabel.Text = "Company Name";
                SourceIDInput.Text = part.CompanyName.ToString();
            }
            LoadForm();
        }
        private void LoadProduct(Product product)
        {
            IDInput.Text = product.ProductID.ToString();
            IDInput.Enabled = false;
            NameInput.Text = product.Name;
            CountInput.Text = product.InStock.ToString();
            PriceInput.Text = product.Price.ToString("C");
            MinCountInput.Text = product.Min.ToString();
            MaxCountInput.Text = product.Max.ToString();
        }
        private void LoadPart(Outsourced part)
        {

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
        private void SourceIDInput_Validating(object sender, CancelEventArgs e)
        {
            if (InHouseRadio.Checked)
            {
                e.Cancel = (int.TryParse(SourceIDInput.Text, out int n)) ? false : true;
            } else
            {
                e.Cancel = (SourceIDInput.Text.Length > 0) ? false : true;
            }
            if (e.Cancel)
            {
                SourceIDInput.BackColor = Color.Pink;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                SavePart();
            }
            else
            {
                MessageBox.Show(NameInput, "Please supply valid values for highlighted fields.");
            }
        }
        private void SavePart()
        {
            if (isNew)
            {
                MessageBox.Show("isNew true");
                if (InHouseRadio.Checked)
                {
                    Inventory.AddPart(new Inhouse(
                         Convert.ToInt32(IDInput.Text),
                         NameInput.Text,
                         Convert.ToDouble(PriceInput.Text),
                         Convert.ToInt32(CountInput.Text),
                         Convert.ToInt32(MinCountInput.Text),
                         Convert.ToInt32(MaxCountInput.Text),
                         Convert.ToInt32(SourceIDInput.Text)
                         ));
                } else
                {
                    Inventory.AddPart(new Outsourced(
                        Convert.ToInt32(IDInput.Text),
                        NameInput.Text,
                        Convert.ToDouble(PriceInput.Text),
                        Convert.ToInt32(CountInput.Text),
                        Convert.ToInt32(MinCountInput.Text),
                        Convert.ToInt32(MaxCountInput.Text),
                        SourceIDInput.Text
                        ));
                }
            }
            else
            {
                Part updatedPart;
                if (InHouseRadio.Checked)
                {
                    updatedPart = new Inhouse(
                         Convert.ToInt32(IDInput.Text),
                         NameInput.Text,
                         Convert.ToDouble(PriceInput.Text),
                         Convert.ToInt32(CountInput.Text),
                         Convert.ToInt32(MinCountInput.Text),
                         Convert.ToInt32(MaxCountInput.Text),
                         Convert.ToInt32(SourceIDInput.Text)
                         );
                } else
                {
                    updatedPart = new Outsourced(
                         Convert.ToInt32(IDInput.Text),
                         NameInput.Text,
                         Convert.ToDouble(PriceInput.Text),
                         Convert.ToInt32(CountInput.Text),
                         Convert.ToInt32(MinCountInput.Text),
                         Convert.ToInt32(MaxCountInput.Text),
                         SourceIDInput.Text
                         );
                }
                
                Inventory.UpdatePart(Convert.ToInt32(IDInput.Text), updatedPart);
            }
            this.Hide();
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceLabel.Text = (OutsourcedRadio.Checked) ? "Company Name" : "Machine ID";
        }
    }
}
