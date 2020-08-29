using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppsCart.Models;

namespace WebAppsCart.ViewModel
{
	public class ProductViewModel
	{
		public Product Product { get; set; }
		public int Quantity { get; set; }
	}
}