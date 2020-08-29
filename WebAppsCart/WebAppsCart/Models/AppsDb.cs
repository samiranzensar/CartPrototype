using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppsCart.Models
{
	public class AppsDb:DbContext
	{
		public DbSet<Product> Products { get; set; }
	}
}