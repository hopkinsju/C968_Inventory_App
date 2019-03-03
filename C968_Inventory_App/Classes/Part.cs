using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_App
{
    public abstract class Part
    {
        private int partID;
        public int PartID
        {
            get { return GetPartId(); }
            set { SetPartId(value); }
        }
        private string name;
        public string Name {
            get
            {
                return GetName();
            }

            set
            {
                SetName(value);
            }
        }
        private double price;
        public double Price {
            get
            {
                return GetPrice();
            }
            set
            {
                SetPrice(value);
            }
        }
        private int inStock;
        public int InStock {
            get
            {
                return GetInStock();
            }
            set
            {
                SetInStock(value);
            }
        }
        private int min;
        public int Min {
            get
            {
                return GetMin();
            }
            set
            {
                SetMin(value);
            }
        }
        private int max;
        public int Max {
            get
            {
                return GetMax();
            }
            set
            {
                SetMax(value);
            }
        }
        public abstract int MachineID { get; set; }
        public abstract string CompanyName { get; set; }

        public Part() {}
        public Part(int partID, string name, double price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPrice(double price)
        {
            if (price <= 0)
            {
                throw new Exception("Price cannot be negative or zero");
            }
            this.price = price;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetInStock(int inStock)
        {
            this.inStock = inStock;
        }
        public int GetInStock()
        {
            return inStock;
        }
        public void SetMin(int min)
        {
            this.min = min;
        }
        public int GetMin()
        {
            return min;
        }
        public void SetMax(int max)
        {
            if (max < min)
            {
                throw new Exception("Max cannot be less than min");
            }
            this.max = max;
        }
        public int GetMax()
        {
            return max;
        }
        public void SetPartId(int partID)
        {
            this.partID = partID;
        }
        public int GetPartId()
        {
            return partID;
        }
    }
}
