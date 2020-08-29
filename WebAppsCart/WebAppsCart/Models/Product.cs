using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppsCart.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string PName { get; set; }
		public double Price { get; set; }
		public string ImagePath { get; set; }
	}
}