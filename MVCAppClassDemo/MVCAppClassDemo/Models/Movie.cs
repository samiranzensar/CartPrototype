using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCAppClassDemo.Models
{
	public class Movie //POCO Class
	{
		//[Key()]
		public int Id { get; set; }
		public string Name { get; set; }
	}
}