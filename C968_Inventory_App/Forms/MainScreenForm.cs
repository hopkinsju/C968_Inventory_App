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
    public partial class MainScreenForm : Form
    {
        // This BindingSource binds the list to the DataGridView control.  
        private BindingSource partsBindingSource = new BindingSource();
        private BindingSource productsBindingSource = new BindingSource();
        //public static Inventory inv = new Inventory();

        public MainScreenForm()
        {
            InitializeComponent();
            CreateDummyData();
        }

        private void CreateDummyData()
        {
            // Dummy Data
            Inventory.AddPart(new Inhouse(Inventory.nextPartID, "part 1", 10.00, 2, 0, 100, 1));
            Inventory.AddPart(new Inhouse(Inventory.nextPartID, "part 2", 11.55, 40, 3, 300, 2));
            Inventory.AddPart(new Outsourced(Inventory.nextPartID, "part 3", 12.10, 3, 0, 100, "Acme Co."));
            Inventory.AddProduct(new Product(Inventory.nextProductID, "product 1", 45.00, 15, 1, 25));
            Inventory.AddProduct(new Product(Inventory.nextProductID, "product 2", 45.00, 15, 1, 25));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            ItemDetailForm partForm = new ItemDetailForm()
            {
                MdiParent = this.MdiParent
            };

            partForm.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            EditProduct productForm = new EditProduct()
            {
                MdiParent = this.MdiParent
            };
            productForm.Show();
        }

        private void PartsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {



            // Bind dataview to AllParts list
            BindingList<Part> partsBindingList = new BindingList<Part>(Inventory.AllParts);
            this.partsBindingSource.DataSource = partsBindingList;
            this.PartsDataGrid.DataSource = this.partsBindingSource;
            

            PartsDataGrid.Columns["Price"].DefaultCellStyle.Format = "c";
            PartsDataGrid.Columns["Price"].HeaderText = "Price/Cost Per Unit";
            PartsDataGrid.Columns["CompanyName"].Visible = false;
            PartsDataGrid.Columns["MachineID"].Visible = false;
            PartsDataGrid.Columns["Min"].Visible = false;
            PartsDataGrid.Columns["Max"].Visible = false;


            // Bind dataview to Product list
            BindingList<Product> productsBindingList = new BindingList<Product>(Inventory.Products);
            this.productsBindingSource.DataSource = productsBindingList;
            this.ProductsDataGrid.DataSource = this.productsBindingSource;

            ProductsDataGrid.Columns["Price"].DefaultCellStyle.Format = "c";
            ProductsDataGrid.Columns["Price"].HeaderText = "Price/Cost Per Unit";
            ProductsDataGrid.Columns["Min"].Visible = false;
            ProductsDataGrid.Columns["Max"].Visible = false;
        }

        //private DataGridViewRow selectedRow;
        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = PartsDataGrid.SelectedRows[0];
                var idVal = selectedRow.Cells["PartID"].Value;

                if (idVal.Equals(null))
                {
                    throw new NullReferenceException("Selected row contains null value for partID");
                }
                int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                Part part = Inventory.LookupPart(partID);

                ItemDetailForm partForm = new ItemDetailForm(part)
                {
                    MdiParent = this.MdiParent
                };
                partForm.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selected row contains null value for partID");
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No parts exist to modify.");
            }
                
            
            
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = ProductsDataGrid.SelectedRows[0];

            int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
            Product product = Inventory.LookupProduct(productID);

            EditProduct productForm = new EditProduct(product)
            {
                MdiParent = this.MdiParent
            };
            productForm.Show();
        }

        private void MainScreenForm_Refresh(object sender, EventArgs e)
        {
            PartsDataGrid.Invalidate();
            ProductsDataGrid.Invalidate();
            productsBindingSource.ResetBindings(true);
            partsBindingSource.ResetBindings(true);
        }

        private void DebugParts_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder(); 
            foreach (Part part in Inventory.AllParts)
            {
                message.AppendLine($"{part.GetName()}");
            }
            MessageBox.Show(message.ToString());
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = PartsDataGrid.SelectedRows[0];
            int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
            Part partToDelete = Inventory.LookupPart(partID);
            Inventory.Deletepart(partToDelete);
            RefreshDataGridViews();
        }

        private void RefreshDataGridViews()
        {
            partsBindingSource.ResetBindings(true);
            ModifyPartButton.Enabled = Inventory.AllParts.Count().Equals(0) ? false : true;
            productsBindingSource.ResetBindings(true);
            ModifyProductButton.Enabled = Inventory.Products.Count().Equals(0) ? false : true;
        }

        private void MainScreenForm_Activated(object sender, EventArgs e)
        {
            RefreshDataGridViews();
        }
    }
}
