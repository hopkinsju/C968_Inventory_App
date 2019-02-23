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
        public MainScreenForm()
        {
            InitializeComponent();
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
    }
}
