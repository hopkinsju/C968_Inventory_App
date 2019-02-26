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
        public EditProduct(Inventory inv, Product product)
            : base(inv, product)
        {
            InitializeComponent();
            EditPageLabel.Text = "Modify Product";
            PrepForm();
        }
        public EditProduct(Inventory inv)
            : base(inv)
        {
            InitializeComponent();
            EditPageLabel.Text = "Add Product";
            PrepForm();
        }

        private void PrepForm()
        {
            SourceIDInput.Hide();
            SourceLabel.Hide();
            InHouseRadio.Hide();
            OutsourcedRadio.Hide();
        }
    }
}
