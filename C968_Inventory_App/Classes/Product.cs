using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_App
{
    public class Product
    {
        private ArrayList associatedParts;
        private int productID;
        public int ProductID
        {
            get
            {
                return GetProductID();
            }
            set
            {
                SetProductID(value);
            }
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

        public Product(string name, double price, int inStock, int min, int  max)
            : this(Inventory.GetNextProductID(), name, price, inStock, min, max) { }

        public Product(int productID, string name, double price, int inStock, int min, int max)
        {
            associatedParts = new ArrayList();
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public Product(int productID, string name, double price, int inStock, int min, int max, ArrayList associatedParts)
            :this(productID, name, price, inStock, min, max)
        {
            this.associatedParts = associatedParts;
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
            if (max < min) {
                throw new Exception("Max cannot be less than min");
            }
            this.max = max;
        }
        public int GetMax()
        {
            return max;
        }
        public void SetProductID(int productID)
        {
            this.productID = productID;
        }
        public int GetProductID()
        {
            return productID;
        }
        public ArrayList GetAssociatedParts()
        {
            return associatedParts;
        }
        public void AddAssociatedPart(Part part)
        {
            associatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partID)
        {
            try
            {
                associatedParts.Remove(LookupAssociatedPart(partID));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in associatedParts)
            {
                if (part.GetPartId() == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
