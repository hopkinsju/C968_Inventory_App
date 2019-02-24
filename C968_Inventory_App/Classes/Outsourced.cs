using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_App
{
    class Outsourced : Part
    {
        private string companyName;

        public Outsourced(int partID, string name, double price, int inStock, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        {
            this.companyName = companyName;
        }

        public void SetCompanyName(string companyName)
        {
            this.companyName = companyName;
            NotifyPropertyChanged();
        }
        public string GetCompanyName()
        {
            return companyName;
        }
    }
}
