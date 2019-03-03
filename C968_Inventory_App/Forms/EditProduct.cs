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
        public EditProduct(Product product)
        {
            InitializeComponent();
            EditPageLabel.Text = "Modify Product";
            PrepForm();
            this.product = product;
        }

        public EditProduct()
        {
            InitializeComponent();
            EditPageLabel.Text = "New Product";
            PrepForm();
        }

        private void PrepForm()
        {
            SourceIDInput.Hide();
            SourceLabel.Hide();
            InHouseRadio.Hide();
            OutsourcedRadio.Hide();
        }

        private void 
            SaveButton_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                Product newProduct = new Product(
                    Inventory.nextProductID, 
                    NameInput.Text, 
                    Convert.ToDouble(PriceInput.Text), 
                    Convert.ToInt32(CountInput.Text),
                    Convert.ToInt32(MinCountInput),
                    Convert.ToInt32(MaxCountInput)
                    );
                Inventory.AddProduct(newProduct);
                this.Hide();
            }
        }
    }
}
