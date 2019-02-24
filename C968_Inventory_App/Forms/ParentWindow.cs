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
    public partial class ParentWindow : Form
    {
        public ParentWindow()
        {
            InitializeComponent();
            var main = new MainScreenForm
            {
                MdiParent = this
            };
            main.Show();
        }

    }

}
