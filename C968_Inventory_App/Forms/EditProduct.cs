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
    public partial class EditProduct : ItemDetailForm
    {
        public BindingSource partsBindingSource = new BindingSource();
        public BindingList<Part> partsBindingList = new BindingList<Part>(Inventory.AllParts);
        public BindingSource associatedPartsBindingSource = new BindingSource();
        public BindingList<Part> associatedPartsBindingList = new BindingList<Part>();
        //public Product product;

        public EditProduct(Product product)
        {
            InitializeComponent();
            isNew = false;
            IDInput.Enabled = false;
            EditPageLabel.Text = "Modify Product";
            LoadProduct(product);
            this.product = product;
            LoadForm();
        }

        public EditProduct()
        {
            InitializeComponent();
            IDInput.Text = Convert.ToString(Inventory.nextProductID);
            IDInput.Enabled = false;
            isNew = true;
            EditPageLabel.Text = "New Product";
            LoadForm();
        }

        public override void LoadForm()
        {
            base.LoadForm();
            SourceIDInput.Hide();
            SourceLabel.Hide();
            InHouseRadio.Hide();
            OutsourcedRadio.Hide();
            allPartsListDataGrid.DataSource = partsBindingList;
            allPartsListDataGrid.Columns["Price"].DefaultCellStyle.Format = "c";
            allPartsListDataGrid.Columns["Price"].HeaderText = "Price/Cost Per Unit";
            allPartsListDataGrid.Columns["PartID"].HeaderText = "Part ID";
            allPartsListDataGrid.Columns["CompanyName"].Visible = false;
            allPartsListDataGrid.Columns["MachineID"].Visible = false;
            allPartsListDataGrid.Columns["Min"].Visible = false;
            allPartsListDataGrid.Columns["Max"].Visible = false;

            associatedPartsDataGrid.DataSource = associatedPartsBindingList;
        }

        private void LoadProduct(Product product)
        {
            IDInput.Text = product.ProductID.ToString();
            IDInput.Enabled = false;
            NameInput.Text = product.Name;
            CountInput.Text = product.InStock.ToString();
            PriceInput.Text = product.Price.ToString();
            MinCountInput.Text = product.Min.ToString();
            MaxCountInput.Text = product.Max.ToString();
            foreach (Part part in product.associatedParts)
            {
                associatedPartsBindingList.Add(part);
            }
            //associatedPartsDataGrid.DataSource = associatedPartsBindingList;
        }


        public override void SaveItem()
        {
            if (isNew)
            {
                    Inventory.AddProduct(new Product(
                        Convert.ToInt32(IDInput.Text),
                        NameInput.Text,
                        Convert.ToDouble(PriceInput.Text),
                        Convert.ToInt32(CountInput.Text),
                        Convert.ToInt32(MinCountInput.Text),
                        Convert.ToInt32(MaxCountInput.Text)
                        ));
            }
            else
            {
                Product updatedProduct;
                updatedProduct = new Product(
                        Convert.ToInt32(IDInput.Text),
                        NameInput.Text,
                        Convert.ToDouble(PriceInput.Text),
                        Convert.ToInt32(CountInput.Text),
                        Convert.ToInt32(MinCountInput.Text),
                        Convert.ToInt32(MaxCountInput.Text)
                        );
                Inventory.UpdateProduct(Convert.ToInt32(IDInput.Text), updatedProduct);
            }
            this.Hide();
        }

        private void PartSearchInput_Enter(object sender, EventArgs e)
        {
            PartSearchInput.Text = (PartSearchInput.Text == "Search by Part ID") ? "" : PartSearchInput.Text;
        }

        private void PartSearchInput_Leave(object sender, EventArgs e)
        {
            PartSearchInput.Text = (PartSearchInput.Text == "") ? "Search by Part ID" : PartSearchInput.Text;
        }

        private void PartSearchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (!int.TryParse(PartSearchInput.Text, out int searchID))
            {
                MessageBox.Show("Part ID must be numeric");
                return;
            }
            foreach (DataGridViewRow row in allPartsListDataGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == searchID)
                {
                    row.Selected = true;
                    found = true;
                    break;
                }
            }
            if (!found) { MessageBox.Show("Part ID not found"); }
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = allPartsListDataGrid.SelectedRows[0];
                var idVal = selectedRow.Cells["PartID"].Value;

                int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                Part part = Inventory.LookupPart(partID);

                associatedPartsBindingList.Add(part);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selected row contains null value for partID");
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No parts selected.");
            }
        }
    }
}
