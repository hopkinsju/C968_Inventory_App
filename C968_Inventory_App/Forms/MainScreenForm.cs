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
        public static Inventory inv = new Inventory();

        public MainScreenForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            ItemDetailForm partForm = new ItemDetailForm(inv)
            {
                MdiParent = this.MdiParent
            };
            partForm.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            EditProduct productForm = new EditProduct(inv)
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

            // Dummy Data
            inv.AddPart(new Inhouse(inv.NextPartID, "part 1", 10.00, 2, 0, 100, 1));
            inv.AddPart(new Inhouse(inv.NextPartID, "part 2", 11.55, 40, 3, 300, 2));
            inv.AddPart(new Outsourced(inv.NextPartID, "part 3", 12.10, 3, 0, 100, "Acme Co."));
            inv.AddProduct(new Product(inv.NextProductID, "product 1", 45.00, 15, 1, 25));
            inv.AddProduct(new Product(inv.NextProductID, "product 2", 45.00, 15, 1, 25));

            // Bind dataview to AllParts list
            BindingList<Part> partsBindingList = new BindingList<Part>(inv.AllParts);
            this.partsBindingSource.DataSource = partsBindingList;
            this.PartsDataGrid.DataSource = this.partsBindingSource;
            PartsDataGrid.Columns["Price"].DefaultCellStyle.Format = "c";
            PartsDataGrid.Columns["Price"].HeaderText = "Price/Cost Per Unit";
            PartsDataGrid.Columns["CompanyName"].Visible = false;
            PartsDataGrid.Columns["MachineID"].Visible = false;
            PartsDataGrid.Columns["Min"].Visible = false;
            PartsDataGrid.Columns["Max"].Visible = false;


            // Bind dataview to Product list
            BindingList<Product> productsBindingList = new BindingList<Product>(inv.Products);
            this.productsBindingSource.DataSource = productsBindingList;
            this.ProductsDataGrid.DataSource = this.productsBindingSource;
        }

        //private DataGridViewRow selectedRow;
        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = PartsDataGrid.SelectedRows[0];

            int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
            Part part = inv.LookupPart(partID);

            ItemDetailForm partForm = new ItemDetailForm(inv, part)
            {
                MdiParent = this.MdiParent
            };
            partForm.Show(); 
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = ProductsDataGrid.SelectedRows[0];

            int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
            Product product = inv.LookupProduct(productID);

            EditProduct productForm = new EditProduct(inv, product)
            {
                MdiParent = this.MdiParent
            };
            productForm.Show();
        }
    }
}
