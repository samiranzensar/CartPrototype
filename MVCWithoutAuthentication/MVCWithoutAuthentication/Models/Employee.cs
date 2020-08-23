using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithoutAuthentication.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Ename { get; set; }
		public double Esal { get; set; }
		public string City { get; set; }
		public Department Department { get; set; }
		public int DeptId { get; set; }
	}
}