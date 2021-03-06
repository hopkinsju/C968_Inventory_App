﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_App
{
    public class Inhouse : Part
    {
        private int machineID;
        public override int MachineID
        {
            get
            {
                return GetMachineID();
            }
            set
            {
                SetMachineID(value);
            }
        }

        public Inhouse() {}
        public Inhouse(string name, double price, int inStock, int min, int max, int machineID)
            : base(name, price, inStock, min, max)
        {   
            MachineID = machineID;
        }
        public Inhouse(int partID, string name, double price, int inStock, int min, int max, int machineID)
            : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }

        public void SetMachineID(int machineID)
        {
            this.machineID = machineID;
        }
        public override int GetMachineID()
        {
            return machineID;
        }

    }
}
