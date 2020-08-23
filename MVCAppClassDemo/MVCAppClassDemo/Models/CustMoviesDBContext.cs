using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAppClassDemo.Models
{
	public class CustMoviesDBContext:DbContext
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<MembershipType> MemberShipTypes { get; set; }
	}
}