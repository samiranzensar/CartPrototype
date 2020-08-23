using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCAppClassDemo.Models;

namespace MVCAppClassDemo.View_Model
{
	public class CustMovViewModel
	{
		public Movie Movie { get; set; }
		public List<Customer> Customers { get; set; }
	}
}