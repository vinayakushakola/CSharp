using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Inventory_Management
{
    class InventoryList
    {
        public List<InventoryData> Rice { get; set; }
        public List<InventoryData> Pulses { get; set; }
        public List<InventoryData> Wheats { get; set; }
    }
    class InventoryData
    {
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Price { get; set; }
    }
}
