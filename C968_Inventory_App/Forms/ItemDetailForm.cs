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
        private Part part;
        private Product product;
        private bool isNew = false;
        private Inventory inv;

        public ItemDetailForm(Inventory inv, Part part)
        {
            InitializeComponent();
            EditPageLabel.Text = "Modify Part";
            this.part = part;
            LoadPart(inv, part);
            this.inv = inv;
        }

        public ItemDetailForm(Inventory inv, Product product)
        {
            InitializeComponent();
            EditPageLabel.Text = "Modify Product";
            this.product = product;
            LoadProduct(inv, product);
            this.inv = inv;
        }

        public ItemDetailForm(Inventory inv)
        {
            InitializeComponent();
            EditPageLabel.Text = "Add Part";
            isNew = true;
            this.inv = inv;
        }

        private void PartCancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void LoadPart(Inventory inv, Part part)
        {
            IDInput.Text = part.PartID.ToString();
            IDInput.Enabled = false;
            NameInput.Text = part.Name;
            CountInput.Text = part.InStock.ToString();
            PriceInput.Text = part.Price.ToString("C");
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
        }
        private void LoadProduct(Inventory inv, Product product)
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                inv.AddPart(part);
            }
        }
    }
}
