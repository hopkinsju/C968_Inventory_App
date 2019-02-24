using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_App
{
    class Inventory : INotifyPropertyChanged
    {
        private List<Product> products;

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        private List<Part> allParts;
        public List<Part> AllParts
        {
            get { return allParts; }
            set { allParts = value; NotifyPropertyChanged(); }
        }

        private int nextPartID;
        public int NextPartID {
            get
            {
                return nextPartID;
            }
            set {
                this.nextPartID = value;
                NotifyPropertyChanged();
            }
            
        }

        private void NotifyPropertyChanged()
        {
            throw new NotImplementedException();
        }

        private int nextProductID;

        public event PropertyChangedEventHandler PropertyChanged;

        public int NextProductID { get; set; }

        public Inventory()
        {
            nextPartID = 0;
            nextProductID = 0;
            products = new List<Product>();
            allParts = new List<Part>();

        }

        public void AddProduct(Product product)
        {   
            products.Add(product);
            ++this.nextProductID;
        }
        public bool RemoveProduct(int productID)
        {
            try
            {
                products.Remove(LookupProduct(productID));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Product LookupProduct(int productID)
        {
            foreach (Product product in products)
            {
                if (product.GetProductID() == productID)
                {
                    return product;
                }
            }
            return null;
        }
        public void UpdateProduct(int productID, Product replacement)
        {
            Product product = products.Find(x => x.GetProductID().Equals(productID));
            product = replacement;
        }
        public void AddPart(Part part)
        {
            allParts.Add(part);
            ++this.nextPartID;
        }
        public bool Deletepart(Part part)
        {
            try
            {
                allParts.Remove(LookupPart(part.GetPartId()));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Part LookupPart(int partID)
        {
            foreach (Part part in allParts)
            {
                if (part.GetPartId() == partID)
                {
                    return part;
                }
            }
            return null;
        }
        public void UpdatePart(int partID, Part replacement)
        {
            Part part = allParts.Find(x => x.GetPartId().Equals(partID));
            part = replacement;
        }    }
}
