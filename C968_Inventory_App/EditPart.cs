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
    public partial class EditPart : Form
    {
        public EditPart(int partID)
        {
            InitializeComponent();
            this.EditPartLabel.Text = "Modify Part";
        }
        public EditPart()
        {
            InitializeComponent();
            this.EditPartLabel.Text = "Add Part";
        }

        private void PartCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }       
    }
}
