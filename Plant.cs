using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class Plant: InvItem
    {
        
        //default constructor
        public Plant() { }
        // customized constructor
        public Plant(string ItemNo, string size, string Description, string Price) : base(ItemNo, Description, Price)
        {
            this.Size = size;
        }
        public string Size { get; set; }

        public override string GetDisplayText() =>ItemNo + "; " + Size + "; " + Description + "; $" + Price;

    }
}
