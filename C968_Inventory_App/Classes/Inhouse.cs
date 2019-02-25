using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_App
{
    class Inhouse : Part
    {
        private int machineID;
        public int MachineID
        {
            get
            {
                return machineID;
            }
            set
            {
                setMachineID(value);
            }
        }

        public Inhouse(int partID, string name, double price, int inStock, int min, int max, int machineID)
            : base(partID, name, price, inStock, min, max)
        {
            this.machineID = machineID;
        }

        public void setMachineID(int machineID)
        {
            this.machineID = machineID;
            NotifyPropertyChanged();
        }
        public int getMachineID()
        {
            return machineID;
        }

    }
}
