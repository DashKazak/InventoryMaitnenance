using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
	public class InvItem
	{
		public InvItem()
		{
		}

		public InvItem(string ItemNo, string Description, string Price) =>
			(this.ItemNo, this.Description, this.Price) = (ItemNo, Description, Price);

		public string ItemNo { get; set; }

		public string Description { get; set; }

		public string Price { get; set; }

		public virtual string GetDisplayText() => ItemNo + " " + Description + ", $" + Price;
	}
}
