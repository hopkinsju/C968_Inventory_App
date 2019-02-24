using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_App
{
    abstract class Part : INotifyPropertyChanged
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
                return name;
            }

            set
            {
                this.name = value;
                NotifyPropertyChanged();
            }
        }

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private double price;
        public double Price {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
                NotifyPropertyChanged("Price");
            }
        }
        private int inStock;
        public int InStock { get; set; }
        private int min;
        public int Min { get; set; }
        private int max;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Max { get; set; }

        public Part(int partID, string name, double price, int inStock, int min, int max)
        {
            this.partID = partID;
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
        public void SetPartId(int partID)
        {
            this.partID = partID;
            NotifyPropertyChanged();
        }
        public int GetPartId()
        {
            return partID;
        }
    }
}
