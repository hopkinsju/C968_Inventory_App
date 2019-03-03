using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_App
{
    public class Outsourced : Part
    {
        private string companyName;
        public override string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                SetCompanyName(value);
            }
        }
        public override int MachineID { set; get; }

        public Outsourced(int partID, string name, double price, int inStock, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        {
            this.companyName = companyName;
        }

        public void SetCompanyName(string companyName)
        {
            this.companyName = companyName;
        }
        public string GetCompanyName()
        {
            return companyName;
        }
    }
}
