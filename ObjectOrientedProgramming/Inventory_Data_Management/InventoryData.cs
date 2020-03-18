using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming.Inventory_Data_Management
{
    class InventoryData
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
    class InventoryList
    {
        public List<InventoryData> Rice { get; set; }
        public List<InventoryData> Pulses { get; set; }
        public List<InventoryData> Wheats { get; set; }
    }

    class Prices
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class InventoryDataTotalPrice
    {
        public List<Prices> Prices { get; set; }
    }
}
