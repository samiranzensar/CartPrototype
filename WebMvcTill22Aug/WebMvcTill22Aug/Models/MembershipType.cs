using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMvcTill22Aug.Models
{
	public class MembershipType
	{
		public int Id { get; set; }
		[Required]
		[StringLength(20)]
		public string PlanName { get; set; }
		public short SignUpFees { get; set; }
		public byte DurtionInMonths { get; set; }
		public byte DiscountRate { get; set; }
	}
}