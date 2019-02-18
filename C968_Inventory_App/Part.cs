using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_App
{
    class Part
    {
        private int id;

        public int Id
        {
            get { return id; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int currentInventory;

        public int CurrentInventory
        {
            get { return currentInventory; }
            set { currentInventory = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }



    }
}
