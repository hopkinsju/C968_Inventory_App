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
    public class Inventory
    {
        public static List<Product> Products = new List<Product>();
        public static List<Part> AllParts = new List<Part>();

        public static int nextPartID;
        public static int nextProductID;

        public static void AddProduct(Product product)
        {   
            Products.Add(product);
            ++nextProductID;
        }
        public static bool RemoveProduct(int productID)
        {
            try
            {
                Products.Remove(LookupProduct(productID));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.GetProductID() == productID)
                {
                    return product;
                }
            }
            return null;
        }
        public static void UpdateProduct(int productID, Product replacement)
        {
            Product product = Products.Find(x => x.GetProductID().Equals(productID));
            product = replacement;
        }
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
            ++nextPartID;
        }
        public static bool Deletepart(Part part)
        {
            try
            {
                AllParts.Remove(LookupPart(part.GetPartId()));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.GetPartId() == partID)
                {
                    return part;
                }
            }
            return null;
        }
        public static void UpdatePart(int partID, Part replacement)
        {
            System.Windows.Forms.MessageBox.Show("Updating Part");
            Part oldPart = AllParts.Where(i => i.PartID == partID).First();
            var index = AllParts.IndexOf(oldPart);

            if (index != -1)
                AllParts[index] = replacement;
            //NotifyPropertyChanged();
            //Part oldPart = LookupPart(partID);
            //System.Windows.Forms.MessageBox.Show($"oldPart name: {oldPart.GetName()}\nreplacement name: {replacement.GetName()}");
            oldPart = replacement;
            //System.Windows.Forms.MessageBox.Show($"oldPart name: {oldPart.GetName()}");

        }    }
}
