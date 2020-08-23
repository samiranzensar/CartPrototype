using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMvcTill22Aug.Models
{
	public class Customer
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="Please Insert Name")]
		public string CName { get; set; }
		public DateTime DOB { get; set; }
		public bool IsSubscribedToNewsLetter { get; set; }
		public MembershipType MembershipType { get; set; }
		public int MembershipTypeId { get; set; }
	}
}