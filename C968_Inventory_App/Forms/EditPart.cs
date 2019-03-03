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
    public partial class EditPart : ItemDetailForm
    {
        public EditPart()
        {
            InitializeComponent();
            EditPageLabel.Text = "Add Part";
            IDInput.Text = Convert.ToString(Inventory.nextPartID);
            IDInput.Enabled = false;
            isNew = true;
            SourceLabel.Text = "Machine ID";
            LoadForm();
        }

        public EditPart(Part part)
        {
            InitializeComponent();
            EditPageLabel.Text = "Modify Part";
            this.part = part;
            isNew = false;
            LoadPart(part);
        }
        public void LoadPart(Part part)
        {
            IDInput.Text = part.PartID.ToString();
            IDInput.Enabled = false;
            NameInput.Text = part.Name;
            CountInput.Text = part.InStock.ToString();
            PriceInput.Text = part.Price.ToString();
            MinCountInput.Text = part.Min.ToString();
            MaxCountInput.Text = part.Max.ToString();
            if (part is Inhouse)
            {
                InHouseRadio.Select();
                SourceLabel.Text = "Machine ID";
                SourceIDInput.Text = part.MachineID.ToString();
            }
            else
            {
                OutsourcedRadio.Select();
                SourceLabel.Text = "Company Name";
                SourceIDInput.Text = part.CompanyName.ToString();
            }
            LoadForm();
        }
        public override void LoadForm()
        {
            base.LoadForm();
            SourceIDInput.CausesValidation = true;
            SourceIDInput.Validating += new System.ComponentModel.CancelEventHandler(SourceIDInput_Validating);
        }
        private void SourceIDInput_Validating(object sender, CancelEventArgs e)
        {
            if (InHouseRadio.Checked)
            {
                e.Cancel = (int.TryParse(SourceIDInput.Text, out int n)) ? false : true;
            }
            else
            {
                e.Cancel = (SourceIDInput.Text.Length > 0) ? false : true;
            }
            if (e.Cancel)
            {
                SourceIDInput.BackColor = Color.Pink;
            }
        }
        public override void SaveItem()
        {
            if (isNew)
            {
                if (InHouseRadio.Checked)
                {
                    Inventory.AddPart(new Inhouse(
                            Convert.ToInt32(IDInput.Text),
                            NameInput.Text,
                            Convert.ToDouble(PriceInput.Text),
                            Convert.ToInt32(CountInput.Text),
                            Convert.ToInt32(MinCountInput.Text),
                            Convert.ToInt32(MaxCountInput.Text),
                            Convert.ToInt32(SourceIDInput.Text)
                            ));
                }
                else
                {
                    Inventory.AddPart(new Outsourced(
                        Convert.ToInt32(IDInput.Text),
                        NameInput.Text,
                        Convert.ToDouble(PriceInput.Text),
                        Convert.ToInt32(CountInput.Text),
                        Convert.ToInt32(MinCountInput.Text),
                        Convert.ToInt32(MaxCountInput.Text),
                        SourceIDInput.Text
                        ));
                }
            }
            else
            {
                Part updatedPart;
                if (InHouseRadio.Checked)
                {
                    updatedPart = new Inhouse(
                            Convert.ToInt32(IDInput.Text),
                            NameInput.Text,
                            Convert.ToDouble(PriceInput.Text),
                            Convert.ToInt32(CountInput.Text),
                            Convert.ToInt32(MinCountInput.Text),
                            Convert.ToInt32(MaxCountInput.Text),
                            Convert.ToInt32(SourceIDInput.Text)
                            );
                }
                else
                {
                    updatedPart = new Outsourced(
                            Convert.ToInt32(IDInput.Text),
                            NameInput.Text,
                            Convert.ToDouble(PriceInput.Text),
                            Convert.ToInt32(CountInput.Text),
                            Convert.ToInt32(MinCountInput.Text),
                            Convert.ToInt32(MaxCountInput.Text),
                            SourceIDInput.Text
                            );
                }

                Inventory.UpdatePart(Convert.ToInt32(IDInput.Text), updatedPart);
            }
            this.Hide();
        }

    }
}
