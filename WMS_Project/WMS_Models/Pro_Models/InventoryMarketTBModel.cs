using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class InventoryMarketTBModel
	 {
		 public Guid  Id { get; set; }
		 public DateTime  MarketTimeId { get; set; }
		 public string  ProductTypeId { get; set; }
		 public decimal  Margin { get; set; }
	 }
}
