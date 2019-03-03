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
        public ArrayList associatedParts;
        private int productID;
        public int ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }
        private string name;
        public string Name {
            get
            {
                return name;
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
                return price;
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
                return inStock;
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
                return min;
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
                return max;
            }
            set
            {
                SetMax(value);
            }
        }

        public Product(int productID, string name, double price, int inStock, int min, int max)
        {
            associatedParts = new ArrayList();
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.inStock = inStock;
            this.min = min;
            this.max = max;
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
