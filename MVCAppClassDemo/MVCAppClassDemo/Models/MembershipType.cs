using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAppClassDemo.Models
{
	public class MembershipType
	{
		public int Id { get; set; }
		public short SignUpFree { get; set; }
		public int DurationInMonths { get; set; }
		public int DiscountRate { get; set; }
	}
}