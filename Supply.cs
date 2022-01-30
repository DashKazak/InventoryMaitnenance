using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{

    public class Supply : InvItem
    {

        //default constructor
        public Supply() { }
        // customized constructor
        public Supply(string ItemNo, string Manifacturer, string Description, string Price) : base(ItemNo, Description, Price)
        {
            this.Manifact = Manifacturer;
        }
        public string Manifact { get; set; }

        public override string GetDisplayText() => ItemNo +  "; " + Manifact + "; "+ Description + "; $"+ Price;

    }
}


