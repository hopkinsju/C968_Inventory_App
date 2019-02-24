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

        public MainScreenForm()
        {
            InitializeComponent();
            //Inventory inv = new Inventory();
            //// Dummy Data
            //inv.AddPart(new Inhouse(inv.NextPartID, "part 1", 10.00, 2, 0, 100, 1));
            //inv.AddPart(new Inhouse(inv.NextPartID, "part 2", 11.00, 40, 3, 300, 2));
            //inv.AddPart(new Outsourced(inv.NextPartID, "part 3", 12.00, 3, 0, 100, "Acme Co."));
            //inv.AddProduct(new Product(inv.NextProductID, "product 1", 45.00, 15, 1, 25));
            //BindingList<Part> partsBindingList = new BindingList<Part>(inv.AllParts);
            //this.partsBindingSource.DataSource = partsBindingList;
            //this.PartsDataGrid.DataSource = this.partsBindingSource;
            //var productsBindingList = new BindingList<Product>(inv.Products);
            //var productsBindingSource = new BindingSource(productsBindingList, null);
            //ProductsDataGrid.DataSource = productsBindingSource;

            //ProductsDataGrid.Update();
            //ProductsDataGrid.Refresh();

            //var list = new BindingList<Person>(persons);
            //myGrid.DataSource = list;
            //But I would even go further and bind your grid to a BindingSource

            //var list = new List<Person>()
            //{
            //    new Person { Name = "Joe", },
            //    new Person { Name = "Misha", },
            //};
            //var bindingList = new BindingList<Person>(list);
            //var source = new BindingSource(bindingList, null);
            //grid.DataSource = source;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            var partForm = new ItemDetailForm();
            partForm.MdiParent = this.MdiParent;
            partForm.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var productForm = new EditProduct();
            productForm.MdiParent = this.MdiParent;
            productForm.Show();
        }

        private void PartsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            // Dummy Data
            inv.AddPart(new Inhouse(inv.NextPartID, "part 1", 10.00, 2, 0, 100, 1));
            inv.AddPart(new Inhouse(inv.NextPartID, "part 2", 11.55, 40, 3, 300, 2));
            inv.AddPart(new Outsourced(inv.NextPartID, "part 3", 12.10, 3, 0, 100, "Acme Co."));
            inv.AddProduct(new Product(inv.NextProductID, "product 1", 45.00, 15, 1, 25));
            BindingList<Part> partsBindingList = new BindingList<Part>(inv.AllParts);
            this.partsBindingSource.DataSource = partsBindingList;
            this.PartsDataGrid.DataSource = this.partsBindingSource;
        }
    }
}
