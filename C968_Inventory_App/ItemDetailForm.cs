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
        public ItemDetailForm(int partID)
        {
            InitializeComponent();
            this.EditPageLabel.Text = "Modify Part";
        }
        public ItemDetailForm()
        {
            InitializeComponent();
            this.EditPageLabel.Text = "Add Part";
            //this.PartCancelButton.Location = new System.Drawing.Point(FindForm().Right - 100, FindForm().Bottom - 60);
        }

        private void PartCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditPartForm_change(object sender, EventArgs e)
        {
            this.CancelButton.Location = new System.Drawing.Point(Width - 130, Height - 120);
            this.SaveButton.Location = new System.Drawing.Point(CancelButton.Left - SaveButton.Width - 20, CancelButton.Top);
        }


    }
}
