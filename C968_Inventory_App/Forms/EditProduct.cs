using System;
using System.Collections;
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
            associatedPartsDataGrid.Columns["Price"].DefaultCellStyle.Format = "c";
            associatedPartsDataGrid.Columns["Price"].HeaderText = "Price/Cost Per Unit";
            associatedPartsDataGrid.Columns["PartID"].HeaderText = "Part ID";
            associatedPartsDataGrid.Columns["CompanyName"].Visible = false;
            associatedPartsDataGrid.Columns["MachineID"].Visible = false;
            associatedPartsDataGrid.Columns["Min"].Visible = false;
            associatedPartsDataGrid.Columns["Max"].Visible = false;

            
        }

        private void LoadProduct(Product product)
        {
            IDInput.Text = product.GetProductID().ToString();
            IDInput.Enabled = false;
            NameInput.Text = product.GetName();
            CountInput.Text = product.GetInStock().ToString();
            PriceInput.Text = product.GetPrice().ToString();
            MinCountInput.Text = product.GetMin().ToString();
            MaxCountInput.Text = product.GetMax().ToString();
            foreach (Part part in product.GetAssociatedParts())
            {
                associatedPartsBindingList.Add(part);
            }
            //associatedPartsDataGrid.DataSource = associatedPartsBindingList;
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
            RefreshButtonStates();
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = associatedPartsDataGrid.SelectedRows[0];
            int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
            Part partToDelete = Inventory.LookupPart(partID);
            associatedPartsBindingList.Remove(partToDelete);
            RefreshButtonStates();
        }

        private void RefreshButtonStates()
        {
            DeletePartButton.Enabled = associatedPartsBindingList.Count().Equals(0) ? false : true;
        }

        public override void SaveButton_Click(object sender, EventArgs e)
        {
            base.SaveButton_Click(sender, e);
        }
        public override void SaveItem()
        {
            ArrayList associatedPartsToSave = new ArrayList();
            foreach (Part part in associatedPartsBindingList)
            {
                associatedPartsToSave.Add(part);
            }

            if (isNew)
            {
                Inventory.AddProduct(new Product(
                    Convert.ToInt32(IDInput.Text),
                    NameInput.Text,
                    Convert.ToDouble(PriceInput.Text),
                    Convert.ToInt32(CountInput.Text),
                    Convert.ToInt32(MinCountInput.Text),
                    Convert.ToInt32(MaxCountInput.Text),
                    associatedPartsToSave
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
                        Convert.ToInt32(MaxCountInput.Text),
                        associatedPartsToSave
                        );
                Inventory.UpdateProduct(Convert.ToInt32(IDInput.Text), updatedProduct);
            }
            this.Hide();
        }
    }
}
